//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter the first number: ");
float first_number = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
float second_number = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Enter the third number: ");
float third_number = Convert.ToSingle(Console.ReadLine());
float max = first_number;
        
while (max < first_number)
{
    max = first_number;
}
while (max < second_number)
{
    max = second_number;
}
while (max < third_number)
{
    max = third_number;
}
Console.WriteLine("Max number: ");
Console.WriteLine(max);