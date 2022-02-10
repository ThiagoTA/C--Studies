using System;
using System.IO;
using System.Globalization;

Console.Write("Enter file full path: ");
string sourceFilePath = Console.ReadLine();

try
{
    string[] lines = File.ReadAllLines(sourceFilePath);

    string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
    string targetfolderPath = sourceFilePath + @"\out";
    string targetFilePath = targetfolderPath + @"summary.csv";

    Directory.CreateDirectory(targetFilePath);

    using (StreamWriter sw = File.AppendText(targetFilePath))
    {
        foreach (string line in lines)
        {
            string[] fields = line.Split(',');
            string name = fields[0];
            double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
            int amount = int.Parse(fields[2]);

            
        }
    }
} catch
{

}
