//=================================================================================
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
//=================================================================================

// Определяет 3-е число или возращает -1.
int ThirdDigitVer1(string inputeLine)
{
    // заводим result и приравниваем к -1
    int result = -1;
    // Проверяем разрядность числа > 2.
    if (inputeLine.Length > 2)
    {
        // Определим третью цифру.
        result = int.Parse(inputeLine[2].ToString());
    }
    return result;
}

// // Определяет 3-е число или возращает -1.
// int ThirdDigitVer2(string inputeLine)
// {
//     // Приводим строку к int.
//     int number = int.Parse(inputeLine);
//     // заводим result и приравниваем к -1
//     int result = -1;
//     // Проверяем разрядность числа > 2.
//     if (number > 99)
//     {
//         // Определим третью цифру.
//         result = number / Convert.ToInt32(Math.Pow(10, inputeLine.Length - 3)) % 10;
//     }
//     return result;
// }

// Считываем строку с консоли.
string? inputeLine = Console.ReadLine();

// Проверяем на null.
if (inputeLine != null)
{
    int thirdDigit = ThirdDigitVer1(inputeLine);

    // Выводим результат в консоль.
    if (thirdDigit != -1)
    {
        Console.WriteLine(thirdDigit);
    }
    else
        Console.WriteLine("третьей цифры нет");
}