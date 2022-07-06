
// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.



int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int min = -10;
int max = 10;
int[,] array = GenerateArray(4, 4, min, max);
PrintArray(array);
int row = Prompt("введите номер строки >");
int column = Prompt("введите номер столбца >");
if (row > array.GetLength(0) || column > array.GetLength(1))
{
    System.Console.WriteLine("такого элемента нет");
}
else
{
    System.Console.WriteLine($"ваш элемент {array[row - 1, column - 1]}");
}