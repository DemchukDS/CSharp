Console.Clear();
void FillArray(int[] collection) // метод заполнения массива
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] print)
{
    for (int j = 0; j < print.Length; j++)
    {
        Console.Write(print[j]);
        Console.Write(" ");
    }
}

int IndexOf(int[] collectionIndex, int find)
{
    int position = -1;
    for (int index = 0; index < collectionIndex.Length; index++)
    {
        if (collectionIndex[index] == find)
        {
            position = index;
            break;
        }
    }
    return position;
}

Console.WriteLine("Введите число, позиция которого будет выведена в массиве, но не более 10: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[10];

FillArray(randomArray);
PrintArray(randomArray);
Console.WriteLine();

int pos = IndexOf(randomArray, number);
Console.WriteLine(pos);