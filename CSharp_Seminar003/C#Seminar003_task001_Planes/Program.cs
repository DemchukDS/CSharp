// Напишите программу, которая принимает на вход координаты точки х и у (х не равно 0 и у не равно 0) и даёт номер четверти поверхности в которой находися эта точка.

Console.Clear();

int[] Promo(string message) //задает данные на массив и потом мониторит введенное число с помощью метода сравнения с нулём
{
    Console.Write(message);
    int[] array = new int[2];
    for (int i = 0; i < array.Length; i++)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (CheckForZero(number))
        {
            Console.WriteLine("To know the plane the point is in, the coordinates cannot be 0. Try again: ");
            i--;
        }
        else
        {
            array[i] = number;
        }
    }
    return array;
}
bool CheckForZero(int number) // Сравнивает с нулём
{
    return number == 0;
}

int GetPlane(int X, int Y) // находим плоскость
{
    switch ((X, Y))
    {
        case ( > 0, > 0):
            return 1;
        case ( < 0, > 0):
            return 2;
        case ( < 0, < 0):
            return 3;
        case ( > 0, < 0):
            return 4;
        default: return 0;
    }
}
/*int GetPlane(int X, int Y)
{
    return ((X, Y)) switch
    {
        ( > 0, > 0) => 1,
        ( < 0, > 0) => 2,
        ( < 0, < 0) => 3,
        ( > 0, < 0) => 4,
        _ => 0
    };
}*/

int[] point = Promo("Enter the X and Y coordinate of the point: ");
int X = point[0];
int Y = point[1];

Console.WriteLine($"Point with coordinate [{X}, {Y}], is in plane {GetPlane(X, Y)}");

Console.ReadKey();