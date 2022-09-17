//

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

bool TriangleTest(int a, int b, int c)
{
    return (a + b > c) && (a + c > b) && (b + c > a);
}

int a = ReadData("Введите длину стороны a: ");
int b = ReadData("Введите длину стороны b: ");
int c = ReadData("Введите длину стороны c: ");

PrintResult(TriangleTest(a, b, c) ? "Такой треугольник может быть" : "Такого треугольника не может быть");
