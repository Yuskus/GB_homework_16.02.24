// Задача 3: Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.).

void Main()
{
    Console.WriteLine("Введите длину массива: ");
    int[] numbers = ArrayGeneration(0, 100);
    PrintArray("Мы создали массив: ", numbers);
    int[] reversedNumbers = ReverseArray(numbers);
    PrintArray("Наш перевернутый массив: ", reversedNumbers);
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

int[] ReverseArray(int[] array)
{
    int[] reversedArray = new int[array.Length];
    for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
    {
        reversedArray[i] = array[j];
    }
    return reversedArray;
}

void PrintArray(string text, int[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Вы создали пустой массив.");
        return;
    }
    Console.WriteLine(text + string.Join(", ", array));
}

Main();