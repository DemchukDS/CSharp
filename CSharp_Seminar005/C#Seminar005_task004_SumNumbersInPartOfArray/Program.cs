using System.Diagnostics.CodeAnalysis;

Console.Clear();

Console.Write("Enter the number of elements in the array: ");
int numberOfArrElements = Convert.ToInt32(Console.ReadLine());


int[] GenerateArray(int numberOfElements)
{
    int[] array = new int[numberOfElements];
    Random randomNumber = new Random();
    for (int i = 0; i < numberOfElements; i++)
    {
        array[i] = randomNumber.Next(0, 124);
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
void SearchNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        {
            sum++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"The quantity digits on distanse [10, 99] is - {sum}!");
}

int[] testArray = GenerateArray(numberOfArrElements);
Console.WriteLine("System to be generate the random array: ");
PrintArray(testArray);
SearchNumber(testArray);

Console.ReadKey();