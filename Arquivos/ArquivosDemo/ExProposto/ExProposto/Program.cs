using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

string path = @"c:\Source";

if (File.Exists(path + @"\source.csv"))
{
    File.Delete(path + @"\source.csv");
}

FileStream sourcetext = File.Create(path + @"\source.csv");
StreamWriter sw = new StreamWriter(sourcetext);

DirectoryInfo newOut = Directory.CreateDirectory(path + @"\out");

FileStream summary = File.Create(newOut + @"\summary.csv");
StreamWriter summaryWrite = new StreamWriter(summary);

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
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Amount: ");
                int amount = int.Parse(Console.ReadLine());

                sw.WriteLine($"{name}, {price.ToString("F2", CultureInfo.InvariantCulture)}, {amount}");

                double total = price * amount;
                summaryWrite.WriteLine($"{name}, {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine("\nAn error occurred");
        Console.WriteLine(e.Message);
    }

} catch (IOException e)
{
    Console.WriteLine("\nAn error occurred");
    Console.WriteLine(e.Message);
} finally
{
    if (sw != null) sw.Close();
    if (summaryWrite != null) summaryWrite.Close();
}



