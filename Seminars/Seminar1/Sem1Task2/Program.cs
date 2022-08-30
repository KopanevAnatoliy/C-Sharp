// определние дня недели по его номеру
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputDayOfWeek = int.Parse(inputLine);

    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "Понедельник";
    dayOfWeek[1] = "Вторник";
    dayOfWeek[2] = "Среда";
    dayOfWeek[3] = "Четрверг";
    dayOfWeek[4] = "Пятниц";
    dayOfWeek[5] = "Суббота";
    dayOfWeek[6] = "Воскресенье";
    if (inputDayOfWeek > 7 || inputDayOfWeek < 1)
    {
        Console.WriteLine("Такого дня недели не существует");
    }
    else
        Console.WriteLine(dayOfWeek[inputDayOfWeek - 1]);
}