//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();

int EnterVariable(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateRandomArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(-20, 20);
    }
    return array;
}

int[] CopyElementsOfArrayInNewArray(int[] array)
{
    int[] newCopyratedArray = new int[array.Length];
    for (int i = 0;i < array.Length;i++)
    {
        newCopyratedArray[i] = array[i];
    }
    return newCopyratedArray;
}



int quantityOfElements = EnterVariable("Enter the quantity of elements in array: ");
Console.WriteLine("The program generated an array: ");
int[] randomArray = CreateRandomArray(quantityOfElements);
Console.WriteLine(String.Join(", ", randomArray));
Console.WriteLine("The array would copyrated. Result is: ");
int[] newRandomArray = CopyElementsOfArrayInNewArray(randomArray);
Console.WriteLine(String.Join(", ",newRandomArray));


Console.ReadKey();