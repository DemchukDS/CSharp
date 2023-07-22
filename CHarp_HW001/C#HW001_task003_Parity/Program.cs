//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Enter the number: ");
float first_number = Convert.ToSingle(Console.ReadLine());
if (first_number%2==0) // деление на 2 без остатка
    {
        Console.Write(first_number);
        Console.WriteLine(" Even");
    }
else 
    {
        Console.Write(first_number);
        Console.WriteLine(" Not even");
    }