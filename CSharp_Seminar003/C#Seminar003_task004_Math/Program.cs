// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.Clear();

int Promo(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double FindLength(int X1, int Y1, int X2, int Y2)
{
    double result = Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2);
    double length = Math.Sqrt(result);
    return length;
}
int firstCoordinateX = Promo("Enter the X coordinate for first point: ");
int firstCoordinateY = Promo("Enter the Y coordinate for first point: ");
int secondCoordinateX = Promo("Enter the X coordinate for second point: ");
int secondCoordinateY = Promo("Enter the Y coordinate for second point: ");

Console.WriteLine($"The distance between points A[{firstCoordinateX},{firstCoordinateY}] and B[{secondCoordinateX},{secondCoordinateY}] is - {FindLength(firstCoordinateX, firstCoordinateY, secondCoordinateX, secondCoordinateY)}");

Console.ReadKey();