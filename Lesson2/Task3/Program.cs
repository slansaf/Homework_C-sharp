int number = 98;

if ( number >= 10 && number < 100){
	int firstNumber = number / 10;
	int secondNumber = number % 10;
	if (firstNumber > secondNumber % 10){
		Console.WriteLine($"Наибольшая цифра числа {firstNumber}");
	}
	else {
		Console.WriteLine($"Наибольшая цифра числа {secondNumber}");
	}
}

