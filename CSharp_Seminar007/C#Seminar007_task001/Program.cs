while (true)
{
    Console.Clear();
    int numberTask = EnterNumber("Enter the number of the task to program output the task! You can press 0 to see the conditions of the task! You can pres 666 so that program stoped! \nPress number: ");
    switch (numberTask)
    {
        case 0: // Оглавление
            Console.WriteLine("Below is a list of tasks: ");
            Console.WriteLine("Task 1. Enter the row and column of the matrix, so that the program fils this matrix with random elements.");
            Console.WriteLine("Task 2. Enter the row = M and column = N of the matrix! All enements of the matrix filling to the formula A = M + N.");
            Console.WriteLine("Task 3. Enter the row and column of the matrix! If both index of the matrix eleements even, this elements is squared.");

            Console.ReadKey();
            break;
        case 1: // Двумерный массив размером m*n, заполненный случайными целыми числами.
            int row = EnterNumber($"Enter the number of matrix row: ");
            int column = EnterNumber($"Enter the number of matrix column: ");

            Console.WriteLine("The program generate matrix: ");
            FillArrayRandomNumbers(row, column); // ПОКА НЕ ВЫВОДИТСЯ
            Console.ReadKey();
            break;
        case 2: // Задайте двумерный масив размера m, n. Каждый элемент в массиве задается по формале A = m + n.
            FillArrayUseFormula(EnterNumber($"Enter the number of matrix row: "), EnterNumber($"Enter the number of matrix column: "));
            Console.ReadKey();
            break;
        case 3: // Задать двумерный массив. Найти элементы, у которых оба индекса четные и заменить их на квадраты этих элементов.

            int[,] array = FillArrayRandomNumbers(EnterNumber($"Enter the number of matrix row: "), EnterNumber($"Enter the number of matrix column: "));
            Console.WriteLine("The program generate new array: ");
            OutputTwoDimensionalArray(array);
            SquareElementsOfArray(array);
            Console.WriteLine("The program has updated the array: ");
            OutputTwoDimensionalArray(array);
            Console.ReadKey();
            break;
        case 4: //Задайте двумерный массив. Найдите сумму элементов находящихся на главной диагонали (с индексами 0.0 , 1.1, 2.2 и т.д.).
            int[,] originalArray = FillArrayRandomNumbers(EnterNumber($"Enter the number of matrix row: "), EnterNumber($"Enter the number of matrix column: "));
            Console.WriteLine("Program generate new array: ");
            OutputTwoDimensionalArray(originalArray);
            SumElementsOfMainDiagonal(originalArray);
            Console.ReadKey();
            break;
        case 666: // Выход из программы
            return;
        default: // Если указываетя несуществующая задача.
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
void SumElementsOfMainDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += array[i, j];
            }
        }
    }
    Console.WriteLine($"The sum of diagonal elements of the matrix is: {sum}!");
}