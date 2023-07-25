//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.Write("Enter three-diginit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number > 99)
{
    int a = number % 100;
    int solution = a / 10;
    Console.WriteLine($"Вторая цифра введённого числа: {solution}");
}
else
{
    Console.WriteLine($"Число не трёхзначное");
}