/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Clear();

int Text(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Result(int number)
{
    if (number < 99)
    {
        Console.WriteLine("The entered number doesn't have three digit");
    }
    else if (number > 99)
    {
        while (number > 999)
        {
            number /= 10;
        }
        number = number % 10;
        Console.WriteLine("The third number is " + number);
    }
    return number;
}

int volue = Text("Enter the any number: ");
int result = Result(volue);
Console.ReadKey();





/*
while (number > 999)
{
    number = number / 10;
}

if (number > 99)
{
    number = number % 10;
    Console.WriteLine($"Третья цифра введенного числа - {number}");
}
else if (number < 99)
{
    Console.WriteLine($"Третей цифры в введенном числе нет!");
}*/