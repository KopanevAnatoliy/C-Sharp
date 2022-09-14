// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19 
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю


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

// Сумма элементов с нечетным индексом.
int OddIndSum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

// Поиск повторяющихся элементов.
void PrintPairItems(int[] arr)
{
    Dictionary<int, int> pairItems = new Dictionary<int, int>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (!(pairItems.TryAdd(arr[i], 1)))
        {
            pairItems[arr[i]] += 1;
        }
    }
    
    Console.Write("Парные элементы:");
    foreach (var item in pairItems)
    {   
        if (item.Value > 1) 
        Console.Write($" {item.Key}");
    }
}


int[] arr = GenArr(20, 0, 21);
PrintArr(arr);
Console.WriteLine($"Сумма элементов с нечетным индексом: {OddIndSum(arr)}");
PrintPairItems(arr);

