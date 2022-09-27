// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Печать строки.
void PrintData(string data, string pref = "", string post = "", string end = "\n")
{
    Console.Write($"{pref}{data}{post}{end}");
}

// Метод считывания данных пользователя
uint ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Возвращаем значение
    return uint.Parse(Console.ReadLine() ?? "");
}

// Реверсивная последовательность чисел.
string SequenceReversed(uint num)
{
    if (num == 0) return string.Empty;
    return $"{num} {SequenceReversed(num - 1)}";
}

PrintData(SequenceReversed(ReadData("Введите число: ")));