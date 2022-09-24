// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
        PrintData(string.Join(", ",GetRow(arr,i)),"[","]");
    }
}

// Возращает строку масива.
int[] GetRow(int[,] arr,int iRow)
{   
    int[] row = new int[arr.GetLength(1)];
    for (int j = 0; j < row.Length; j++)
    {
        row[j] = arr[iRow,j];
    }
    return row;
}

// Заменяет строку масива.
int[,] SetRow(int[,] arr,int iRow, int[] row)
{   
    
    for (int j = 0; j < row.Length; j++)
    {
        arr[iRow,j] = row[j];
    }
    return arr;
}

// Сортировка подсчетом.
int[] CountSort(int[] arr)
{
    int max = arr[0], min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        max = arr[i];
        if (arr[i] < min)
        min = arr[i];
    }

    int[] count = new int[max - min + 1];
    int j = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        count[arr[i] - min]++;
    }

    for (int i = max; i >= min; i--)
    {
        while (count[i - min]-- > 0)
        {
            arr[j] = i;
            j++;
        }
    }
    return arr;
}

// Сортировка 2D массива.
int[,] Sort2DArr(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        SetRow(arr,i,CountSort(GetRow(arr,i)));
    }
    return arr;
}

int[,] arr = Gen2DArr(5,5,0,10);
PrintData("Исходный массив: "); 
Print2DArr(arr);
PrintData("Сортированный массив: "); 
Print2DArr(Sort2DArr(arr));

