// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл 
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и 
// выдает сколько чисел больше 0 было введено.

using System.Text.RegularExpressions;

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Считывание клавиши.
string ReadRow(int count)
{
    string row = string.Empty;
    for (int i = 0; i < count; i++)
    {
        row += Console.ReadKey(true).KeyChar.ToString();
    }
    return row;
}

// Печать строки.
void PrintData(string data, string pref = "", string post = "", string end = "\n")
{
    Console.Write($"{pref}{data}{post}{end}");
}

// Список положительных чисел.
MatchCollection GetNumbers(string row)
{
    Regex regex = new Regex(@"(?<!-[0-9]*)0*[1-9]+[0-9]*");
    MatchCollection matches = regex.Matches(row);
    return matches;
}

string row = ReadRow(ReadData("Введите число "));
MatchCollection matches = GetNumbers(row);

PrintData(matches.Count.ToString(), "Вы ввели ", " положительных чисел.");
PrintData(row, "Исходная строка: ");
PrintData(string.Join(", ", matches), "Список положительных чисел: [", "]");
