// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

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

int numb = ReadData("Введите число: ");
string numbBin = Convert.ToString(numb, 2);

Console.Write($"Число {numb} в двоичной системе: {numbBin}");