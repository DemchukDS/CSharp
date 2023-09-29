// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.Clear();

int EnterVariable(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void ConvertNumberToBynarySystem(int number)
{
    string result = "";
    for (int i = 0; i < number; i++)
    {
        if (number % 2 != 0)
        {
            result = result + 1;
            number = number / 2;
        }
        else
        {
            result = result + 0;
            number = number / 2;
        }
        i--;
    }
    Console.WriteLine(result);
}

int number = EnterVariable("Введите любое число в десятичной системе измерения: ");
Console.Write("Указанное число в бинарной системе исчесления принимает вид: ");
ConvertNumberToBynarySystem(number);

Console.ReadKey ();