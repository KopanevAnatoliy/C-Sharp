
// Создание словаря.
Dictionary<int, double> fiboDict = new Dictionary<int, double>
{
    { 0, 0 },
    { 1, 1 }
};

// Фибоначи рекурсия.
double FibonachiRec(int numb, Dictionary<int, double> fiboDict)
{
    if (fiboDict.ContainsKey(numb))
        return fiboDict[numb];

    else
    {
        double fiboSum = FibonachiRec(numb - 2, fiboDict) + FibonachiRec(numb - 1, fiboDict);
        fiboDict.Add(numb, fiboSum);
        return fiboSum;
    }
}

// Фибоначи цикл
double FibonachiСycle(int numb)
{
    double fiboPrev = 0;
    double fibo = 1;
    for (int i = 1; i <= numb; i++)
    {
        double tmp = fibo;
        fibo += fiboPrev;
        fiboPrev = tmp;
    }
    return fiboPrev;
}


int fiboNumb = 50;


for (int i = 0; i < fiboNumb; i++)
{
    Console.WriteLine($"{i} --> {FibonachiRec(i, fiboDict)}");
    Console.WriteLine($"{i + 1} --> {FibonachiСycle(i)}");
}
