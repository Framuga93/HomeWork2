//Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

void PrintArray(double[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{col[position]} ");
    }
}

double[] FindSum(int[,] array)
{
    double[] averageSumArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++) 
        {
            sum += array[i, j];
        }
        averageSumArray[j] = sum / averageSumArray.GetLength(0);
    }
    return averageSumArray;
}



int row = 4;
int column = 4;
int min = 1;
int max = 4;
int[,] array = GenerateArray(row, column, min, max);
PrintMatrix(array);
System.Console.WriteLine();
double[] ar = FindSum(array);
PrintArray(ar);





// int arraySum = new int[array.GetLength(0)];
//             for(int k = 0; k < arraySum.Length; k++)
//             {
//                 arraySum[k] = array[] 
//             }