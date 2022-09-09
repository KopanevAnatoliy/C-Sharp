//=================================================================================
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//=================================================================================

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "");
    // Возвращаем значение
    return number;
}

// Генерация случайного массива.
int[] GenArr(int arrLen, int arrMin, int arrMax)
{   
    int[] arr = new int[arrLen];
    Random rnd = new Random();
    for (int i = 0; i < arrLen; i++)
    {
        arr[i] = rnd.Next(arrMin, arrMax);
    }
    return arr;
}

// Печать массива
void PrintArr(int[] arr)
{
    Console.Write($"Массив: [{string.Join(", ", arr)}]");
}


// Ввод данных.
int arrLen = ReadData("Введите размер массива ");
int arrMin = ReadData("Введите минимальное значение ");
int arrMax = ReadData("Введите максимальное значение ") + 1;

// Создание массива.
int[] arr = GenArr(arrLen, arrMin, arrMax);

// Вывод массива.
PrintArr(arr);