// Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.

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

int[] Product(int[] arr)
{
    int[] result = new int[arr.Length / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        result[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return result;
}
int[] arr = GenArr(10, 1, 6);
PrintArr(arr);
PrintArr(Product(arr));



