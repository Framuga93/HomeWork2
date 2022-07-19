// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{col[position]} ");
        System.Console.WriteLine();
    }
}

int[] SumInRow(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int result = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
        result += array[i, j];
        }
        sum[i] = result;
    }
    return sum;
}


int FindMinSum(int[] array)
{
    int min = array[0];
    int numberRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            numberRow = i;
        }
    }
    return numberRow;
}

int row = 4;
int column = 6;
int min = 1;
int max = 8;
int[,] array = GenerateArray(row, column, min, max);
PrintMatrix(array);
int[] sumRows = SumInRow(array);
PrintArray(sumRows);
System.Console.WriteLine($"наименьшая сумма числе в строке {FindMinSum(sumRows)+1}");
