//

// Генерация случайного двумерного массива.
int[,] Fill2DArr(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = i + j;
        }
    }
    return arr;
}

// Печать 2D массива.
void Print2DArr(int[,] arr, string message = "Массив: ")
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Print2DArr(Fill2DArr(5,10));