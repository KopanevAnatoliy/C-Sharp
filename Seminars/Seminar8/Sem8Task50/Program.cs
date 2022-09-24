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

Dictionary<int, int> FreqDict(Dictionary<int, int> countValues, int[,] arr)
{
    foreach (int item in arr)
    {
        if (countValues.ContainsKey(item))
        {
            countValues[item]++;
        }
        else
        {
            countValues.Add(item, 1);
        }
    }
    return countValues;
}

// Печать словаря.
void PrintDict(Dictionary<int, int> countValues)
{
    foreach (var item in countValues)
    {
        Console.WriteLine(item);
    }
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


int[,] arr = Gen2DArr(10, 10, 0, 10);
Dictionary<int, int> countValues = new Dictionary<int, int>();
Print2DArray(arr);
FreqDict(countValues, arr);
PrintDict(countValues);