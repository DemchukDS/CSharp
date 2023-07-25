// Напишите программу, которая принимает на ввод два числа и выводить, является ли первое число кратным второму.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.

Console.Clear();

Console.Write("Enter the number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int a = 7;
int b = 23;

if (firstNumber % a == 0 && firstNumber % b == 0)
{
    Console.WriteLine($"The number {firstNumber} is a multiple of the 7 and 23!");
}
else
{
    Console.WriteLine($"The number {firstNumber} is not a multiple of the 7 and 23!");
}
