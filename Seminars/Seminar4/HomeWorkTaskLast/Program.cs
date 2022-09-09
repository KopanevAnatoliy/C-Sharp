//=================================================================================
// *Дополнительно: Написать программу которая из имен через запятую выберет случайное 
// имя и выведет в терминал
// Игорь, Антон, Сергей -> Антон
//=================================================================================
using System.Text.RegularExpressions;

// Метод считывания данных пользователя
string ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    string number = Console.ReadLine() ?? "";
    // Возвращаем значение
    return number;
}

// Разбиение строки на элементы
string[] GetNames(string names)
{
    Regex regex = new Regex(@"[а-яА-ЯёЁ]+|[a-zA-Z]+");
    MatchCollection matches = regex.Matches(names);
    string[] result = new string[matches.Count];
    for (int i = 0; i < matches.Count; i++)
    {
        result[i] = matches[i].ToString();
    }
    return result;
}

// Выводит случайный элемент массива.
void rndNames(string[] names)
{
    Random rnd = new Random();
    Console.Write( names[rnd.Next(0, names.Length)] );

}

rndNames(GetNames(ReadData("Введите имена: ")));
