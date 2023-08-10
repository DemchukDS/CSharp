using System.ComponentModel.DataAnnotations;

//Console.WriteLine($"Enter the number: ");
//string number = Console.ReadLine();

int[] testArr = { 45, 2, 23, 12, 65, 5, 1, 34, 2 };

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void Sort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minNumber = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minNumber])
            {
                minNumber = j;
            }
        }
        int number = array[i];
        array[i] = array[minNumber];
        array[minNumber] = number;
    }
}

Sort(testArr);
PrintArray(testArr);


Console.ReadKey();
