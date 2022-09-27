// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите 
// разницу между первым и последним элементом. Для задачи со звездочкой 
// использовать заполнение массива целыми числами.

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

// Делаем квадраты
int[,] Change2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matr[i, j] = (int)Math.Pow(matr[i, j], 2);
            }

        }
    }
    return matr;
}

// Метод для замера времени.
void TimeTest(Func<int[,], int[,]> Method, int[,] arr, string funcName , int count=1)
{
    DateTime start = DateTime.Now;
    for (int i = 0; i < count; i++)
    {
        Method(arr);
    }
    
    Console.WriteLine($"Затраченное время метода {funcName}: {(DateTime.Now - start).TotalMilliseconds} ms");
}  



HashSet<int> set = new HashSet<int>();
for (int i = 10; i < 100; i++)
{
    set.Add(i);
}

int[] arr = new int[100];
arr = set.ToArray();
for (int i = 0; i < 90; i++)
{
    Console.Write($"{set.ElementAt(i)} ");
}

// foreach (var item in set)
// {
//     Console.Write($"{item} ");
// }

// Console.Write($"{set.GetObjectData(1,1)} ");