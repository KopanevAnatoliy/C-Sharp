
// Печать строки.
void PrintData(string data, string pref = "", string post = "", string end = "\n")
{
    Console.Write($"{pref}{data}{post}{end}");
}

// Метод считывания данных пользователя
string ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Возвращаем значение
    return Console.ReadLine() ?? "";
}

string LineGenRec(int numN)
{
    if (numN == 0)
        return "";
    string outLine = numN + " " + LineGenRec(numN - 1);
    return outLine;
}

int RecPow1(int a, int b)
{
    if (b == 1)
        return a;
    if (a % 2 == 0)
        return RecPow(a, b / 2) * RecPow(a, b / 2);
    else
        return a * RecPow(a, b - 1);
}

int RecPow(int a, int b)
{
    if (b == 1)
        return a;
    if (a % 2 == 0)
        return RecPow(a, b / 2) * RecPow(a, b / 2);
    else
        return a * RecPow(a, b - 1);
}

// Метод для замера времени.
void TimeTest(Func<int, int, int> Method, int a, int b, string funcName)
{
    DateTime start = DateTime.Now;
    for (int i = 0; i < 1000; i++)
    {
        Method(a, b);
    }
    Console.WriteLine($"Затраченное время метода {funcName}: {(DateTime.Now - start).TotalMilliseconds} ms");
}

int NoRecPow(int num, int pow)
{
    int result = 1;
    for (int i = 0; i < pow; i++)
    {
        result = result * num;
    }
    return result;
}


TimeTest(RecPow, 2, 200000, "RecPow");
TimeTest(RecPow1, 2, 200000, "RecPow1");
TimeTest(NoRecPow, 2, 200000, "NoRecPow");


