using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace ExtensionCreator
{
    public class Main
    {
        public event EventHandler<MessageArgs> MessageRecived;

        public List<Extension> Extensions { get; private set; }
        public string DirectoryExtensions { get; private set; }
        public Version VersionAPI { get; }
        public Main(string directoryExtensions)
        {
            VersionAPI = new(1,0,0);

            DirectoryExtensions = directoryExtensions;

            if (!Directory.Exists(DirectoryExtensions)) Directory.CreateDirectory(DirectoryExtensions);

            Extensions = new();
        }
        public void LoadExtensions()
        {
            JsonSerializer serializer = new();
            foreach (string dir in Directory.GetDirectories(DirectoryExtensions))
            {
                StreamReader reader = new($"{dir}/info.json");
                ExtensionData data = (ExtensionData)serializer.Deserialize(reader, typeof(ExtensionData));

                Assembly assembly = Assembly.LoadFrom($"{dir}/{data.Name}.dll");
                Type type = assembly.GetType($"{data.Name}.Main");

                if (type is null) MessageRecived?.Invoke(this, new MessageArgs(MessageTypes.Error, @$"Class Main in DLL {data.Name} does not exists!"));
            }
        }
    }
}
