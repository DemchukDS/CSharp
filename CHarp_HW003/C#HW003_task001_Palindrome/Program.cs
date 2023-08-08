// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

void ReturnVolue(char[] array)
{
    if (array[0] == array[4] && array[1] == array[3])
    {
        Console.WriteLine($"The entered number is palindrome!");
    }
    else
    {
        Console.WriteLine($"The entered number isn't palidrome!");
    }
}

Console.WriteLine("Enter five-digit number: ");

int Test()
{
    for (int i = 0; i < 1; i++)
    {
        string text = Console.ReadLine();
        char[] number = text.ToCharArray();
        if (number.Length > 5 || number.Length < 5)
        {
            Console.WriteLine("The entered number isn't five-digit! Try again: ");
            i--;
        }
        else
        {
            ReturnVolue(number);
        }
    }
    return Test();
}
Test();
Console.ReadKey();