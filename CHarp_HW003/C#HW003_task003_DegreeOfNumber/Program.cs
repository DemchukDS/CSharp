// Напишите программу, которая на вход принимает число (N) и выдает таблицу кубов чисел от 1 до N.

Console.Clear();

int EnterMess(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void Degree(int number)
{
    for (int i = 0; i < number; i++)
    {
        double volue = Math.Pow(i, 3);
        Console.Write($"{volue}, ");
    }
    Console.Write($"{Math.Pow(number, 3)}");
}

for (int i = 0; i < 1; i++)
{
    int N = EnterMess("Введите число: ");
    if (N < 1)
    {
        Console.WriteLine("Введенное число должно быть больше 0.");
        i--;
    }
    else
    {
        Degree(N);
    }
}

Console.ReadKey();