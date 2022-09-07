//=================================================================================
// №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.1
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом
//=================================================================================

// Считываем данные.
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

// Создание таблица кубов.
string[] CreatTable(int number)
{
    string[] arrRow = { "|", "|" };

    // Создаем строки таблицы.
    for (int currentNumb = 1; currentNumb <= number; currentNumb++)
    {
        // Размер ячеек.
        int cellSize = (int)Math.Log10(Math.Pow(number, 3));
        // Создаем ячейку с числом.
        arrRow[0] += new string(' ', cellSize - (int)Math.Log10(Math.Pow(currentNumb, 1))) + (int)Math.Pow(currentNumb, 1) + "|";
        // Создаем ячейку с кубом.
        arrRow[1] += new string(' ', cellSize - (int)Math.Log10(Math.Pow(currentNumb, 3))) + (int)Math.Pow(currentNumb, 3) + "|";
    }

    return arrRow;
}

// Печать таблицы.
void PrintTableV1(string[] arrRow)
{   
    // Печать разделителя.
    void PrintSep(string sep, int length)
    {
        for (int i = 0; i <= length; i++)
        {
            Console.Write(sep);

        }
        Console.WriteLine();
    }
    
    // Печать строки.
    void PrintRow(string row, int start, int stop)
    {
        for (int i = start; i <= stop; i++)
        {
            Console.Write(row[i]);

        }
        Console.WriteLine();
    }

    int index = 0, lastSep = 0, start = 0, stop = 0;

    while (stop != arrRow[0].Length - 1)
    {
        // Определяем конец строки. 
        while (index < arrRow[0].Length && (Console.WindowWidth >= index - start))
        {
            if (arrRow[0][index] == '|')
                lastSep = index;
            index++;
        }
        stop = lastSep;

        // Выводим строки в виде таблицы.
        int strLength = stop - start;
        PrintSep("=", strLength);
        PrintRow(arrRow[0], start, stop);
        PrintSep("-", strLength);
        PrintRow(arrRow[1], start, stop);
        PrintSep("=", strLength);
        Console.WriteLine();

        // Переопределяем начало строки.
        start = stop;
    }
}

// Печать таблицы.
void PrintTableV2(string[] arrRow)
{   
    // Печать разделителя.
    void PrintSep(string sep, int length)
    {
        for (int i = 0; i <= length; i++)
        {
            Console.Write(sep);

        }
        Console.WriteLine();
    }
    
    // Печать строки.
    void PrintRow(string row, int start, int stop)
    {
        for (int i = start; i <= stop; i++)
        {
            Console.Write(row[i]);

        }
        Console.WriteLine();
    }

    int index = 1, start = 0, stop = 0;

    // Определяем размер строки. 
    if (Console.WindowWidth < arrRow[0].Length)
        while (arrRow[0][Console.WindowWidth - index] != '|')
            index++;
    int printSize = Console.WindowWidth - index;
    int sepLength = Console.WindowWidth - index;

    // Разбиваем таблицу для вывода в терминал.
    for (int i = 0; i <= arrRow[0].Length / printSize; i++)
    {
        start = printSize * i;

        if (arrRow[0].Length > printSize * (i + 1))
            stop = (printSize * (i + 1));
        else
        {
            stop = (arrRow[0].Length - 1);
            sepLength = stop - printSize * i;
        }

        // Выводим строки в виде таблицы.
        PrintSep("=", sepLength);
        PrintRow(arrRow[0], start, stop);
        PrintSep("-", sepLength);
        PrintRow(arrRow[1], start, stop);
        PrintSep("=", sepLength);
        Console.WriteLine();
    }
}

PrintTableV2(CreatTable(ReadData("Введите число")));