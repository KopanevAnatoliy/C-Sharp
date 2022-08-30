//=====================================================================
// №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из 
// этих чисел.
//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22
//=====================================================================

//Считываем данные пользователия.
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();
//Проверяем переменные на null значения.
if (inputLineA != null && inputLineB != null && inputLineC != null)
{
    //Преобразуем переменные к типу int
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);
    //Сравниваем переменные и выводим результат
    if (inputNumberA > inputNumberB)
    {
        if (inputNumberA > inputNumberC)
        {
            Console.WriteLine("Число A: " + inputNumberA + " наибольшее");
        }
        else
            Console.WriteLine("Число C: " + inputNumberC + " наибольшее");
    }

    else
    {
        if (inputNumberB > inputNumberC)
        {
            Console.WriteLine("Число B: " + inputNumberB + " наибольшее");
        }
        else
            Console.WriteLine("Число C: " + inputNumberC + " наибольшее");
    }
}