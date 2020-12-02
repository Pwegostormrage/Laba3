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
					Minus(A, B);
					break;
				case "5":
				case "6":
				default:
					Console.WriteLine("Unrecognized command.");
					break;
			}
		}

		static void Minus(double a, double b) => Console.WriteLine(a - b);
	}
}