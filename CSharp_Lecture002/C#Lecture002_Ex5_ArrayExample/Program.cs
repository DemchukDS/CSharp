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

int[] randomArray = new int[10];

FillArray(randomArray);
PrintArray(randomArray);