﻿using System;

namespace _05.AddAndSubtract
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());
			int thirdNumber = int.Parse(Console.ReadLine());
			int sumofFirst = SumOfFirstTwoElements(firstNumber, secondNumber);
			int result = SubtractOfSumMinusThirdNumber(sumofFirst, thirdNumber);
			Console.WriteLine(result);
		}

		public static int SumOfFirstTwoElements(int firstNumber, int secondNumber)
		{
			int sum = firstNumber + secondNumber;
			return sum;
		}

		public static int SubtractOfSumMinusThirdNumber(int firstNumber, int secondNumber)
		{
			int sum = firstNumber - secondNumber;
			return sum;
		}
	}
}
