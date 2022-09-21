// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти
// элементы на их квадраты.

// Печать 2D массива.
void Print2DArr(int[,] arr, string message = "Массив: ")
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
}

// Генерация случайного двумерного массива.
int[,] Gen2DArr(int arrLen, int arrDepth, int arrMin, int arrMax)
{
    int[,] arr = new int[arrLen, arrDepth];
    Random rnd = new Random();

    if (arrMin > arrMax)
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }

    for (int i = 0; i < arrLen; i++)
    {
        for (int j = 0; j < arrDepth; j++)
        {
            arr[i, j] = rnd.Next(arrMin, arrMax);
        }
    }
    return arr;
}

//
int[,] EvenToSquere(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i+=2)
    {
        for (int j = 0; j < arr.GetLength(1); j+=2)
        {
            arr[i, j] *= arr[i, j];
        }        
    }
    return arr;
}

int[,] arr = Gen2DArr(10, 10, 0, 20);
Print2DArr(arr);
Console.WriteLine();
Console.WriteLine();
Print2DArr(EvenToSquere(arr));