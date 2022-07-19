//Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void PrintMatrix(int[,] array)
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

int[,] FindLargeNumber(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int firstInteration = 0;
        int lastInteration = array.GetLength(1) - 1;
        while (firstInteration <= lastInteration)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int m = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = m;
                }
            }
            lastInteration--;
        }
    }
    return array;
}



int row = 4;
int column = 4;
int min = 1;
int max = 8;
int[,] array = GenerateArray(row, column, min, max);
PrintMatrix(array);
System.Console.WriteLine();
PrintMatrix(FindLargeNumber(array));