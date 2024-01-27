/*****************************************************
Задача 3: Задайте произвольную строку. Выясните,
является ли она палиндромом.
******************************************************/
using System;
namespace project
{
	class Program
	{
		static void Main()
		{
			System.Console.Write("Введите строку: ");
			string str = Console.ReadLine()!;
			System.Console.WriteLine(str);
			string strPolin = SearchForPalindromes(str);
			System.Console.WriteLine(strPolin);
		}

		static string SearchForPalindromes(string str){
			string strPoli = "";
			int lenStr = str.Length;
			int count = 0;
			for (int i = 0; i < lenStr / 2; i++){
				if (str[i] == str[lenStr-1-i]){
					count++;
				}
				else {
					count = 0;
				}
			}
			if (count == (lenStr)/2)
				strPoli = "Yas";
			else 
				strPoli = "No";
			
			return strPoli;
		} 
	}
}