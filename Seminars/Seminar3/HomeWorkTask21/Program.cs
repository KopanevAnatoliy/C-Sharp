//=================================================================================
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//=================================================================================

using System.Text.RegularExpressions;

// Получение координат из консоли.
int[] GetCoordinates(string message)
{
    Console.WriteLine(message);
    int[] result = new int[3];
    
    Regex regex = new Regex(@"-?\d+");
    MatchCollection matches = regex.Matches(Console.ReadLine() ?? "0 0 0");

    for (int i = 0; i < 3; i++)
    {
        result[i] = int.Parse(matches[i].ToString());
    }
    return result;
}

// Рассчет расстояния.
double CalcDist(int[] pointA, int[] pointB)
{
    return Math.Sqrt(Math.Pow(pointB[0] - pointA[0], 2) + Math.Pow(pointB[1] - pointA[1], 2) + Math.Pow(pointB[2] - pointA[2], 2));
}

// Вывод в консоль.
void PrintData(double data)
{
    Console.WriteLine(Math.Round(data,2));
}

int[] pointA = GetCoordinates("Введите координаты точки А: ");
int[] pointB = GetCoordinates("Введите координаты точки B: ");

PrintData(CalcDist(pointA ,pointB));
