// Напишите программу, укоторая принимает на вход число и выдает количество цифр в числе.

using System.Diagnostics.CodeAnalysis;

Console.Clear();

void Null(int number)
{
    if (number == 0)
    {
        Console.WriteLine("In the entered number - 1 digit!");
    }
    else
    {
        int sum = 0;
        while (number > 0)
        {
            number /= 10;
            sum++;
        }
        Console.WriteLine($"In the entered number - {sum} digits!");
    }
}
int Msg(string message)
{
    Console.WriteLine(message);
    int msg = Convert.ToInt32(Console.ReadLine());
    return msg;
}
int NumberOfDigit(int number)
{
    if (number < 0)
    {
        Console.Write("Try again! ");
        NumberOfDigit(Msg("Enter the random number: "));
    }
    else
    {
        Null(number);
    }
    return number;
}

NumberOfDigit(Msg("Enter the random number: "));
Console.ReadKey();