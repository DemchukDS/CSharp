// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Clear();

int Text(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
bool Weekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}
bool RealDay(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("The number doesn't match the day of the week! Try Again.");
    return false;
}

int dayNumber = Text("Enter the number of the day of the week ");
if (RealDay(dayNumber))
{
    if (Weekend(dayNumber))
    {
        Console.WriteLine("Weekend");
    }
    else
    {
        Console.WriteLine("Work Day");
    }
}
Console.ReadKey();
