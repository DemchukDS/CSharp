Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");
int xa = 15, ya = 1,
    xb = 1, yb = 10,
    xc = 30, yc = 10;

//int x = xa, y = xb;
int x=xa, y=ya;

int count = 0;

while (count < 100)
{
    int randomNumber = new Random().Next(0,3);
    if(randomNumber == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }
    
    if(randomNumber == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }
    
    if(randomNumber == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
    Console.WriteLine();
}
