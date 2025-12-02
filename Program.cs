using System;
using System.IO;

namespace practicing_file_io
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //  Creating a file
            FileStream stream = File.Create("my_badass_file.txt");

            // Close the stream
            stream.Close();

            //  Appending text to the file
            File.AppendAllText("my_badass_file.txt",
                "I am the programmer, and I say let there be text in this badass file!");

            
            Console.WriteLine("File created and text written successfully!");
        }
    }
}
