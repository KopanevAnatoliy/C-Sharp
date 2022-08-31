//=====================================================================
// №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число 
// большее, а какое меньшее.
//  a = 5; b = 7 -> max = 7
//  a = 2 b = 10 -> max = 10
//  a = -9 b = -3 -> max = -3
//=====================================================================

//Считываем данные пользователия.
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
//Проверяем переменные на null значения.
if (inputLineA != null && inputLineB != null)
{
    //Преобразуем переменные к типу int
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    //Сравниваем переменные и выводим результат
    if (inputNumberA > inputNumberB)
    {
        Console.WriteLine("Число А: " + inputNumberA + " большее");
        Console.WriteLine("Число B: " + inputNumberB + " меньшее");
    }

    else 
    if (inputNumberA < inputNumberB)
    {
        Console.WriteLine("Число A: " + inputNumberA + " меньшее");
        Console.WriteLine("Число B: " + inputNumberB + " большее");
    }

    else
    {
        Console.WriteLine("Число A: " + inputNumberA + " равно числу B: " + inputNumberB);
    }
}