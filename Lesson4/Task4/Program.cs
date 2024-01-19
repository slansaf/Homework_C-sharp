/******************************************************************************

Заполните массив на N (вводится с консоли, не более 8)
случайных целых чисел от 0 до 9.
Сформируйте целое число, которое будет состоять из цифр из
массива. Старший разряд числа находится на 0-м индексе,
младший – на последнем. 


*******************************************************************************/

using System;

namespace project
{

	class Program
	{

		static void Main()
		{
			System.Console.Write("Введите длину массива: ");
			int len = Convert.ToInt32(Console.ReadLine());
			int[] array = new int[len];
			FillArray(array);
			PrintArray(array);
			System.Console.WriteLine();
			System.Console.WriteLine(CriateNumber(array));
		}

		static void FillArray(int[] arr)
		{
			Random rnd = new Random();
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next(0, 9);
			}
		}

		static void PrintArray(int[] arr)
		{
			foreach (int el in arr)
			{
				System.Console.Write($"{el} ");
			}
		}

		static double CriateNumber(int[] arr)
		{
			int len = arr.Length - 1;
			double sum = 0;
			int i = 0;
			while (len + 1 > 0)
			{
				sum += arr[i] * Math.Pow(10, len);
				len--;
				i++;
			}
			return sum;
		}


	}

}