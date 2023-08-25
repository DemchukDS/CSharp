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
void ConvertNegatPositDigits(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    Console.WriteLine();
    Console.WriteLine("The new array after converting: ");
    PrintArray(array);
}

int[] testArray = GenerateArray(numberOfArrElements);
Console.WriteLine("System to be generate the random array: ");
PrintArray(testArray);
ConvertNegatPositDigits(testArray);

Console.ReadKey();