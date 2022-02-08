using System;
using System.IO;
using System.Collections.Generic;

string path = @"c:\Source";

if (File.Exists(path + @"\source.csv"))
{
    File.Delete(path + @"\source.csv");
}

FileStream sourcetext = File.Create(path + @"\source.csv");
StreamWriter sw = new StreamWriter(sourcetext);

try
{
    try
    {
        Console.Write("Enter the number of products: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
        
                Console.WriteLine($"\nProduct #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Amount: ");
                int amount = int.Parse(Console.ReadLine());

                sw.WriteLine($"{name}, {price}, {amount}");
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine("\nAn error occurred");
        Console.WriteLine(e.Message);
    }

    if (Directory.Exists(path + @"\out"))
    {
        Directory.Delete(path + @"\out");
    }

    DirectoryInfo newOut = Directory.CreateDirectory(path + @"\out");
    FileStream summary = File.Create(newOut + @"\summary.csv");

    StreamReader summaryReader = new StreamReader(summary);

    summaryReader = File.OpenText(path + sourcetext);
    while (!summaryReader.EndOfStream)
    {
        string line = summaryReader.ReadLine();
        Console.WriteLine(line);
    }
    

} catch (IOException e)
{
    Console.WriteLine("\nAn error occurred");
    Console.WriteLine(e.Message);
} finally
{
    if (sw != null) sw.Close();
}



