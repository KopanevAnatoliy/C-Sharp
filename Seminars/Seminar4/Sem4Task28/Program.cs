// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

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

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

long CalcData(int num)
{
    if (num == 1)
        return 1;
    return num * CalcData(num - 1);
}
int num = ReadData("Введите число");
long result = CalcData(num);
Console.WriteLine(result);