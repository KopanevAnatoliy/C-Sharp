//-----------------------------------------------------------------------------------------------------------
//                                      Задача 12
//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит остаток от деления.
//-----------------------------------------------------------------------------------------------------------

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null)
{
    int numberA = int.Parse(inputLineA);
    int numberB = int.Parse(inputLineB);
    if (numberB % numberA == 0)
    {
        Console.WriteLine("Число B кратно A");

    }
    else
    {
        Console.WriteLine(numberB % numberA);
    }
}