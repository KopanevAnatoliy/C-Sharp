// Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.

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

// Инверсия массива.
int[] NegotivPositiv(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}

int[] arr = GenArr(10, 5, -5);
PrintArr(arr);

int[] res = NegotivPositiv(arr);
PrintArr(res);
