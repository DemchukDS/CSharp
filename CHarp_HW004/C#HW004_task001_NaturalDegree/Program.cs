// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

Console.Clear();

int EnterNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    if (!ValidateDigit(number))
    {
        number = EnterNumber("Try again: ");
    }
    return number;
}

bool ValidateDigit(int number)
{
    if (number < 0)
    {
        Console.Write("The number can be more than zero. ");
        return false;
    }
    return true;
}

int Volue(int numberA, int numberB)
{
    int volue = numberA;
    for (int i = 1; i < numberB; i++)
    {
        volue = volue * numberA;
    }
    return volue;
}


int numberA = EnterNumber($"Enter the first number: ");
int numberB = EnterNumber($"Enter the second number: ");

Console.WriteLine(Volue(numberA, numberB));

Console.ReadKey();