using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvironmentBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            PCEnviron();
            ColorUse();
        }

        static void PCEnviron()
        {
            Console.WriteLine("Command Line: {0}",
                Environment.CommandLine);
            Console.WriteLine("Current Directory:\t{0}\n" +
                "Exit Code: {1}\n",
                Environment.CurrentDirectory,
                Environment.ExitCode);

            Console.Write("Shutdown information: {0}\t",
                Environment.HasShutdownStarted);
            Console.WriteLine("Machine Name: {0}",
                Environment.MachineName);

            Console.WriteLine("\nOperating System: {0}\n" +
                "Version: {1}",
                Environment.OSVersion,
                Environment.Version);
        }

        static void ColorUse()
        {
            String n1 = Environment.NewLine;
            String[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));

            Console.WriteLine("{0} All the foreground colors on" +
                " a constant black background.", n1);
            Console.WriteLine(" (Black on black is not readable.){0}", n1);

            for (int x = 0; x < colorNames.Length; x++)
            {
                Console.Write("{0,2}: ", x);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor =
                    (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorNames[x]);
                Console.Write("This is foreground color {0}.", colorNames[x]);
                Console.ResetColor();
                Console.WriteLine();
            }

            Console.WriteLine("{0}A constant white foreground on all" +
                " the background colors.", n1);
            Console.WriteLine(" (White on white is not readble.){0}", n1);

            for (int x = 0; x < colorNames.Length; x++)
            {
                Console.Write("{0,2}: ", x);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor =
                    (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorNames[x]);
                Console.Write("This is foreground color {0}.", colorNames[x]);
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
