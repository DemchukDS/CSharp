// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452-> 11
// 82-> 10
// 9012-> 12

Console.Clear();

char[] EnterAndConvertNumber(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine().ToCharArray();
}
int ConverCharToInt(char digit)
{
    return digit - '0';
}
int SumNumbers(char[] array)
{
    int value = 0;
    for (int i = 0; i < array.Length; i++)
    {
        value += ConverCharToInt(array[i]);
    }
    return value;
}

Console.WriteLine($"The sum of digits of entered number is {SumNumbers(EnterAndConvertNumber("Enter the number: "))}!");

Console.ReadKey();

