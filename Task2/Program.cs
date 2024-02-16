// Задача 2: Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

void Main()
{
    Console.WriteLine("Введите длину массива: ");
    int[] numbers = ArrayGeneration(100, 1000);
    PrintArray(numbers);
    int result = CountEvenNumbers(numbers);
    Console.WriteLine($"В массиве содержится {result} четных чисел.");
}

int[] ArrayGeneration(int minRange, int maxRange)
{
    if (!Int32.TryParse(Console.ReadLine(), out int size)) return new int[0];
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(minRange, maxRange);
    }
    return array;
}

void PrintArray(int[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Вы создали пустой массив.");
        return;
    }
    Console.WriteLine(string.Join(", ", array));
}

int CountEvenNumbers(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            res++;
        }
    }
    return res;
}

Main();