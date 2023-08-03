// Напишите программу, котрая по номеру четверти, показывает диапазон возможных координат точек в этой четверти (х и у).

Console.Clear();

Console.Write("Enter the number of the plane in which you want to see the range of coordinates: ");
int planeNumber = Convert.ToInt32(Console.ReadLine());

void PlaneNumber(int planeNumber)
{
    switch (planeNumber)
    {
        case (1): Console.WriteLine("X > 0, Y > 0"); break;
        case (2): Console.WriteLine("X < 0, Y > 0"); break;
        case (3): Console.WriteLine("X < 0, Y < 0"); break;
        case (4): Console.WriteLine("X > 0, Y < 0"); break;
        default: Console.WriteLine("Specified plane does not exist!"); break;
    }
}

PlaneNumber(planeNumber);

Console.ReadKey();