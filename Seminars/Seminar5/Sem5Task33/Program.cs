// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве.

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

// Наличие элемента.
bool CheckItem(int[] arr, int numb)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == numb)
            return true;
    }
    return false;
}
int[] arr = GenArr(10, 5, 10);
PrintArr(arr);
if (CheckItem(arr, 7))
    Console.WriteLine("True");
else
    Console.WriteLine("False");