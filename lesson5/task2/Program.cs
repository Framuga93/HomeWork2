// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{col[position]} ");
    }
}

int[] arr = new int[10];

int SumOddPos(int[] collect)
{
    int sum = 0;
    for (int i = 0; i < 10; i++)
    {
        if (i%2 == 1)
        {
            sum = collect[i] + sum;
        }
    }
    return sum;
}

FillArray(arr);
PrintArray(arr);

System.Console.WriteLine();

System.Console.WriteLine($"сумма элементов стоящих на нечетных позициях ={SumOddPos(arr)}");