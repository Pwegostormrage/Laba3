﻿using System;

namespace Lab4_2
{
	class Program
	{
		private static double A, B;

		static void Main(string[] args)
		{
			while (true)
			{
				PrintMenu();
				DoAction(Console.ReadLine());
			}
		}

		static void PrintMenu() =>
			Console.WriteLine("1: Input A\n2: Input B\n3: +\n4: -\n5: *\n6: /");

		static void DoAction(string input)
		{
			switch (input)
			{
				case "1":
				case "2":
				case "3":
				case "4":
				case "5":
					Multiply(A, B);
					break;
				case "6":
				default:
					Console.WriteLine("Unrecognized command.");
					break;
			}
		}

		static void Multiply(double a, double b) => Console.WriteLine(a * b);
	}
}