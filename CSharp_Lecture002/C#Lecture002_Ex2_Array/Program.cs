Console.Clear();
double Max (double arg1, double arg2, double arg3) // FUNCTION
{
    double result = arg1;
    if (arg2 > result) result = arg2; // сокращение условия if в одну строку
    if (arg3 > result) result = arg3;
    return result;
}
//                  0  1   2  3   4   5   6   7   8
double [] array = {10, 2, 34, 4, 45, 67, 74, 18, 39};

double max = Max(Max(array[0], array[1], array[2]),
                Max(array[3], array[4], array[5]),
                Max(array[6], array[7], array[8]));

Console.WriteLine(max);