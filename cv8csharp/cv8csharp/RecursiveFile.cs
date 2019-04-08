using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv8csharp
{
    class RecursiveFile
    {
        public static void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}'.", path);
        }

        public static void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        public static int NumberOfFiles()
        {
            DirectoryInfo di = new DirectoryInfo("c:\\");
            int pocet = di.GetFiles().Length;
            return pocet;
        }







        static void Main(string[] args)
        {
            // Make a reference to a directory.
            DirectoryInfo di = new DirectoryInfo("c:\\");

            // Get a reference to each directory in that directory.
            DirectoryInfo[] diArr = di.GetDirectories();

            // Display the names of the directories.
            foreach (DirectoryInfo dri in diArr)
                Console.WriteLine(dri.Name);

            foreach (string path in args)
            {
                if (File.Exists(path))
                {
                    // This path is a file
                    ProcessFile(path);
                }
                else if (Directory.Exists(path))
                {
                    // This path is a directory
                    ProcessDirectory(path);
                }
                else
                {
                    Console.WriteLine("{0} is not a valid file or directory.", path);
                }
            }
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\zuzul\Documents\");
            Console.WriteLine("No search pattern returns:");
            foreach (var fi in di.GetFiles())
            {
                Console.WriteLine(fi.Name);
            }

            Console.WriteLine();

            Console.WriteLine("Search pattern *2* returns:");
            foreach (var fi in di.GetFiles("*2*"))
            {
                Console.WriteLine(fi.Name);
            }

            Console.WriteLine();

            Console.WriteLine("Search pattern ?.txt returns:");
            foreach (var fi in di.GetFiles("?.txt"))
            {
                Console.WriteLine(fi.Name);
            }

            Console.WriteLine();

            Console.WriteLine("Search pattern AllDirectories returns:");
            //foreach (var fi in di.GetFiles("*", SearchOption.AllDirectories))
            //{
            //    Console.WriteLine(fi.Name);
            //}
            var files = new List<FileInfo>();
            foreach (var fi in di.GetFiles(""))
            {
                var results = di.GetFiles("fi", SearchOption.AllDirectories);
                files.AddRange(results);
            }


            int pocet = NumberOfFiles();
            Console.WriteLine("number of files: "+ pocet);
        }
    }
}
