// Задача А. Программа заполняет массив 8 случайными числами. Напишите 
// функцию, которая находит среднее арифметическое чисел в массиве. 
// Среднее арифметическое равно сумме, делёной на количество.

int[] arr = CreateArray(8);
PrintArray(arr); // is using just for visibility of code checking
Console.Write("\n");

int average = FindAverage(arr);
Console.WriteLine($"Arithmetic Average = {average}");

// Random numbers (0, 100) are using just for visibility of code checking 
int[] CreateArray(int size)
{
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);  
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
}

int FindAverage(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
        sum = sum + arr[i];
    
    int aver = sum / arr.Length;
    return aver;
}

// Задача Б. Программа заполняет массив 8 случайными числами. Напишите
//  функцию, которая принимает массив и находит в нём наибольший 
// элемент.

int maximum = FindMax(arr);
Console.WriteLine($"Maximum Element in Array = {maximum}");

int FindMax(int[] arr)
{
    int max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    
    return max;
}

// Задача В. Напишите функцию, которая проверяет, верно ли, что все 
// числа в массиве чётные. Наличие хотя бы одного нечётного числа 
// означает, что ответ — нет.

bool isEvenElements = EvenElements(arr);

string txt = isEvenElements == true? "-> YES" : "-> NO";
Console.WriteLine(txt);

bool EvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)

    {
        if (arr[i] % 2 != 0);
            return false;
    }

    return true;
}


// Задача Г. Программа заполняет массив 8 случайными числами. Напишите 
// функцию, которая проверяет, верно ли, что числа в массиве идут по 
// возрастанию. Если очередное число меньше предыдущего, ответ — нет.

bool isSortedAscending = SortedAscending(arr);

string txt1 = isSortedAscending == true? "-> YES" : "-> NO";
Console.WriteLine(txt1);

bool SortedAscending(int[] arr)
{
    int min = arr[0];

    for (int i =0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        return false;
    }

    return true;
}