// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до
// N.

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

int n = ReadData("Введите число N");
int index = 0;
while(index <= n)
{
    index++;
    Console.WriteLine(index + " * " + index + " = " + index * index);
}