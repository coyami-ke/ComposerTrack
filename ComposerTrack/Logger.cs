using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerTrack
{
    public class Logger
    {
        private FileStream stream;
        private StreamWriter writer;
        public string Name;

        public Logger(string path, string name)
        {
            if (!File.Exists(path)) File.Create(path).Dispose();

            stream = new(path, FileMode.Append);
            writer = new(stream);
            Name = name;
        }

        public void Info(string message)
        {
            writer.WriteLine($"[Info] [{Name}]: {message}");
        }
        public void Warn(string message)
        {
            writer.WriteLine($"[Warning] [{Name}]: {message}");
        }
        public void Error(string message)
        {
            writer.WriteLine($"[ERROR] [{Name}]: {message}");
        }
    }
}
