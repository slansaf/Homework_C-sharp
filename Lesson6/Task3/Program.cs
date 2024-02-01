/***********************************************************
Задача 3: Задайте произвольный массив. Выведете
его элементы, начиная с конца. Использовать
рекурсию, не использовать циклы.
************************************************************/
using System;
namespace project
{
	class Program
	{
		static void Main()
		{
			System.Console.Write("Ввудите длину массива: ");
			int len = int.Parse(Console.ReadLine()!);
			int[] array = FillArray(len);
			PrintArray(array);
			System.Console.WriteLine();
			PrintDigitsRevers(array, array.Length - 1);
		}

		static void PrintDigitsRevers(int[] array, int len)
		{

			if (len < 0)
			{
				return;
			}
			System.Console.Write($"{array[len]} ");
			len--;
			PrintDigitsRevers(array, len);
		}

		static void PrintArray(int[] array)
		{
			foreach (int el in array)
			{
				System.Console.Write($"{el} ");
			}
		}

		static int[] FillArray(int len)
		{
			Random rnd = new Random();
			int[] array = new int[len];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = rnd.Next(0, 20);
			}
			return array;
		}
	}
}