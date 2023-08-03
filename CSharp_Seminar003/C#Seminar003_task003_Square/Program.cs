// Напишите программу, которая на вход принимает число (N) и выдает таблицу квадратов чисел от 1 до N.

Console.Clear();

int Promo(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void Square(int number)
{
    for (int i = 0; i < number; i++)
    {
        int volue = i * i;
        Console.Write($"{volue}, ");
    }
    Console.Write($"{number * number}");
}

int N = Promo("Введите число: ");
Square(N);

Console.ReadKey();