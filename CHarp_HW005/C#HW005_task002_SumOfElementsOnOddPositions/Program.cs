//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0

Console.Clear();

Console.Write("Enter the quantity of elements of array: ");
int quantityOfElements = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Program generate a new array:");

int SumElementsOnOddPositions(int number)
{
    int sumOfElements = 0;
    int[] newRandomArray = new int[number];
    Random rand = new Random();
    for (int i = 1; i < newRandomArray.Length; i++)
    {
        newRandomArray[i] = rand.Next(0, 100);
        if (i % 2 != 0)
        {
            sumOfElements += newRandomArray[i];
        }
        Console.Write($"{newRandomArray[i]} ");
    }

    Console.WriteLine($"\n\nThe sum of elements on odd position is {sumOfElements}");
    return sumOfElements;
}

SumElementsOnOddPositions(quantityOfElements);

Console.ReadKey();