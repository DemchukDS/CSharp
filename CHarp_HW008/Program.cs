while (true)
{
    Console.Clear();
    int numberTask = EnterNumber("Enter the number of the task to program output the task! You can press 0 to see the conditions of the task! You can pres 666 so that program stoped! \nPress number: ");
    switch (numberTask)
    {
        case 0: // Оглавление
            Console.WriteLine("Below is a list of tasks: ");
            Console.WriteLine("Task 1. ");
            Console.WriteLine("Task 2. ");
            Console.WriteLine("Task 3. ");

            Console.ReadKey();
            break;
        case 1: // Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
            int rowTaskOne = EnterNumber($"Enter the number of matrix row: ");
            int columnTaskOne = EnterNumber($"Enter the number of matrix column: ");
            Console.WriteLine("The program generate matrix: ");
            int[,] originalMatrixTaskOne = FillArrayRandomNumbers(rowTaskOne, columnTaskOne);
            OutputTwoDimensionalArray(originalMatrixTaskOne);
            Console.WriteLine("\nAfter replase elements of matrix is: ");
            int[,] newMatrixTaskOne = SortInDescentingOrderRowElementsOfMatrix(originalMatrixTaskOne);
            OutputTwoDimensionalArray(newMatrixTaskOne);
            Console.ReadKey();
            break;
        case 2: // Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
            int rowTaskTwo = EnterNumber($"Enter the number of matrix row: ");
            int columnTaskTwo = EnterNumber($"Enter the number of matrix column: ");
            Console.WriteLine("The program generate matrix: ");
            int[,] originalMatrixTaskTwo = FillArrayRandomNumbers(rowTaskTwo, columnTaskTwo);
            OutputTwoDimensionalArray(originalMatrixTaskTwo);
            Console.Write("\nThe number of the string with minimal sum of elements: ");
            Console.WriteLine(FindStringWithMinSumOfElementsMatrix(originalMatrixTaskTwo, rowTaskTwo));
            Console.ReadKey();
            break;
        case 3: // Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
            int firstRowTaskThree = EnterNumber($"Enter the number of first matrix row: ");
            int firstColumnTaskThree = EnterNumber($"Enter the number of first matrix column: ");
            int secondRowTaskThree = EnterNumber($"Enter the number of second matrix row: ");
            int secondColumnTaskThree = EnterNumber($"Enter the number of second matrix column: ");
            Console.WriteLine("The program generate two matrices: ");
            int[,] firstMatrixTaskThree = FillArrayRandomNumbers(firstRowTaskThree, firstColumnTaskThree);
            int[,] secondlMatrixTaskThree = FillArrayRandomNumbers(secondRowTaskThree, secondColumnTaskThree);
            OutputTwoDimensionalArray(firstMatrixTaskThree);
            Console.WriteLine("\nи \n");
            OutputTwoDimensionalArray(secondlMatrixTaskThree);
            if (firstMatrixTaskThree.GetLength(1) != secondlMatrixTaskThree.GetLength(0))
            {
                Console.WriteLine("\nThe entered matrices cannot be multiplied!");
            }
            else
            {
                int[,] resultMatrixTaskThree = FindProductOfTwoMatrices(firstMatrixTaskThree, secondlMatrixTaskThree);
                OutputTwoDimensionalArray(resultMatrixTaskThree);
            }
            Console.ReadKey();
            break;
        case 4: // Напишите программу, которая заполнит спирально массив 4 на 4.
            int RowTaskFour = 10;
            int ColumnTaskFour = 10;
            Console.WriteLine("The program generate two matrices: ");
            OutputTwoDimensionalArray(FillMatrixInASpiralWayResult(RowTaskFour, ColumnTaskFour));
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
void OutputTwoDimensionalArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] SortInDescentingOrderRowElementsOfMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        bool isChanged = false;
        while (isChanged == false)
        {
            isChanged = true;
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    SwapElements(matrix, i, j);
                    isChanged = false;
                }
            }
        }
    }
    return matrix;
}
void SwapElements(int[,] matrix, int i, int j)
{
    int temp = matrix[i, j];
    matrix[i, j] = matrix[i, j + 1];
    matrix[i, j + 1] = temp;
}
string FindStringWithMinSumOfElementsMatrix(int[,] matrix, int row)
{
    int[] arraySumOfElements = new int[row];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        arraySumOfElements[i] = sum;
    }
    return string.Join(", ", FindIndexMinElementOfArray(arraySumOfElements));
}
string FindIndexMinElementOfArray(int[] array)
{
    int minNumber = array[0];
    string indexOfMinNumber = "";
    for (int i = 1; i < array.Length; i++)
    {
        if (minNumber >= array[i])
        {
            minNumber = array[i];
            indexOfMinNumber += i + "; ";
        }
    }
    return indexOfMinNumber;
}
int[,] FindProductOfTwoMatrices(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] tempProductMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            tempProductMatrix[i, j] = 0;
            for (int k = 0; k < matrixOne.GetLength(1); k++)
            {
                tempProductMatrix[i, j] += matrixOne[i, k] * matrixTwo[k, j];
            }
        }
    }
    Console.WriteLine("\nThe product of two matrices is: ");
    return tempProductMatrix;
}
int[,] FillMatrixInASpiralWayResult (int row, int column)
{
    int number = 01;
    int[,] matrix = new int[row, column];
    int i = 0;
    int j = 0;
    int k = 0;
    FillMatrixInASpiralWay(i, j, k, number, row, column, matrix);
    return matrix;
}
void FillMatrixInASpiralWay(int i, int j, int k, int number, int row, int column, int[,] matrix)
{
    while (i == k && j < (column - k))
    {
        matrix[i, j] = number;
        j++;
        number++;
    }
    i++;
    j--;
    while (j == (column - 1 - k) && i < (row - k))
    {
        matrix[i, j] = number;
        i++;
        number++;
    }
    i--;
    j--;
    while (j > k)
    {
        matrix[i, j] = number;
        j--;
        number++;
    }
    while (j == k && i > k)
    {
        matrix[i, j] = number;
        i--;
        number++;
    }
    j++;
    i++;
    k++;
    if (k < row)
    {
        FillMatrixInASpiralWay(i, j, k, number, row, column, matrix);
    }
}