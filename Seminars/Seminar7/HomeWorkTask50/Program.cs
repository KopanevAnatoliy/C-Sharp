// // №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

// Считывание данных с консоли.
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Создание словаря с числами фибоначи.
Dictionary<int, long> fiboDict = new Dictionary<int, long>
{
    { 0, 0 },
    { 1, 1 }
};

// Фибоначи рекурсия.
long FibonachiRec(int numb, Dictionary<int, long> fiboDict)
{

    if (fiboDict.ContainsKey(numb))
        return fiboDict[numb];

    else
    {
        long fiboSum = FibonachiRec(numb - 2, fiboDict) + FibonachiRec(numb - 1, fiboDict);
        fiboDict.Add(numb, fiboSum);
        return fiboSum;
    }
}

// Заполняет 2D массив числами фибоначи.
long[,] Fill2DArr(int rows, int columns)
{
    long[,] arr = new long[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = FibonachiRec(rows * i + j, fiboDict);
        }
    }
    return arr;
}

// Печать 2D массива с выделенным элементом.
void ShowItemInArr(long[,] arr, int row, int column)
{
    if (IsInArr(row, column, arr))
    {   
        // Вывод до выделенного элемента.
        int i, j;
        for (i = 0; i < row; i++)
        {
            for (j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]}\t");
            }
            Console.WriteLine();
        }
        for (j = 0; j < column; j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        
        // Вывод выделенного элемента.
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{arr[i, j]}\t");
        Console.ForegroundColor = ConsoleColor.White;

        // Вывод после выделенного элемента.
        for (j = column + 1; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();

        for (i = row+1; i < arr.GetLength(0); i++)
        {
            for (j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
    else
    PrintData("Элемента с заданными коородинатамы нет в матрице");
}

// Печать строки.
void PrintData(string data, string pref = "", string post = "", string end = "\n")
{
    Console.Write($"{pref}{data}{post}{end}");
}

// Наличие координат в массиве.
bool IsInArr(int row, int column, long[,] arr)
{
    return (row < arr.GetLength(0) && column < arr.GetLength(1));
}


long[,] arr = Fill2DArr(5, 5);

int row = ReadData("Введите строку: ");
int column = ReadData("Введите столбец: ");
ShowItemInArr(arr, row, column);