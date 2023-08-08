// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние ежду ними в 3D пространстве.

Console.Clear();

int Promo(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double FindLength(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double result = Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2);
    double length = Math.Sqrt(result);
    return length;
}
int firstCoordinateX = Promo("Enter the X coordinate for first point: ");
int firstCoordinateY = Promo("Enter the Y coordinate for first point: ");
int firstCoordinateZ = Promo("Enter the Z coordinate for first point: ");
int secondCoordinateX = Promo("Enter the X coordinate for second point: ");
int secondCoordinateY = Promo("Enter the Y coordinate for second point: ");
int secondCoordinateZ = Promo("Enter the Z coordinate for second point: ");
Console.WriteLine($"The distance between points A[{firstCoordinateX},{firstCoordinateY},{firstCoordinateZ}] and B[{secondCoordinateX},{secondCoordinateY},{secondCoordinateZ}] is - {FindLength(firstCoordinateX, firstCoordinateY, firstCoordinateZ, secondCoordinateX, secondCoordinateY, secondCoordinateZ)}");

Console.ReadKey();