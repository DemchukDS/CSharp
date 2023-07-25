// Напишите программу, которая принимает на ввод два числа и выводить, является ли первое число кратным второму.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.

Console.Clear();

Console.Write("Enter the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (secondNumber == 0)
{
    Console.WriteLine($"Error! You can't divide by {secondNumber}");
}
else if (firstNumber % secondNumber == 0)
{
    Console.WriteLine($"The number {firstNumber} is a multiple of the {secondNumber}");
}
else if (firstNumber % secondNumber != 0)
{
    int remainder = firstNumber % secondNumber;
    Console.WriteLine($"The number {firstNumber} is not a multiple of the {secondNumber}! Remainder is {remainder}");
}
