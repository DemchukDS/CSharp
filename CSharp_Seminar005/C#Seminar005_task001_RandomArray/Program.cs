// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9 , 9]. Найти сумму отрицательных и положительных элементов массива.

Console.Clear();

Console.Write("Enter the number of elements in the array: ");
int numberOfArrElements = Convert.ToInt32(Console.ReadLine());

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
void SumDigit(int[] array)
{
    int sumPositiveDigit = 0;
    int sumNegativeDigit = 0;
    for(int i = 0;i < array.Length;i++)
    {
        if (array[i] > 0)
        {
            sumPositiveDigit += array[i];
        }
        else if (array[i] < 0)
        {
            sumNegativeDigit += array[i];
        }
    }
    Console.WriteLine("");
    Console.WriteLine($"The sum all negative numbers in the array is - {sumNegativeDigit}!");
    Console.WriteLine($"The sum all positive numbers in the array is - {sumPositiveDigit}!");
}

int[] testArray = GenerateArray(numberOfArrElements);
Console.WriteLine("System to be generate the random array: ");
PrintArray(testArray);
SumDigit(testArray);

Console.ReadKey();