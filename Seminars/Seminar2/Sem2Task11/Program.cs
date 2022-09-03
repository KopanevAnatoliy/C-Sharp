// выводит случайное трехзначное число

System.Random numberGenerator = new System.Random();
int number = numberGenerator.Next(100,1000);

int firtstNumber = number / 100;
// int secondNumber = (number % 100) / 10;
int thirdNumber = number % 10;

Console.WriteLine(number);
Console.Write(firtstNumber);
// Console.WriteLine(secondNumber);
Console.Write(thirdNumber);