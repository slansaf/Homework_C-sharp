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

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = num % 10;
				num/=10;
			}
			int box = 0;
			int N = array.Length;
			for (int i = 0; i < N / 2 ; i++)
			{
				box = array[i];
				array[i] = array[N-1-i];
				array[N-1-i] = box;
			}

			foreach (int element in array)
			{
				Console.Write($"{element} ");
			}
		}
	}
}

