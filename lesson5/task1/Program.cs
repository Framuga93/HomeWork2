void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(100, 1000);
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

int Search(int[] num)
{
    int positive = 0;
    for (int i = 0; i < 3; i++)
    {
        if (num[i] % 2 == 0)
        {
        positive++ ;
        }
    }
    return positive;
}

int[] arr = new int[3];

FillArray(arr);
PrintArray(arr);

System.Console.WriteLine();

System.Console.WriteLine($"количество четных чисел ={Search(arr)}");