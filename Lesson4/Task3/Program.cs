/******************************************************************************
Задача 3: Напишите программу, которая перевернёт одномерный массив 
(первый элемент станет последним, второй – предпоследним и т.д.)
*******************************************************************************/
using System;
class Program
{
	static void Main()
		{
			System.Console.Write("Введите длину массива: ");
			int len = Convert.ToInt32(Console.ReadLine());
			int[] array = new int[len];
			FillArray(array);
			PrintArray(array);
			ReversArray(array);
			System.Console.WriteLine();
			PrintArray(array);
		}

		static void FillArray(int[] arr){
			Random rnd = new Random();
			for(int i = 0; i < arr.Length; i++){
				arr[i] = rnd.Next(0, 100);
			}
		}

		static void PrintArray(int[] arr){
			foreach(int el in arr){
				System.Console.Write($"{el} ");
			}
		}

		static void ReversArray(int[] array){
			int box = 0;
			int lenArray = array.Length;
			for (int i = 0; i < lenArray/2; i++){
				box = array[i];
				array[i] = array[lenArray - 1 - i];
				array[lenArray - 1 - i] = box;
			}
		}
}