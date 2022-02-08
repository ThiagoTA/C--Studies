using System;
using System.IO;

string path = @"c:\myfolder";

try
{
    var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("Folders:");
    foreach (string s in folders)
    {
        Console.WriteLine(s);
    }

    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("Files:");
    foreach (string s in files)
    {
        Console.WriteLine(s);
    }

    Directory.CreateDirectory(path + @"\newfolder");
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}