using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BasicFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string windirStr =
            System.Environment.GetEnvironmentVariable("windir");
            DirectoryInfo directoryInfo =
                new DirectoryInfo(windirStr);
            if (directoryInfo.Exists)
                Console.WriteLine("Directory: {0}", 
                    directoryInfo.FullName.ToString());

            //search all the files in the current directory
            FileInfo[] fileInfo =
                directoryInfo.GetFiles("*.bmp", SearchOption.TopDirectoryOnly);

            // search all the files in the current directory and subdirectories
           // FileInfo[] fileInfo =
           //directoryInfo.GetFiles("*.bmp", SearchOption.AllDirectories);
            Console.WriteLine("Number of found files in {0} is {1}\n",
                windirStr, fileInfo.Length.ToString());

            foreach (FileInfo file in fileInfo)
            {
                Console.WriteLine("File Name: {0}\n\tLength: {1}" +
                    "Creation Time: {2}\n\tAttributes: {3}\n",
                    file.FullName, file.Length,
                    file.CreationTime, file.Attributes);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
