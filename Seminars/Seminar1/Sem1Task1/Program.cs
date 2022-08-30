// Является ли число A корнем числа B
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    bool outResult = (Math.Sqrt(inputNumberB) == inputNumberA);

    Console.WriteLine(outResult);
}


