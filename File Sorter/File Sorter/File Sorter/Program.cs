using System.IO;
namespace File_Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Path to downloads folder goes here
            var path = @"C:\Users\trohweder\Downloads\";

            if (DirectoryCheck.checkDirectories(path))
            {
                DirectoryCheck.createDirectories(path);
            }
            var files = Directory.GetFiles(path);
            DirectoryCheck.moveFiles(files, path);

        }
    }
}
