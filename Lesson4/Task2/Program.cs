/******************************************************************************

Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

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
			int quant = CountEvenNumbers(array);
			System.Console.WriteLine();
			System.Console.WriteLine($"Количество четных чисел в массиве: {quant}");
		}

		static void FillArray(int[] arr){
			Random rnd = new Random();
			for(int i = 0; i < arr.Length; i++){
				arr[i] = rnd.Next(100, 1000);
			}
		}

		static void PrintArray(int[] arr){
			foreach(int el in arr){
				System.Console.Write($"{el} ");
			}
		}

		static int CountEvenNumbers(int[] arr){
			int quantity = 0;
			foreach(int el in arr){
				if (el % 2 == 0){
					quantity++;
				}
			}
			return quantity;
		}
	
	
	}

}