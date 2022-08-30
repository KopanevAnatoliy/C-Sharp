// определние дня недели по его номеру
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputDayOfWeek = int.Parse(inputLine);
    string outDayOfWeek = string.Empty;

    switch (inputDayOfWeek)
    {
        case 1: outDayOfWeek = "Понедельник"; break;
        case 2: outDayOfWeek = "Вторник"; break;
        case 3: outDayOfWeek = "Среда"; break;
        case 4: outDayOfWeek = "Четрверг"; break;
        case 5: outDayOfWeek = "Пятниц"; break;
        case 6: outDayOfWeek = "Суббота"; break;
        case 7: outDayOfWeek = "Воскресенье"; break;
        default: outDayOfWeek = "Такого дня недели не существует"; break;
    }

    Console.WriteLine(outDayOfWeek);
}