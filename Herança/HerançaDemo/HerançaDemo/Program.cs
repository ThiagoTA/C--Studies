﻿using System;
using HerançaDemo.Entities;

namespace HerançaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob", 100.0, 500.0);
            Console.WriteLine(account.Balance);
        }
    }
}
