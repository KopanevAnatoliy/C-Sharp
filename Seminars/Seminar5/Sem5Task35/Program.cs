// Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].

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
void PrintArr(int[] arr)
{
    Console.WriteLine($"Массив: [{string.Join(", ", arr)}]");
}

// Счетчик
int CountRange(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if ((item >= 10) && (item <= 99))
        {
            count++;
        }
    }
    return count;
}

int[] arr = GenArr(123,0,20);
PrintArr(arr);
Console.WriteLine($"Колличество элементов в массиве {CountRange(arr)}");


