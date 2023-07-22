//Найти максимум из 9 чисел

Console.Clear();
Console.WriteLine("Enter the first number: ");
double firstNumber = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Enter the second number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Enter the third number: ");
double thirdNumber = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Enter the fourth number: ");
double fourthNumber = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Enter the fifth number: ");
double fifthNumber = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Enter the sixth number: ");
double sixthNumber = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Enter the seventh number: ");
double seventhNumber = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Enter the eighth number: ");
double eighthNumber = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Enter the ninth number: ");
double ninthNumber = Convert.ToDouble(Console.ReadLine()); 

double Max (double arg1, double arg2, double arg3)
{
    double result = arg1;
    if (arg2 > result)
    {
        result = arg2;
    }
    if (arg3 > result)
    {
        result = arg3;
    }
    return result;
}

double max1 = Max(firstNumber, secondNumber, thirdNumber);
double max2 = Max(fourthNumber, fifthNumber, sixthNumber);
double max3 = Max(seventhNumber, eighthNumber, ninthNumber);

double max = Max(max1, max2, max3);
/*if (secondNumber > max) {max = secondNumber;}
if (thirdNumber > max) {max = secondNumber;}
if (fourthNumber > max) {max = secondNumber;}
if (fifthNumber > max) {max = secondNumber;}
if (sixthNumber > max) {max = secondNumber;}
if (seventhNumber > max) {max = secondNumber;}
if (eighthNumber > max) {max = secondNumber;}
if (ninhthNumber > max) {max = secondNumber;}*/

Console.WriteLine(max);