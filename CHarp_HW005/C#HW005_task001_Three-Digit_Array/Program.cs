// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

Console.Write("Enter the quantity of elements of array: ");
int quantityOfElements = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Program generate a new array:");

int CalculateNumberOfEvenDigitsInRandomArray(int number)
{
    int numberOfEvenDigitsInRandomArray = 0;
    int[] newRandomArray = new int[number];
    Random rand = new Random();
    for (int i = 0; i < newRandomArray.Length; i++)
    {
        newRandomArray[i] = rand.Next(99, 1000);
        if (newRandomArray[i] % 2 == 0)
        {
            numberOfEvenDigitsInRandomArray++;
        }
        Console.Write($"{newRandomArray[i]} ");
    }
    
    Console.WriteLine($"\n\nThe quantity of even numbers in array is {numberOfEvenDigitsInRandomArray}");
    return numberOfEvenDigitsInRandomArray;
}

CalculateNumberOfEvenDigitsInRandomArray(quantityOfElements);

Console.ReadKey();