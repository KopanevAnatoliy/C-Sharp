//

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

// Печать массива.
void PrintArr(int[] arr, string message = "Массив: ")
{
    Console.WriteLine($"{message}[{string.Join(", ", arr)}]");
}

// Инвертирование массива.
int[] ReverseArr(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int tmp = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = tmp;
    }
    return arr;
}

int[] arr = GenArr(10, 5, 11);
PrintArr(arr);
PrintArr(ReverseArr(arr), "Инвертированный массив: ");