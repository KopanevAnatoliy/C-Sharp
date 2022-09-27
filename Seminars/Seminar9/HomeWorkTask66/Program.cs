//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Печать строки.
void PrintData(string data, string pref = "", string post = "", string end = "\n")
{
    Console.Write($"{pref}{data}{post}{end}");
}

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Возвращаем значение
    return int.Parse(Console.ReadLine() ?? "");
}

// Сумма чисел в диапозоне [,]
int SumRec(int start, int stop)
{
    if (start > stop)
        return 0;
    return SumRec(start + 1, stop) + start;
}
int start = ReadData("Введите первое число: ");
int stop = ReadData("Введите второе число: ");
PrintData(SumRec(start, stop).ToString(), pref: $"Сумма чисел от {start} до {stop} равна: ");