// ---------------------------------------------------------------------
//                                 Задача 62
// Напишите программу, которая заполнит спирально массив 4 на 4
// ---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] matr)
{
    int index = 1;
    int j = 0;
    int n = matr.GetLength(0);
    for (int i = 1; i <= n; i++)
    {
        for (j = i - 1; j < n - i + 1; j++)
        {
            matr[i - 1, j] = index++;
        }
        for (j = i; j < n - i + 1; j++)
        {
            matr[j, n - i] = index++;
        }
        for (j = n - i - 1; j >= i - 1; j--)
        {
            matr[n - i, j] = index++;
        }
        for (j = n - i - 1; j >= i; j--)
        {
            matr[j, i - 1] = index++;
        }
    }
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = new int[m, n];

Fill2DArray(matrix);
Print2DArray(matrix);