/*****************************************************
Задача 4*(не обязательная): Задайте строку, состоящую
из слов, разделенных пробелами. Сформировать строку,
в которой слова расположены в обратном порядке. В
полученной строке слова должны быть также разделены
пробелами.
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
			
			// char[] array = ArrayWord(str);
			// System.Console.WriteLine($"[{string.Join(", ", array)}]");

			string[] strRevers = WordsRevers(str);
			System.Console.WriteLine($"[{string.Join(", ", strRevers)}]");
			//System.Console.WriteLine(strRevers);
			System.Console.WriteLine(CountSpace(str));

		}

		// static char[] ArrayWord(string str){
		// 	char [] matrix = new char[str.Length];
		// 	for(int i = 0; i < str.Length; i++){
		// 		matrix[i] = str[i]; 
		// 	}
		// 	return matrix;
		// }

		static int CountSpace(string str){
			int count = 0;
			foreach(char el in str){
				if(el == ' '){
					count++;
				}
			}
			return count;
		}

		static string[] WordsRevers(string str){
			string strFirst = "";
			string[] word = new string[CountSpace(str)+1];
			int i = 0;
			foreach(char el in str){
				if( el != ' '){
					strFirst += el;
				}
				else{
					word[i] = strFirst;
					strFirst = "";
					i++;
				}
			}
			return word;
		}
	}
}