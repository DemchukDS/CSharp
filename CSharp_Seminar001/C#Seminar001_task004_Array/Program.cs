//-4 -3 -2 -1 0 1 2 3 4

Console.Clear();
Console.WriteLine("Enter number N: ");
double N = Math.Floor(Convert.ToSingle(Console.ReadLine())); // floor округляет в меньшую сторону.
int iN = Convert.ToInt32(N);
int negN = iN * -1;
for (int i = negN; i <= iN; i++) 
{
    Console.Write(i);
    Console.Write(" ");
}
