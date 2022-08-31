//=====================================================================
// №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из 
// этих чисел.
//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22
//=====================================================================

// Считываем данные пользователия.
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();

// Проверяем переменные на null значения.
if (inputLineA != null && inputLineB != null && inputLineC != null)
{
    // Преобразуем переменные к типу int.
    int numberA = int.Parse(inputLineA);
    int numberB = int.Parse(inputLineB);
    int numberC = int.Parse(inputLineC);

    // Заводим переменную max и с помощью вложенного тернарного оператора ложим в нее максимальное число.
    int max = numberA > numberB ? numberA > numberC ? numberA : numberC : numberB > numberC ? numberB : numberC;

    // Выводим максимальное число.
    Console.WriteLine("Максимальное число: " + max);
}