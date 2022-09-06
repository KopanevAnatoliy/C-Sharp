int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Расстояние между двумя точками.
double CalcData(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}

// Соберем данные.
int x1 = ReadData("Введите x1 ");
int y1 = ReadData("Введите y1 ");
int x2 = ReadData("Введите x2 ");
int y2 = ReadData("Введите y2 ");

// Вывдем результат.
PrintResult(Math.Round(CalcData(x1,y1,x2,y2),2).ToString());
