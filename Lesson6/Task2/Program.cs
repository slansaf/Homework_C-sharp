/******************************************************************
Задача 2: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
В материалах урока можно найти изображение с описанием функции.
******************************************************************/
using System;
namespace project
{
	class Program
	{
		static void Main()
		{
			int m = InputnNumbers("m");
			int n = InputnNumbers("n");
			System.Console.WriteLine($"Результат вычисления функции Аккермана: {AkkermanFunction(m, n)}");

		}


		static int AkkermanFunction(int m, int n)
		{
			if (m == 0)
			{
				return n + 1;
			}
			else if (m > 0 && n == 0)
			{
				return AkkermanFunction(m - 1, 1);
			}
			else
			{
				return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
			}
		}

		static int InputnNumbers(string letter)
		{
			int num = 0;
			System.Console.Write($"Введите значения {letter}: ");
			num = Convert.ToInt32(Console.ReadLine());
			return num;
		}
	}
}