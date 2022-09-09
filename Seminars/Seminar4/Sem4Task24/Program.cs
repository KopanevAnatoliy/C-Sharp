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

