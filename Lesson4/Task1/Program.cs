/******************************************************************************
Задача 1: Напишите программу, которая бесконечно запрашивает целые 
числа с консоли. Программа завершается при вводе символа ‘q’ 
или при вводе числа, сумма цифр которого чётная.

*******************************************************************************/
using System;
class Program
{
	static void Main()
	{
		string symbol;
		while (true)
		{
			symbol = EnterSymbol();
			bool isNum = int.TryParse(symbol, out int num);
			if (symbol == "q")
				break;
			else if (CheckSymbolForDivision(num) == 0)
				break;
			else if (CheckSymbolForDivision(num) == 1)
				continue;
			else if (isNum == false)
				Console.WriteLine("Введены неверные данные");

		}
	}

	/* Блок кода для ввода пользователем символа*/
	static string EnterSymbol()
	{
		System.Console.Write("Введите число или \"q\": ");
		string str = Console.ReadLine();
		return str;
	}

	static int CheckSymbolForDivision(int number)
	{
		int summaDigit = 0;
		while (number > 0)
		{
			summaDigit += number % 10;
			number /= 10;
		}
		return summaDigit % 2;
	}

}

