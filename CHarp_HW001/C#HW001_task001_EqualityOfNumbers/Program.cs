//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter the first number: ");
float first_number = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
float second_number = Convert.ToSingle(Console.ReadLine());
    if (first_number > second_number) {
        Console.Write("The number you entered ");
        Console.Write(first_number);
        Console.Write(" is the largest");
    }
    else {
        Console.Write("The number you entered ");
        Console.Write(second_number);
        Console.Write(" is the largest");
    }
Console.ReadKey();