//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

// Печать строки.
void PrintData(string data, string pref = "", string post = "", string end = "\n")
{
    Console.Write($"{pref}{data}{post}{end}");
}

// Печать 2D массива.
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        PrintData(string.Join(", ", GetRow(arr, i)), "[", "]");
    }
}

// Возращает строку масива.
int[] GetRow(int[,] arr, int iRow)
{
    int[] row = new int[arr.GetLength(1)];
    for (int j = 0; j < row.Length; j++)
    {
        row[j] = arr[iRow, j];
    }
    return row;
}

// Сумма элементов 1D массива.
int Sum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}

// Минимальная сумма в строке.
int MinSumInRow(int[,] arr)
{
    int min = Sum(GetRow(arr, 0));
    int iMin = 0;
    int currentSum;
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        currentSum = Sum(GetRow(arr, i));
        if (currentSum < min)
        {
            min = currentSum;
            iMin = i;
        }
    }
    return iMin;
}

int[,] arr = Gen2DArr(5,5,0,10);
Print2DArr(arr);
PrintData(MinSumInRow(arr).ToString(),"Строка с наименьшей суммой элементов: ");



