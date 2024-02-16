// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа 'q' или при вводе числа, сумма цифр которого чётная.

void Main()
{
    Console.WriteLine("Введите целое число: ");
    string output = InputInteger();
    Console.WriteLine(output + "Программа завершена.");
}

string InputInteger()
{
    string input;
    while (true)
    {
        input = Console.ReadLine() ?? " ";
        if (input == "q") return "Вы ввели 'q'. ";
        else if (int.TryParse(input, out int result))
        {
            if (IsDigitsSumAreEven(input, result)) return "Вы ввели число, сумма цифр которого четная. ";
        }
    }
}

bool IsDigitsSumAreEven(string enter, int res)
{
    int sum = 0;
    for (int i = 0; i < enter.Length; i++)
    {
        sum += res % 10;
        res /= 10;
    }
    return sum % 2 == 0;
}

Main();