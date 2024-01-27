/****************************************************
Задача 2: Задайте строку, содержащую латинские буквы
в обоих регистрах. Сформируйте строку, в которой все
заглавные буквы заменены на строчные. 
****************************************************/
using System;
namespace project
{
	class Program
	{
		static void Main()
		{
			System.Console.Write("Введите строку с разным регистром: ");
			string str = Console.ReadLine();
			System.Console.WriteLine(str);
			string toLow = TransformUpperToLower(str);
			System.Console.WriteLine(toLow);
		}

		static string TransformUpperToLower(string str){
			string toLow = "";
			foreach(char el in str.ToLower()){
				toLow += el;
			}
			return toLow;
		} 
	}
}