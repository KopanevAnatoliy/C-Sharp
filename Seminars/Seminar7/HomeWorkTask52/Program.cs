// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом 
// столбце.
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным 
// цветом.

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

// Возращает цвет для консоли.
ConsoleColor GetColor(int colorNumb)
{
    colorNumb = Math.Abs(colorNumb % 16);
    return ((ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor)))[colorNumb];
}

// Сумма диагоналей.
double[] DiagonalMean(int[,] arr)
{
    double[] mean = new double[arr.GetLength(0) + arr.GetLength(1) - 1];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            mean[arr.GetLength(0) + j - i - 1] += arr[i, j];
        }
    }
    int minLen = Math.Min(arr.GetLength(0), arr.GetLength(1));
    for (int i = 0; i < mean.Length; i++)
    {
        mean[i] = Math.Round(mean[i] / Math.Min(Math.Min(i + 1, mean.Length - i), minLen), 1);
    }
    return mean;
}

// Печать массива со среднем значением диагоналей.
void PrintDiagonalMean(int[,] arr, double[] mean)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = GetColor(16 + i - j);
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine($"--{mean[mean.Length - i -1]}");

    }
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.ForegroundColor = GetColor(16 + arr.GetLength(0) - 1 - j);
        Console.Write($"|\t");
    }
    Console.WriteLine();
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.ForegroundColor = GetColor(16 + arr.GetLength(0) - 1 - j);
        Console.Write($"{mean[j]}\t");
    }

    Console.ForegroundColor = ConsoleColor.White;
}


int[,] arr = Gen2DArr(10, 10, 0, 10000);
double[] mean = DiagonalMean(arr);
PrintDiagonalMean(arr, mean);
