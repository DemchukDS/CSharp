Console.Clear();
Random rand = new Random ();
int number = rand.Next(10, 100); // int number = new Random().Next(10, 100);

int firstNumber = number / 10; // выделяем первую цифру числа
int secondNumber = number % 10; // выделяем 2 цифру числа при помощи деления с остатком
if (firstNumber > secondNumber) 
{
    Console.WriteLine($"The random number is {number}! The first digit {firstNumber} > second digit {secondNumber}.");
}
else if (firstNumber < secondNumber) 
{
    Console.WriteLine($"The random number is {number}! The first digit {firstNumber} < second digit {secondNumber}.");
}
else 
{
    Console.WriteLine($"The random number is {number}! The first digit {firstNumber} = second digit {secondNumber}");
}