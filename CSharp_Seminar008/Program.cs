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
        case 1: // Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
            int row = EnterNumber($"Enter the number of matrix row: ");
            int column = EnterNumber($"Enter the number of matrix column: ");

            Console.WriteLine("The program generate matrix: ");
            int[,] originalArray = FillArrayRandomNumbers(row, column);
            OutputTwoDimensionalArray(originalArray);
            Console.WriteLine("\nAfter replase first and last rows matrix is: ");
            ReplaseMatrixFirstAndLastRows(originalArray);
            Console.ReadKey();
            break;
        case 2: // Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
            int rowTaskTwo = EnterNumber($"Enter the number of matrix row: ");
            int columnTaskTwo = EnterNumber($"Enter the number of matrix column: ");

            Console.WriteLine("The program generate matrix: ");
            int[,] secondArray = FillArrayRandomNumbers(rowTaskTwo, columnTaskTwo);
            OutputTwoDimensionalArray(secondArray);
            if (rowTaskTwo != columnTaskTwo)
            {
                Console.WriteLine("The rows and columns in the generated matrix cannot swapped!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nAfter replase matrix rows and columns array is: ");
                ReplaseMatrixRowsAndColumns(secondArray);
                Console.ReadKey();

            }
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
void ReplaseMatrixFirstAndLastRows(int[,] array)
{
    int[] tempArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
            {
                tempArray[j] = array[i, j];
                array[i, j] = array[array.GetLength(0) - 1, j];
                array[array.GetLength(0) - 1, j] = tempArray[j];
            }
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void ReplaseMatrixRowsAndColumns(int[,] array)
{
    int[,] tempArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempArray[i, j] = array[j, i];
            //temp = array[i, j];
            //array[i, j] = array[j, i];
            //array[j, i] = temp;
            //Console.Write($"{array[i, j]} ");
            Console.Write($"{tempArray[i, j]} ");
        }
        Console.WriteLine();
    }
}