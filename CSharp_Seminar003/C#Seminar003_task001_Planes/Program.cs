// Напишите программу, которая принимает на вход координаты точки х и у (х не равно 0 и у не равно 0) и даёт номер четверти поверхности в которой находися эта точка.

Console.Clear();

int[] Promo(string message)
{
    Console.Write(message);
    int[] array = new int[2];
    for (int i = 0; i > array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

bool EqualityWithZero(int[] array)
{
    for (int i = 0; i > array.Length; i++)
    {
        if (array[i] != 0)
        {
            return true;
        }
        else
        {
            Console.WriteLine("Variables must not be null!");
            return false;
        }
    }
}


int[] point = Promo("Enter the X and Y coordinate of the point: ");

if (EqualityWithZero(point))
{
    if (point[0] > 0 && point[1] > 0)
    {
        Console.WriteLine("Point with coordinate [" + point[0] + ", " + point[1] + "], is in plane 1");
    }
    else if (point[0] < 0 && point[1] > 0)
    {
        Console.WriteLine("Point with coordinate [" + point[0] + ", " + point[1] + "], is in plane 2");
    }
    else if (point[0] < 0 && point[1] < 0)
    {
        Console.WriteLine("Point with coordinate [" + point[0] + ", " + point[1] + "], is in plane 3");
    }
    else if (point[0] > 0 && point[1] < 0)
    {
        Console.WriteLine("Point with coordinate [" + point[0] + ", " + point[1] + "], is in plane 4");
    }
}

Console.ReadKey();