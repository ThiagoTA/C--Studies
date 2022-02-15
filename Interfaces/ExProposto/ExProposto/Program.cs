using System;
using System.Globalization;
using ExProposto.Entities;
using ExProposto.Services;

Console.WriteLine("Enter contract data:");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double contract = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int installments = int.Parse(Console.ReadLine());

Contract myContract = new Contract(number, date, contract);

ContractService contractService = new ContractService(new PaypalService());
contractService.ProcessContract(myContract, installments);

Console.WriteLine("Installments:");
foreach (Installment installment in myContract.Installments)
{
    Console.WriteLine(installment);
}