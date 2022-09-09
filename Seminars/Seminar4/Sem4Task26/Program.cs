// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе


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

int CalculateDigits(int num)
{
    string numString = num.ToString();
    return numString.Length;
}

int number = ReadData("Введите число: ");
int numberOfDigits = CalculateDigits(number);
PrintResult("Количество цифр в числе: " + numberOfDigits);
