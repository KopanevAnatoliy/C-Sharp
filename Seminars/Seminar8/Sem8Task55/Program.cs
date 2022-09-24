//
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
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}
//  Меняем строки со столбцами
int[,] Change2DArray(int[,] matr)
{
    int[,] matrix = new int[matr.GetLength(1), matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matrix[j, i] = matr[i, j];
        }
    }
    return matrix;
}

//
int[,] TMatrix(int[,] arr)
{   
    int tmp;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i+1; j < arr.GetLength(1); j++)
        {
            tmp = arr[i,j];
            arr[i,j] = arr[j,i];
            arr[j,i] = tmp;
        }
    }
    return arr;
}



int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = new int[m, n];

Fill2DArray(matrix, 1, 9);
Print2DArray(matrix);


Print2DArray(TMatrix(matrix));
