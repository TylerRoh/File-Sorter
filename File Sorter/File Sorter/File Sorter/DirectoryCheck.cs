using System;
using System.Collections.Generic;
using System.IO;
namespace File_Sorter
{
    public class DirectoryCheck
    {
        
        public static bool checkDirectories(string path)
        {
            var neededDirectories = new List<string>() {"PDF","EXE","EXCEL","DOCUMENTS","ZIP"};
            Console.WriteLine("The following directories are needed: ");
            foreach (var directory in neededDirectories)
            {
                if (Directory.Exists(path + directory))
                {
                    continue;
                }
                Console.WriteLine("Need to creat directory {0}", directory);
                
            }
            Console.WriteLine("To create needed directories and sort files enter \"yes\".");
            var answer = Console.ReadLine().ToLower().Trim();
            if (answer == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void createDirectories(string path)
        {
            var neededDirectories = new List<string>() { "PDF", "EXE", "EXCEL", "DOCUMENTS", "ZIP", "MISC" };
            foreach (var directory in neededDirectories)
            {
                if (Directory.Exists(path + directory))
                {
                    continue;
                }
                Directory.CreateDirectory(path + directory);
                Console.WriteLine("{0} created", directory);
            }
        }
        public static void moveFiles(string[] files, string path)
        {

            foreach(var file in files)
            {
                var extension = Path.GetExtension(file);
                if (extension == ".exe")
                    File.Move(file, path + @"EXE\" + Path.GetFileName(file), true);
                else if (extension == ".pdf")
                    File.Move(file, path + @"PDF\" + Path.GetFileName(file), true);
                else if (extension == ".xlsx" || extension == ".csv" || extension == ".xls")
                    File.Move(file, path + @"EXCEL\" + Path.GetFileName(file), true);
                else if (extension == ".docx" || extension == ".doc")
                    File.Move(file, path + @"DOCUMENTS\" + Path.GetFileName(file), true);
                else if (extension == ".zip")
                    File.Move(file, path + @"ZIP\" + Path.GetFileName(file), true);
                else
                    File.Move(file, path + @"MISC\" + Path.GetFileName(file), true);
            }
            
        }
    }
}
