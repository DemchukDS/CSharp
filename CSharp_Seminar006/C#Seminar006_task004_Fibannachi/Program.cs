// Не используя рекурсию вывести первые N чисел Фибоначчи. Первые два всегда числа 0 и 1.

Console.Clear();

Console.Write("Введите количество введенных чисел Фибоначчи, которые необходимо вывести: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
array[0] = 0;
array[1] = 1;

for (int i = 2; i < number; i++)
{
    array[i] = array[i - 2] + array[i - 1];
}

Console.WriteLine(String.Join(", ", array)); //Вывод массива, чтобы не делать лишних циклов.

Console.ReadKey();