Console.Clear();

Console.Write("Enter the number of elements in the array: ");
int numberOfArrElements = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter the number, whose need search in array: ");
int searchingNumber = Convert.ToInt32(Console.ReadLine());

int[] GenerateArray(int numberOfElements)
{
    int[] array = new int[numberOfElements];
    Random randomNumber = new Random();
    for (int i = 0; i < numberOfElements; i++)
    {
        array[i] = randomNumber.Next(-9, 10);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void SearchNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            Console.WriteLine();
            Console.WriteLine($"The entered number {number} is located on position number {i}!");
            return;
        }
    }
    Console.WriteLine();
    Console.WriteLine("The entered number is apsent in array!");
}

int[] testArray = GenerateArray(numberOfArrElements);
Console.WriteLine("System to be generate the random array: ");
PrintArray(testArray);
SearchNumber(testArray, searchingNumber);

Console.ReadKey();