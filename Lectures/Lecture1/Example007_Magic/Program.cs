Console.Clear();
int ax = 70 , ay = 1,
    bx = 1, by = 40,
    cx = 140, cy = 40;

Console.SetCursorPosition(ax, ay);
Console.WriteLine("+");

Console.SetCursorPosition(bx, by);
Console.WriteLine("+");

Console.SetCursorPosition(cx, cy);
Console.WriteLine("+");

int x = ax, y = ay;
int count = 0;
while(count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + ax) / 2;
        y = (y + ay) / 2;
        
    }

    if (what == 1)
    {
        x = (x + bx) / 2;
        y = (y + by) / 2;
    }

    if (what == 2)
    {
        x = (x + cx) / 2;
        y = (y + cy) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");

    count++;
}