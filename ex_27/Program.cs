// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

Console.Write("Input any integer number: ");
int number = int.Parse(Console.ReadLine()!);

int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

Console.WriteLine(SumOfDigits(number));
