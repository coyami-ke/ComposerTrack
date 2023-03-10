using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace ComposerTrack.API
{
    public enum ExtensionManagerMode
    {
        Default,
        Safe,
        WithoutExtensions,
    }
    public enum MessageType
    {
        Info,
        Warn,
        Error,
    }
    public class MessageArgs : EventArgs
    {
        public MessageArgs(string message, MessageType type)
        {
            Message = message;
            MessageType = type;
        }
        public string Message;
        public MessageType MessageType;
    }
    public class ExtensionManager
    {
        internal Logger logger; // Logger for ExtensionManager
        internal Thread thread; // Thread for ExtensionManager

        public event EventHandler<MessageArgs> MessageReceived;

        /// <summary>
        /// Directory, where contains all extensions
        /// </summary>
        public const string DIRECTORY_EXTENSIONS = @"extensions\";
        /// <summary>
        /// File for logging
        /// </summary>
        public const string FILE_LOGGER = "extension_manager.txt";
        /// <summary>
        /// Extensions
        /// </summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>
        /// Mode 
        /// </summary>
        public ExtensionManagerMode Mode { get; internal set; }
        /// <summary>
        /// Current version API.
        /// </summary>
        public Version VersionAPI { get; private set; }
        /// <summary>
        /// Base constructor for ExtensionManager.
        /// </summary>
        /// <param name="versionAPI">Version API</param>
        /// <param name="mode">Mode</param>
        public ExtensionManager(Version versionAPI, ExtensionManagerMode mode)
        {
            // Initialization of logger
            logger = new Logger(FILE_LOGGER, "ExtensionManager");

            thread = new(() =>
            {
                MessageReceived += ExtensionManager_MessageReceived;

                // Check. if version API is null, error
                if (versionAPI is null) logger.Error("Error of ExtensionManager. Version API is null.");
                VersionAPI = versionAPI;

                if (!Directory.Exists(DIRECTORY_EXTENSIONS)) Directory.CreateDirectory(DIRECTORY_EXTENSIONS);

                Extensions = new List<Extension>();

                logger.Info($"ExtensionManager Information: Version: {VersionAPI}, Mode: {Mode}, directory for extensions: {DIRECTORY_EXTENSIONS}");
            });

            thread.Priority = ThreadPriority.Highest;
            thread.Start();
        }

        /// <summary>
        /// Pre-initialization
        /// </summary>
        public void PreInitExtensions()
        {
            // Main thread for ExtensionManager
            thread = new(() =>
            {
                if (Mode == ExtensionManagerMode.WithoutExtensions)
                {
                    MessageReceived(this, new MessageArgs("Pre-Initialization has been cancelled.", MessageType.Warn));
                    return;
                }
                // Get all DLL.
                foreach (string file in Directory.GetFiles(DIRECTORY_EXTENSIONS))
                {
                    Assembly assembly; 
                    try
                    {
                        assembly = Assembly.LoadFrom(file); // Load assembly

                        Type type = assembly.GetType("Main"); // Get type Main
                        if (type == null || !type.IsClass) // Checks, if type is nullable or type is not class, do not load
                        {
                            continue;
                        }

                        Extension extension = Activator.CreateInstance<Extension>(); // Creates instance
                        extension.PreInit();

                        if (Mode == ExtensionManagerMode.Safe && !extension.IsOfficial) continue; // if safe mode, and extension is not official, do not load

                        if (extension.VersionAPI < VersionAPI)
                        {
                            continue;
                        }

                        Extensions.Add(extension); // Add extension to ExtensionManager
                    }
                    catch (Exception ex)
                    {
                        MessageReceived(this, new MessageArgs(ex.StackTrace, MessageType.Error));
                    }
                }
            });

            thread.Priority = ThreadPriority.Highest;
            thread.Start();
        }
        /// <summary>
        /// Initialization
        /// </summary>
        public void InitExtensions()
        {
            thread = new(() =>
            {
                for (int i = 0; Extensions.Count > 0; i++)
                {
                    try
                    {
                        Extensions[i].Init();
                        MessageReceived(this, new MessageArgs($"{Extensions[i].Name} Loaded!", MessageType.Info));
                    }
                    catch (Exception ex)
                    {
                        MessageReceived(this, new MessageArgs($"Initialization error: {ex.StackTrace}", MessageType.Error));
                    }
                }
            });
        }

        private void ExtensionManager_MessageReceived(object sender, MessageArgs e)
        {
            if (e.MessageType == MessageType.Info)
            {
                logger.Info(e.Message);
            }
            if (e.MessageType == MessageType.Warn)
            {
                logger.Warn(e.Message);
            }
            if (e.MessageType == MessageType.Error)
            {
                logger.Error(e.Message);
            }
        }
    }
}
