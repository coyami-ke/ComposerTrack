using System.Diagnostics;
using System.Reflection;

#nullable disable
namespace ComposerTrack.Compiled
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<======================================================================>");
            Console.WriteLine(" ComposerTrack Console by dropsy. Enter <help> for get list of commands");
            Console.WriteLine($" Version of ComposerTrack Console: {Assembly.GetExecutingAssembly().GetName().Version}");
            Console.WriteLine("<======================================================================>");

            string command = Console.ReadLine();
            switch (command)
            {
                case "help":
                    Console.WriteLine("< run > - Run ComposerTrack and close this application.");
                    Console.WriteLine("< run debug > - Run ComposerTrack with information about ComposerTrack");
                    break;
                case "run debug":
                    Process process = new();
                    process.StartInfo = new ProcessStartInfo("ComposerTrack.exe");
                    process.Start();
                    process.PriorityClass = ProcessPriorityClass.Normal;
                    process.Exited += Process_Exited;
                    break;
            }

            Console.ReadKey();
        }

        private static void Process_Exited(object sender, EventArgs e)
        {
            Console.WriteLine("Process closed!");
        }
    }
}