// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

double[] MassNums(int size, double from, double to) {
    double[] arr = new double[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.NextDouble() * to;
    }
    return arr;
}

void Print(double[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void DiffMaxMin(double[] arr)
{
    double a = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= a)
        {
            a = arr[i];
        }
    }
    Console.WriteLine($"Maximum value: {a}");

    double b = 1000;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= b)
        {
            b = arr[i];
        }
    }
    Console.WriteLine($"Minimum value: {b}");

    double diff = a-b;
    Console.WriteLine($"Difference between max and min is: {diff}");
}

Console.WriteLine("Enter the number of array elements:");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the minimum value of the array elements:");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the maximum value of the array elements:");
int stop = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num, start, stop);
Print(mass);
DiffMaxMin(mass);