Console.Clear();
Random rand = new Random ();
int number = rand.Next(100, 1000); // int number = new Random().Next(10, 100);

int a = number / 100;
int b = number % 10;

Console.WriteLine($"The number is {number}, {a} + {b}");