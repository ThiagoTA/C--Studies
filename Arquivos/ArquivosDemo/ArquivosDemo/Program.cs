using System;
using System.IO;

namespace ArquivosDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\file1.txt";
            string targetPath = @"C:\temp\file2.txt";
            string[] lines = File.ReadAllLines(sourcePath);

            try
            {
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

                // FileInfo fileInfo = new FileInfo(sourcePath);
                // fileInfo.CopyTo(targetPath);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
