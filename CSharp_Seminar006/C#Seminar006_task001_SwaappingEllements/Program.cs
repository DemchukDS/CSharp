// Перевернет одномерный массив (последний эллемент на первый, а первый на последний и т.д.)
// [1, 2, 3, 4, 5] -> [5, 4, 3, 2, 1]

Console.Clear();

Console.Write("Enter the quantity of elements of array: ");
int quantityOfElements = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Program generate a new array:");

int[] GenerateArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}

void SwapElementsOfArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int newElement = array[array.Length - i - 1];
        array[array.Length - i - 1] = array[i];
        array[i] = newElement;
    }
}

int[] newArray = GenerateArray(quantityOfElements);
Console.WriteLine(String.Join(", ", newArray)); //Вывод массива, чтобы не делать лишних циклов.
SwapElementsOfArray(newArray);
Console.WriteLine(String.Join(", ", newArray));
Console.ReadKey();