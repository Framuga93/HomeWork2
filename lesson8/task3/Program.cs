// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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


int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    System.Console.WriteLine("Матрицы нельзя перемножить");
    Environment.Exit(0);
}
            int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix2.GetLength(0); k++)
                    {
                        result[i,j] += matrix1[i,k] * matrix2[k,j];
                    }
                }
            }
            return result;
}



int row1 = Prompt("Количество строк >");
int column1 = Prompt("Количество столбцов >");
int row2 = Prompt("Количество строк >");
int column2 = Prompt("Количество столбцов >");
int min = 1;
int max = 2;
int[,] matrix1 = GenerateArray(row1, column1, min, max);
int[,] matrix2 = GenerateArray(row2, column2, min, max);
PrintMatrix(matrix1);
System.Console.WriteLine();
PrintMatrix(matrix2);
System.Console.WriteLine();
int[,] resultMatrix = MultiplicationMatrix(matrix1,matrix2);
PrintMatrix(resultMatrix);
