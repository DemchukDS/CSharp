// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int EnterNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
bool Null(int number)
{
    if (number <= 0)
    {
        Value(EnterNumber("The number N must not equal 0! Try enter a new number: "));
        return true;
    }
    return false;
}
int Value(int number)
{
    int prod = 1;
    for (int i = 1; i < number + 1; i++)
    {
        prod *= i;
    }
    Null(number);
    Console.Write(prod);
    return prod;
}

Value(EnterNumber("Enter the number N: "));
Console.ReadKey();

//След задача - 1.27 видоса.