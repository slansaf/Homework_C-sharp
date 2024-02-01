/***********************************************************
Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
************************************************************/
using System;
namespace project
{
	class Program
	{
		static void Main()
		{
			int m = InputnNumbers("начальное число");
			int n = InputnNumbers("конечное число");
			SerchDigits(m, n);
		}

		static void SerchDigits(int m, int n)
		{
			
			if (m > n){	
				return;
			}
			System.Console.Write($"{m}, ");
			m++;
			SerchDigits(m, n);
		}

		static int InputnNumbers(string letter)
		{
			int num = 0;
			System.Console.Write($"Введите {letter}: ");
			num = Convert.ToInt32(Console.ReadLine());
			return num;
		}
	}
}