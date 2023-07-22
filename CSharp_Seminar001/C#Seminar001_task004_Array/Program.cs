//-4 -3 -2 -1 0 1 2 3 4

Console.Clear();
Console.WriteLine("Enter number N: ");
double N = Convert.ToSingle(Console.ReadLine());
double N2 = N - 0.4999999999999999999999999999999999999999999999999999999999999;
int iN = Convert.ToInt32(N2);
int negN = iN * -1;
for (int i = negN; i <= iN; i++) 
{
    Console.Write(i);
    Console.Write(" ");
}
