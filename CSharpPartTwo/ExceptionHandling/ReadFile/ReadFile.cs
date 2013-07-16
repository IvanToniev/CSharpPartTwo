using System;
using System.IO;

namespace ReadFile
{
    class ReadFile
    {
        static void Main()
        {
            Console.WriteLine("Enter the path to your file.");
            string myPath=@Console.ReadLine();
            try
            {
                path(myPath);
            }             
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid path!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Your path is too long!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Invalid directory!Directory can't be found.");
            }

            catch (UnauthorizedAccessException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("File not supported!");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occured while opening the file.");
            }
        }

        public static void path(string path)
        {
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);            
        }
    }
}
