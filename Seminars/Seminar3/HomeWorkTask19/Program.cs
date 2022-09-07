//=================================================================================
// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет 
// 23432 -> да 
// 12821 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов
//=================================================================================

// Создание словаря.
Dictionary<int, int> CreatDictionary()
{
    Dictionary<int, int> digitDict = new Dictionary<int, int>();
    for (int i = 10; i < 100; i++)
    {
        digitDict.Add(i, i % 10 * 10 + i / 10);
    }
    return digitDict;
}

// Считывание данных.
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "12345");
    //Возвращаем значение
    return number;
}

// Определение результата.
bool calsRes(int number, Dictionary<int, int> digitDict)
{
    return digitDict[number / 1000] == number % 100;
}


// Вывод результата.
void PrintResult(bool res, int number)
{
    Console.WriteLine(res ? "Число " + number + " - Полиндром." : "Число " + number + " - не полиндром.");
}


int number = ReadData("Введите 5-ти значное число");

// Проверка разрядности числа.
if (number < 100000 && number > 9999)
{
    Dictionary<int, int> digitDict = CreatDictionary();
    PrintResult(calsRes(number, digitDict), number);
}