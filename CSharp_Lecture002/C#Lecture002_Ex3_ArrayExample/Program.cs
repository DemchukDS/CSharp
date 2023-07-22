Console.Clear();

int[] array = {87, 2, 31, 43, 15};
Console.WriteLine("Enter the number to be copared with the elements of the array: ");
int find = Convert.ToInt32(Console.ReadLine());
for (int index = 0; index < array.Length; index++)
{
    if (array[index] == find) 
    {
        Console.Write("The position number in array enterred symbol is - ");
        Console.WriteLine(index);
        break;
    }
}