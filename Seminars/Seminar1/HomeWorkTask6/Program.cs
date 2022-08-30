﻿//=====================================================================
// №6 Напишите программу, которая на вход принимает число и выдаёт, является ли число 
// чётным (делится ли оно на два без остатка).
//  4 -> да
//  -3 -> нет
//  7 -> нет
//=====================================================================

//Считываем данные пользователия.
string? inputLine = Console.ReadLine();
//Проверяем переменные на null значения.
if (inputLine != null)
{   
    //Преобразуем переменные к типу int
    int inputNumber = int.Parse(inputLine);
    
    //Проверяем четное число или нет и выводим результат.
    if (inputNumber % 2 == 0)
    {
        Console.WriteLine("Да");
    }
    else
        Console.WriteLine("Нет");
}