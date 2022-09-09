//=================================================================================
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//=================================================================================

// Метод считывания данных пользователя
int GetNumber(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "");
    // Возвращаем значение
    return number;
}

// Получение мат.операции.
string GetOperation(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Возвращаем значение
    return Console.ReadLine() ?? "";
}

// Калькулятор.
double Calcalate(double firstNumber, double secondNumber, string operation)
{
    switch (operation)
    {
        case "+": return firstNumber + secondNumber;
        case "-": return firstNumber - secondNumber;
        case "*": return firstNumber * secondNumber;
        case "/": return firstNumber / secondNumber;
        case "^": return Math.Pow(firstNumber, secondNumber);
        case "%": return firstNumber % secondNumber;
        default: return -1;
    }
}

// Метод, принимает строку, выводит в консоль
void PrintResult(double number)
{
    Console.WriteLine("Результат: " + number);
}

// Считываем данные.
int firstNumber = GetNumber("Введите первое число ");
string operation = GetOperation("Введите математическую операцию ");
int secondNumber = GetNumber("Введите второе число ");

// Вычисление.
double result = Calcalate(firstNumber, secondNumber, operation);

// Вывод Результата.
PrintResult(Math.Round(result, 2));