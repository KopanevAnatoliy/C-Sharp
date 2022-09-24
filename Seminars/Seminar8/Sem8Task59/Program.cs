// 

// Генерация случайного 2D массива.
int[,] Gen2DArr(int rows, int columns, int arrMin, int arrMax)
{
    int[,] arr = new int[rows, columns];
    Random rnd = new Random();
    if (arrMin > arrMax)
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }
    int range = arrMax - arrMin;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = rnd.Next(arrMin, arrMax);
        }
    }
    return arr;
}

// Поиск минисальногь.
void FindMin(int[,] arr, ref int x, ref int y)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            if (arr[i, j] <= arr[x, y])
            {
                x = i;
                y = j;
            }
        }
    }
}

//
int[,] CutMinIntersception(int[,] arr, int x, int y)
{
    int n = 0; int m = 0;
    int[,] outArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i != x)
        {
            m = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j != y)
                {
                    outArr[n, m] = arr[i, j];
                    m++;
                }
            }
            n++;
        }
    }
    return outArr;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] arr = Gen2DArr(5, 5, 0, 10);
int x = 0, y = 0;
FindMin(arr, ref x, ref y);
Print2DArray(arr);

Print2DArray(CutMinIntersception(arr, x, y));



