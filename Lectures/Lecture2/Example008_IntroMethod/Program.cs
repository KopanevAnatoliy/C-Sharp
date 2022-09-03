int a1 = 15;
int b1 = 19;
int c1 = 8;
int a2 = 15;
int b2 = 111;
int c2 = 923;
int a3 = 235;
int b3 = 111;
int c3 = 924;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;

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

int result = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3)
    );

Console.WriteLine(result);