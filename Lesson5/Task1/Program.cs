/*****************************************************
Задача 1: Задайте двумерный массив символов (тип char
[,]). Создать строку из символов этого массива. 
******************************************************/
using System;
namespace project
{
	class Program
	{
		static void Main()
		{
			char [,] matrix = new char[,]{
				{'a', 'b', 'c'},
				{'d', 'e', 'f'}
			};

			string str = GetStringInArray(matrix);
			System.Console.WriteLine($"Строка из символов: \"{str}\"");

		}

		static string GetStringInArray(char[,] array)
		{
			string str = "";
			foreach (char el in array)
			{
				str += el;
			}
			return str;
		}
	}
}