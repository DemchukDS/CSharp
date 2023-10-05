Console.Clear();

int coefficient = 0;
int constant = 1;
int x_coordinate = 0;
int y_coordinate = 1;
int line_1 = 1;
int line_2 = 2;

int EnterIntNumberFromConsole(string message) //Внесение целых чисел из консоли
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[] ImputArray(int arraySize) // Заполнение массива из консоли
{
    int[] array = new int[arraySize];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = EnterIntNumberFromConsole($"Enter the {i + 1} element of array: ");
    }
    return array;
}
int CountPositiveNumbers(int[] array) // Поиск количества значений, которые больше 0 в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
//-----------------------------------------------------------------------------------------------------------------------------
double EnterFractNumberFromConsole(string message) // Внесение дробных чисел из консоли
{
    Console.Write(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}
double[] InputLineData(int numberOfLine) // Создание массива, в котором вводим характеристики уравнения, coefficient = k.., constant = b..
{
    double[] lineData = new double[2];
    lineData[coefficient] = EnterFractNumberFromConsole($"Введите коэфициэнт для {numberOfLine} прямой: ");
    lineData[constant] = EnterFractNumberFromConsole($"Введите константу для {numberOfLine} прямой: ");
    return lineData;
}
double[] FindCoordinate(double[] lineData1, double[] lineData2) //поиск координат точки пересечения двух прямых в плоскости
{
    double[] coord = new double[2];
    coord[x_coordinate] = (lineData1[constant] - lineData2[constant] / lineData2[coefficient] - lineData1[coefficient]);
    coord[y_coordinate] = (lineData1[coefficient] * coord[x_coordinate] + lineData1[constant]);
    return coord;
}
bool ValidateLines(double[] lineData1, double[] lineData2) // проверка на параллельность двух пнямых и на их совпадение(наложение друг на друга)
{
    if (lineData1[coefficient] == lineData2[coefficient])
    {
        if (lineData1[constant] == lineData2[constant])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}

int number = EnterIntNumberFromConsole($"Выберите номер задачи, которую необходимо решить, либо 0, чтобы посмотреть условия задач: ");

switch (number)
{
    case 0: // Оглавление
        Console.WriteLine("Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
        Console.WriteLine("Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;");
        Console.ReadKey();
        break;
    case 1: // Задача 1
        //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
        //0, 7, 8, -2, -2 -> 2
        //1, -7, 567, 89, 223-> 3

        int numberOfArrayElements = EnterIntNumberFromConsole("Ente number of array elements: ");
        int[] newArray = ImputArray(numberOfArrayElements);
        Console.Write("The entered array: ");
        Console.WriteLine(String.Join(", ", newArray));
        Console.WriteLine($"The quantity of positive numbers in the array is - {CountPositiveNumbers(newArray)}");
        Console.ReadKey();
        break;
    case 2: // Задача 2
        //Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
        //значения b1, k1, b2 и k2 задаются пользователем.
        //b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

        double[] lineData1 = InputLineData(line_1);
        double[] lineData2 = InputLineData(line_2);
        if (ValidateLines(lineData1, lineData2))
        {
            double[] coord = FindCoordinate(lineData1, lineData2);
            Console.Write($"Точка пересечения уравнений y={lineData1[coefficient]}*x+{lineData1[constant]} и y={lineData2[coefficient]}*x+{lineData2[constant]} ");
            Console.WriteLine($"имеет координаты ({(int)coord[x_coordinate]}, {(int)coord[y_coordinate]})");
            //double x = coord[x_coordinate];
            //double y = coord[y_coordinate];
        }
        Console.ReadKey();
        break;
    default:
        Console.WriteLine("Указанной Вами задачи не существует!");
        Console.ReadKey();
        break;
}