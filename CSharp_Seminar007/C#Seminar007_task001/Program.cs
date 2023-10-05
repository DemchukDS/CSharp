while (true)
{
    Console.Clear();
    int numberTask = EnterNumber("Enter the task number: ");
    switch (numberTask)
    {
        case 1: // Двумерный массив размером m*n, заполненный случайными целыми числами.
            int row = EnterNumber($"Enter the number of matrix row: ");
            int column = EnterNumber($"Enter the number of matrix column: ");

            Console.WriteLine("The program generate matrix: ");
            FillArrayRandomNumbers(row, column); // ПОКА НЕ ВЫВОДИТСЯ
            Console.ReadKey();
            return;

        case 2: // Задайте двумерный масив размера m, n. Каждый элемент в массиве задается по формале A = m + n.
            FillArrayUseFormula(EnterNumber($"Enter the number of matrix row: "), EnterNumber($"Enter the number of matrix column: "));
            Console.ReadKey();
            return;

        case 3: // Задать двумерный массив. Найти элементы, у которых оба индекса четные и заменить их на квадраты этих элементов.

            int[,] array = FillArrayRandomNumbers(EnterNumber($"Enter the number of matrix row: "), EnterNumber($"Enter the number of matrix column: "));
            Console.WriteLine("The program generate new array: ");
            OutputTwoDimensionalArray(array);
            SquareElementsOfArray(array);
            Console.WriteLine("The program has updated the array: ");
            OutputTwoDimensionalArray(array);
            Console.ReadKey();
            return;
        default:
            Console.WriteLine("Your entered number of the task doesn't exist!");
            Console.ReadKey();
            break;
    }
}

int EnterNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[,] FillArrayRandomNumbers(int row, int column) // row - ряд, column - столбец
{
    int[,] array = new int[row, column];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void FillArrayUseFormula(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
bool CheckForEven(int number)
{
    return number % 2 == 0;
}
void OutputTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SquareElementsOfArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (CheckForEven(i) && CheckForEven(j))
            {
                array[i, j] = (int)Math.Pow(array[i, j], 2);
            }
        }
    }
}