using System;
using System.Net.WebSockets;

namespace project
{

	class Program
	{

		static void Main()
		{

			Random rnd = new Random();
			int num = rnd.Next(1, 100000);

			System.Console.WriteLine(num);

			int kount = 0;
			int digit = num;
			while (digit > 0)
			{
				digit /= 10;
				kount += 1;
			}

			System.Console.WriteLine(kount);

			int[] array = new int[kount];

			for (int i = array.Length-1; i >= 0; i--)
			{
				array[i] = num % 10;
				num/=10;
			}
			
			foreach (int element in array)
			{
				Console.Write($"{element} ");
			}
		}
	}
}

