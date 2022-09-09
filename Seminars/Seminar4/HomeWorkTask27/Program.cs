//=================================================================================
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
//=================================================================================

// Метод считывания данных пользователя
string ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Возвращаем значение
    return Console.ReadLine() ?? "";
}

// Считает сумму цифр.
int SumOfDigits(string inputNumber)
{   
    int number = int.Parse(inputNumber);
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

// Считает сумму цифр.
int SumOfDigitsV2(string inputNumber)
{
    int sum = 0;
    for (int i = 0; i < inputNumber.Length; i++)
    {
        sum += Convert.ToInt32(inputNumber[i]);
    }
    return sum;
}

// Метод для замера времени.
void TimeTest(Func<string,int> Method, string number, string funcName)
{
    DateTime start = DateTime.Now;
    Method(number);
    Console.WriteLine($"Затраченное время метода {funcName}: {(DateTime.Now - start).TotalMilliseconds} ms");
}

// Печать результата.
void PrintResult(int number)
{
    Console.WriteLine("Сумма чисел равна: " + number);
}

string inputNumber = ReadData("Введите число ");
PrintResult(SumOfDigits(inputNumber));

TimeTest(SumOfDigits,inputNumber,"SumOfDigits");
TimeTest(SumOfDigitsV2,inputNumber,"SumOfDigitsV2");
