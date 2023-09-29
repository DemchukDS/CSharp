//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//Диапазон [-10, 10]. Обратите внимание на вещественных чисел
//Для примера возьмём диапазон побольше. [3 7 22 2 78] -> 76


Console.Clear();

Console.Write("Enter the quantity of elements of array: ");
int quantityOfElements = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Program generate a new array:");

double FindDifferenceBetweenMaxAndMinElementsOfArray(int number)
{
    double difference = 0;
    double[] newRandomArray = new double[number];
    Random rand = new Random();
    double maxElement = newRandomArray[0];
    double minElement = newRandomArray[0];
    for (int i = 0; i < newRandomArray.Length; i++)
    {
        newRandomArray[i] = rand.Next(-10, 10);
        for (int j = 0; j < newRandomArray.Length; j++)
        {
            if (newRandomArray[i] > maxElement)
            {
                maxElement = newRandomArray[i];
            }
            else if (newRandomArray[i] < minElement)
            {
                minElement = newRandomArray[i];
            }
        }
        Console.Write($"{newRandomArray[i]} ");
    }
    difference = maxElement - minElement;

    Console.WriteLine($"\n\n The difference between max and min elements of array is {difference}");
    return difference;
}

FindDifferenceBetweenMaxAndMinElementsOfArray(quantityOfElements);

Console.ReadKey();