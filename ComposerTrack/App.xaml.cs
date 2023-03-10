using ComposerTrack.API;
using ComposerTrack.ViewModels;
using ComposerTrack.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

#nullable disable
namespace ComposerTrack
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static HomeWindow HomeWindow { get; set; }
        public static CreateProjectWindow CreateProjectWindow { get; set; }
        public static EditorWindow EditorWindow { get; set; }
        public static Logger MainLogger { get; set; }
        internal static ExtensionManager ExtensionManager { get; set; }
        internal static LoadingWindow LoadingWindow { get; set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            StaticViewModels.Home = new();
            StaticViewModels.CreateProject = new();
            StaticViewModels.Editor = new();

            LoadingWindow = new();
            LoadingWindow.Value.Value = 0;
            LoadingWindow.Show();

            MainLogger = new("log.txt", "Main");

            ExtensionManager = new(new Version(1, 0, 0, 0), ExtensionManagerMode.Default);
            ExtensionManager.MessageReceived += ExtensionManager_MessageReceived;

            LoadingWindow.KeyDown += LoadingWindow_KeyDown;

            ExtensionManager.PreInitExtensions();
            ExtensionManager.InitExtensions();

            EditorWindow = new();
            EditorWindow.DataContext = StaticViewModels.Editor;

            EditorWindow.Show();
        }

        private void ExtensionManager_MessageReceived(object sender, MessageArgs e)
        {
            LoadingWindow.Message.Text = e.Message;
        }

        private void LoadingWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.SystemKey != System.Windows.Input.Key.LeftShift) return;

            if (e.Key == System.Windows.Input.Key.S)
            {
                ExtensionManager.Mode = ExtensionManagerMode.Safe;
            }
            if (e.Key == System.Windows.Input.Key.W)
            {
                ExtensionManager.Mode = ExtensionManagerMode.WithoutExtensions;
            }
        }
    }
}
