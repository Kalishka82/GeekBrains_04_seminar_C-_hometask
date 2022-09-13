// Задача 29: Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.

Console.Write("Input numbers through the space: ");
string numbers = Console.ReadLine()!;
string[] elements = numbers.Split(' ');
int size = elements.Length;

int[] arr = CreateArray(size);
PrintArray(arr);  // PrintArray(CreateArray(8));

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = int.Parse(elements[i])!;
    }
    return array;

    // int[] array = Array.ConvertAll(elements, int.Parse);
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    // Console.Write ($"[{string.Join (", ", arr)}]");
    Console.WriteLine("]");
}