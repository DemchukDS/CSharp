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
        case 1:

            Console.ReadKey();
            break;
        case 2:

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