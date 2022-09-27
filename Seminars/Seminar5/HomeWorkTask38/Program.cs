// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите 
// разницу между первым и последним элементом. Для задачи со звездочкой 
// использовать заполнение массива целыми числами.


// Генерация случайного массива.
int[] GenArr(int arrLen, int arrMin, int arrMax)
{
    int[] arr = new int[arrLen];
    Random rnd = new Random();

    if (arrMin > arrMax)
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }

    for (int i = 0; i < arrLen; i++)
    {
        arr[i] = rnd.Next(arrMin, arrMax);
    }
    return arr;
}

// Печать массива
void PrintArr(int[] arr, string message = "Массив: ")
{
    Console.WriteLine($"{message}[{string.Join(", ", arr)}]");
}

// Сортировка вставкой.
int[] InsertSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int currentElement = arr[i];
        int j = i;
        while (j > 0 && arr[j - 1] > currentElement)
        {
            int tmp = arr[j];
            arr[j] = arr[j - 1];
            arr[j - 1] = tmp;
            j--;
        }
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

    for (int i = min; i <= max; i++)
    {
        while (count[i - min]-- > 0)
        {
            arr[j] = i;
            j++;
        }
    }
    return arr;
}

// Метод для замера времени.
void TimeTest(Func<int[], int[]> Method, int[] arr, string funcName)
{
    DateTime start = DateTime.Now;
    for (int i = 0; i < 1; i++)
    {
        Method(arr);
    }
    Console.WriteLine($"Затраченное время метода {funcName}: {(DateTime.Now - start).TotalMilliseconds} ms");
}


int[] arr = GenArr(1000, 0, 10000000);
// PrintArr(arr);
// Console.WriteLine($"Минимальный элемент массива: {arr.Min()}\nМаксимальный элемент массива: {arr.Max()}");
// PrintArr(InsertSort((int[])arr.Clone()), "Массив сортированный методом вставки: ");
// PrintArr(CountSort((int[])arr.Clone()), "Массив сортированный методом подсчета: ");
// PrintArr(CountSortWithDict((int[])arr.Clone()), "Массив сортированный методом подсчета: ");
TimeTest(InsertSort, (int[])arr.Clone(), "InsertSort");
TimeTest(CountSort, (int[])arr.Clone(), "CountSort");
