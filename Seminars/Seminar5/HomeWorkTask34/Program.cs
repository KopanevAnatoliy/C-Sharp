//№34 Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1
// * Отсортировать массив методом пузырька


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

// Сортировка пузырьком.
int[] BubbleSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - i; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp;
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
    return arr;
}


// Счетчик четных чисел.
int EvenCount(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item % 2 == 0)
            count++;
    }
    return count;
}


int[] arr = GenArr(10, 100, 1000);
PrintArr(arr);
int[] sortArr = BubbleSort(arr);
PrintArr(sortArr, "Сортированный массив: ");
Console.WriteLine($"Количество четных элементов: {EvenCount(arr)}");
