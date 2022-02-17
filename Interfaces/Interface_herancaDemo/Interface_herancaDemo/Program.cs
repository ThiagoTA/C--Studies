﻿using Interface_herancaDemo.Model.Entities;
using Interface_herancaDemo.Model.Enums;

IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2};
Console.WriteLine(s1);
Console.WriteLine(s2);