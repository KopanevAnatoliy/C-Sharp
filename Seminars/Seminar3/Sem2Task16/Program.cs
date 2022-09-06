string inputLineA = Console.ReadLine() ?? "0";
string inputLineB = Console.ReadLine() ?? "1";

if (int.Parse(inputLineA) % int.Parse(inputLineB) == 0)
{
    Console.WriteLine("Число А " + int.Parse(inputLineA) + " квадрат числа B " + int.Parse(inputLineB));
}