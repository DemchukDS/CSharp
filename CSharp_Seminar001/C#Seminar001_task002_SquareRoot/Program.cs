Console.WriteLine("Enter the first number: ");
float first_number = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Enter the first number: ");
float second_number = Convert.ToSingle(Console.ReadLine());
        
if (first_number == second_number * second_number) {
    Console.WriteLine();
    Console.WriteLine("The first number you enter is the square of the second number");
    Console.Write(second_number);
    Console.Write(" * ");
    Console.Write(second_number);
    Console.Write(" = ");
    Console.WriteLine(first_number);
}
else {
    Console.WriteLine("The first number you entered is not the square of the second number");
}