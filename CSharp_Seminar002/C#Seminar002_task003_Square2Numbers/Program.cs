// Напишите программу, которая принимает на ввод два числа и проверяет, является ли одно число квадратом другого.

// 1) ввод с клавиатуры 2 чисел
// 2) возведение первого числа в квадрат.
// 3) сравнение полученного числа со всторым.
// 4) вывод ответа.

Console.Clear();

Console.Write("Enter the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int square = firstNumber * firstNumber;

if (square == secondNumber)
{
    Console.WriteLine($"{firstNumber} entered in the square to {secondNumber}!");
}
else
{
    Console.WriteLine($"{firstNumber} entered in the square is not equal to {secondNumber}!");
}