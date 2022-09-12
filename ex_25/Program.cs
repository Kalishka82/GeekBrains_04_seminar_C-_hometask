// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

Console.Write("Input numbers A B: ");
string numbers = Console.ReadLine()!;
string[] parts = numbers.Split(' ');
int A = int.Parse(parts[0]);
int B = int.Parse(parts[1]);

int RaisToThePower(int A, int B)
{
    int ApowB = 1;
    for (int i = 1; i <= B; i++)
    {
        ApowB = A * ApowB;
    }
    return ApowB;
}

Console.WriteLine(RaisToThePower(A, B));



