while (true)
{
    Console.Clear();
    int numberTask = EnterNumber("Enter the number of the task to program output the task! You can press 0 to see the conditions of the task! You can pres 666 so that program stoped! \nPress number: ");
    switch (numberTask)
    {
        case 0: // Оглавление

            Console.ReadKey();
            break;
        case 1: //Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
            double[,] matrixWithRealNumbers = FillArrayWithRandomRealNumbers(EnterNumber($"Enter the number of matrix row: "), EnterNumber($"Enter the number of matrix column: "));
            Console.WriteLine("\nThe program generate a new array: \n");
            OutputTwoDimentionalRealNumberArray(matrixWithRealNumbers);
            Console.ReadKey();
            break;
        case 2: //Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
            int[,] matrixWithNormalNumbers = FillArrayWithRandomNormalNumbers(EnterNumber($"Enter the number of matrix row: "), EnterNumber($"Enter the number of matrix column: "));
            Console.WriteLine("\nThe program generate a new array: \n");
            OutputTwoDimentionalNormalNumberArray(matrixWithNormalNumbers);
            int elementValue = EnterNumber("\nEnter the element value so that programm can check if such an element in the matrix: ");
            FindArrayElementPositionNumber(matrixWithNormalNumbers, elementValue);
            Console.ReadKey();
            break;
        case 3: //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            int row = EnterNumber($"Enter the number of matrix row: ");
            int column = EnterNumber($"Enter the number of matrix column: ");
            int[,] matrixTask3 = FillArrayWithRandomNormalNumbers(row, column);
            Console.WriteLine("\nThe program generate a new array: \n");
            OutputTwoDimentionalNormalNumberArray(matrixTask3);
            CalculateAverageOfArrayColumns(matrixTask3, column);
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
double[,] FillArrayWithRandomRealNumbers(int row,  int column)
{
    double[,] array = new double[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().Next(-9, 10) * new Random().NextDouble(), 2);
        }
    }
    return array;
}
int[,] FillArrayWithRandomNormalNumbers(int row, int column)
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
void OutputTwoDimentionalRealNumberArray(double[,] array)
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
void OutputTwoDimentionalNormalNumberArray(int[,] array)
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
void FindArrayElementPositionNumber(int[,] array, int number)
{
    bool hasNumber = false;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                Console.WriteLine($"Your entered number at the position [{i},{j}] in the matrix!");
                hasNumber = true;
                break;
            }
        }
    }
    if (!hasNumber)
    {
        Console.WriteLine("The entered number is absend!");
    }
}
void CalculateAverageOfArrayColumns(int[,] array, int quantityOfColumns)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double average = 0;
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[j, i];
        }
        average = sum / quantityOfColumns;
        Console.WriteLine($"The average numbers in {i+1} column is {average}!");
    }
}
