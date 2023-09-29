// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с такими сторонами.
// Теорема о неравенстве треугольника: каждая сторона треугольника, меньше суммы двух других сторон.


Console.Clear();

double EnterVariable(string message)
{
    Console.Write(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

void CheckExistenceOfTriangle(double a, double b, double c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("Треугольник с указанными сторонами может существовать!");
    }
    else
    {
        Console.WriteLine("Треугольник с указанными сторонами нереален!");
    }
}

double firstSide = EnterVariable("Введите первую потенциальную длину треугольника: ");
double secondSide = EnterVariable("Введите вторую потенциальную длину треугольника: ");
double thirdSide = EnterVariable("Введите третью потенциальную длину треугольника: ");

CheckExistenceOfTriangle(firstSide, secondSide, thirdSide);

Console.ReadKey();