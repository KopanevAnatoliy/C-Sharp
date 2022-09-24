// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

// Возращает Столбец масива.
int[] GetColumn(int[,] arr, int iRow)
{
    int[] row = new int[arr.GetLength(0)];
    for (int j = 0; j < row.Length; j++)
    {
        row[j] = arr[j, iRow];
    }
    return row;
}

// Печать строки.
void PrintData(string data, string pref = "", string post = "", string end = "\n")
{
    Console.Write($"{pref}{data}{post}{end}");
}

// Печать 2D массива.
void Print2DArr(int[,] arr)
{
    if (arr != null)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            PrintData(string.Join(", ", GetRow(arr, i)), "[", "]");
        }
    }
    else PrintData("Произведение матриц невозможно.");
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

// Поэлементное произведение массивов.
int[] Multiplication(int[] arrA, int[] arrB)
{
    int[] result = new int[arrA.Length];
    for (int i = 0; i < arrA.Length; i++)
    {
        result[i] = arrA[i] * arrB[i];
    }
    return result;
}

// Произведение Матриц.
int[,] MatrixMultiplication(int[,] arrA, int[,] arrB)
{
    int[,] result = new int[arrA.GetLength(0), arrB.GetLength(1)];
    if (arrA.GetLength(1) == arrB.GetLength(0))
    {

        for (int i = 0; i < arrA.GetLength(0); i++)
        {
            for (int j = 0; j < arrB.GetLength(1); j++)
            {
                result[i, j] = Sum(Multiplication(GetRow(arrA, i), GetColumn(arrB, j)));
            }
        }
        return result;
    }
    return null;
}



int[,] arrA = Gen2DArr(3, 2, 1, 10);
int[,] arrB = Gen2DArr(2, 3, 1, 10);
PrintData("Матрица А: ");
Print2DArr(arrA);
PrintData("Матрица B: ");
Print2DArr(arrB);
PrintData("Произведение матриц AxB: ");
Print2DArr(MatrixMultiplication(arrA, arrB));








