//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Text(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Volue(int number)
{ 
    if (number > 99 && number < 1000)
    {
        number = number / 10 % 10;
        Console.WriteLine("The second number in entered digit is " + number);
    }
    else
    {
        Console.WriteLine("The number isn't three-digit!");
    }
    return number;
}

int number = Text("Enter the three-digit number: ");
int result = Volue(number);
Console.ReadKey();


/*
Console.Clear();
Console.Write("Enter three-diginit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number > 99)
{
    int a = number % 100 / 10;
    //int solution = a / 10;
    Console.WriteLine($"Вторая цифра введённого числа: {a}");
}
else
{
    Console.WriteLine($"Число не трёхзначное");
}*/