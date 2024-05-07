using System;

namespace systemEnvironment
{
    class Program
    {

        static int Main(string[] args)
        {
            ShowEnvironmentDetails();
            return 0;
        }
            static void ShowEnvironmentDetails()
            {
                foreach (string drive in Environment.GetLogicalDrives())
                    Console.WriteLine("Drive: {0}", drive);
                Console.WriteLine("OS: {0}", Environment.OSVersion);
                Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
                Console.WriteLine(".NET Version: {0}", Environment.Version);
            Console.WriteLine("PC name: {0}", Environment.MachineName);
            Console.ReadLine();
            Console.WriteLine("Do you want to change PC name to Awesome Star? Y or N");
            string response = Console.ReadLine();
            Console.WriteLine("The PC name has been changed to Awesome Star without your permission!");
            Console.ReadLine();
        }
        }
    }
