//Задача 3*: Задача 1: Заполните спирально квадратный массив по возрастанию, с заданным размером: N

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(System.Console.ReadLine());
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

int[,] main(int n, int m)
{
    int[,] array = new int[n, m];
    int iStart = 0, iEnd = 0, jStart = 0, jEnd = 0;
    int i = 0, j = 0;

    for (int temp = 1; temp <= n * m; temp++)
    {
        array[i, j] = temp;
        if (i == iStart && j < m - jEnd - 1)
            ++j;
        else if (j == m - jEnd - 1 && i < n - iEnd - 1)
            ++i;
        else if (i == n - iEnd - 1 && j > jStart)
            --j;
        else
            --i;

        if ((i == iStart + 1) && (j == jStart) && (jStart != m - jEnd - 1))
        {
            ++iStart;
            ++iEnd;
            ++jStart;
            ++jEnd;
        }
    }
    return array;
}

int[,] array = main(Prompt("введите n"),Prompt("введите m"));
PrintMatrix(array);