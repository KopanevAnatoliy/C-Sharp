// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых

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

// Печать строки.
void PrintData(string data, string pref = "", string post = "", string end = "\n")
{
    Console.Write($"{pref}{data}{post}{end}");
}

// Точка пересечения.
(double, double) IntersectionPoint(int b1, int k1, int b2, int k2)
{
    double x = ((double)b2 - (double)b1) / ((double)k1 - (double)k2);
    double y = (double)k1 * x + (double)b1;
    return (x, y);
}

// Расстояние между точек.
double LengthSide (double x1, double y1, double x2, double y2)
{
    return Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
}

// Площадь треугольника.
double HeronSquare(double a, double b, double c)
{
    double p = (a + b + c) / 2;
    return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)),2);
}

// Зададим 3 прямых.
int b1 = ReadData("Введите b1: ");
int k1 = ReadData("Введите k1: ");
int b2 = ReadData("Введите b2: ");
int k2 = ReadData("Введите k2: ");
int b3 = ReadData("Введите b3: ");
int k3 = ReadData("Введите k3: ");

// Посчитаем координаты песечения.
(double,double) pointA = IntersectionPoint(b1, k1, b2, k2);
(double,double) pointB = IntersectionPoint(b2, k2, b3, k3);
(double,double) pointC = IntersectionPoint(b3, k3, b1, k1);

// Посчитаем длины сторон.
double side1 = LengthSide(pointA.Item1, pointA.Item2, pointB.Item1, pointB.Item2);
double side2 = LengthSide(pointB.Item1, pointB.Item2, pointC.Item1, pointC.Item2);
double side3 = LengthSide(pointC.Item1, pointC.Item2, pointA.Item1, pointA.Item2);

PrintData(HeronSquare(side1, side2, side3).ToString(), "Площадь треугольника равна: ");


