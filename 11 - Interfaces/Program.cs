﻿using _11___Interfaces.Entities;
using System.Globalization;

Console.WriteLine("Enter rental data");
Console.WriteLine("Car model: ");
string model = Console.ReadLine();
Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

CarRental carRental = new CarRental(start, finish, new Vehicle(model));
