// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] MassNums(int size, int from, int to) {
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to + 1);
    }
    return arr;
}

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void EvenNum (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] % 2 == 0)
        {
            count++;
        } 
    }
    
    Console.WriteLine($"Количество чётных чисел в массиве равно: {count}");
}

Console.WriteLine("Enter the number of array elements:");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the minimum value of the array elements:");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the maximum value of the array elements:");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
EvenNum(mass);