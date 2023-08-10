// Напишите программу, которая принимает на вход число (А) и выдаёт сумму все хисел от 1 до А.

int  Msg(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void SumOfNumbers(int number)
{
    int sum = 0;
    for (int i = 0; i < number + 1; i++)
    {
        sum = sum + i; // Можно записать sum += i;
    }
    Console.WriteLine(sum);
}

Console.Clear();
SumOfNumbers(Msg("Enter the number: "));


Console.ReadKey();