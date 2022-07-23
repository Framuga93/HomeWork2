// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(System.Console.ReadLine());
}

void PrintNaturalEven(int n, int m)
{
    if (n < m)
    {
        return;
    }

    PrintNaturalEven(n - 1, m);
    if (n % 2 != 1)
    {
        System.Console.Write($"{n};");
    }
}

PrintNaturalEven(Prompt("write N "), Prompt("write M"));