using Newtonsoft.Json;
using System;

namespace ComposerTrack.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                System.Console.WriteLine("Commands:");
            }
            if (args[0] == "jsonserializer")
            {
                StreamWriter writer = new(args[1]);
                JsonSerializer serializer = new();
                serializer.Serialize()
            }
        }
    }
}