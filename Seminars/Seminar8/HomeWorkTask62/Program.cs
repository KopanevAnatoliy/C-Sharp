// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Печать строки.
void PrintData(string data, string pref = "", string post = "", string end = "\n")
{
    Console.Write($"{pref}{data}{post}{end}");
}

// Возращает строку масива.
string[] GetRow(string[,] arr, int iRow)
{
    string[] row = new string[arr.GetLength(1)];
    for (int j = 0; j < row.Length; j++)
    {
        row[j] = arr[iRow, j];
    }
    return row;
}

// Печать 2D массива.
void Print2DArr(string[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        PrintData(string.Join(", ", GetRow(arr, i)), "[", "]");
    }
}

// Генерация спирального массива.
string[,] SpiralArr(int rows, int columns)
{
    int value = 0;
    int maxValue = rows * columns;
    string[,] arr = new string[rows, columns];
    for (int offset = 0; offset < Math.Min(arr.GetLength(0), arr.GetLength(1)); offset++)
    {
        for (int j = 0 + offset; j < arr.GetLength(1) - offset; j++)
        {
            if (maxValue == value) break;
            arr[offset, j] = value.ToString().PadLeft(2, '0');
            value++;
        }
        for (int i = 1 + offset; i < arr.GetLength(0) - offset; i++)
        {
            if (maxValue == value) break;
            arr[i, arr.GetLength(1) - offset - 1] = value.ToString().PadLeft(2, '0');
            value++;
        }
        for (int j = arr.GetLength(1) - offset - 2; j >= offset; j--)
        {
            if (maxValue == value) break;
            arr[arr.GetLength(0) - offset - 1, j] = value.ToString().PadLeft(2, '0');
            value++;
        }
        for (int i = arr.GetLength(0) - offset - 2; i > offset; i--)
        {
            if (maxValue == value) break;
            arr[i, offset] = value.ToString().PadLeft(2, '0');
            value++;
        }
    }
    return arr;
}


Print2DArr(SpiralArr(10, 10));








