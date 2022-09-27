// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

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

// Функция Аккермана.
ulong AckermanRec(uint m, uint n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AckermanRec(m - 1, 1);
    return AckermanRec(m - 1, (uint)AckermanRec(m, n - 1));
}

uint m = ReadData("Введите число m: ");
uint n = ReadData("Введите число n: ");
PrintData(AckermanRec(m,n).ToString());