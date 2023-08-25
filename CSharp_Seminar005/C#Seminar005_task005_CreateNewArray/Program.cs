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
void SumElements(List<int> numbers, List<int> sumArray)
{
    int arraySize = numbers.Count;
    if (arraySize > 1)
    {
        sumArray.Add(numbers[0] + numbers[arraySize - 1]);
        numbers.RemoveAt(0);
        numbers.RemoveAt(numbers.Count - 1);
        SumElements(numbers, sumArray);
    }
    else if (arraySize == 1)
    {
        sumArray.Add(numbers[0]);
    }
}

List<int> sumArray = new List<int>();
int[] testArray = GenerateArray(numberOfArrElements);
List<int> test = new List<int>(testArray); // В круглых скобках конструктор класса лист.
Console.WriteLine("System to be generate the random array: ");
PrintArray(testArray);
Console.WriteLine();
Console.WriteLine("Result array: ");
SumElements(test, sumArray);
PrintArray(sumArray.ToArray());
Console.ReadKey();