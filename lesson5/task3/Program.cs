double[] FillArray()
{
    // double length = collection.Length;
    double[] collection = new double[10];
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1, 10) + new Random().NextDouble();
    }
    return collection;
}

void PrintArray(double[] col)
{
   
    for (int position = 0; position < col.Length; position++)
    {
        Console.Write($"{col[position]:f2} ");
    }
}


void SearchDiff(double[] collect)
{
    double min = collect[0];
    double max = collect[0];
    double diff = 0;
    for (int i = 0; i<collect.Length; i++)
    {
        if(collect[i] > max)
        {
            max = collect[i];
        }
        if(collect[i]< min)
        {
            min = collect[i];
        }
    }
    diff = max - min;
    System.Console.WriteLine($"разница между максимальным и минимальным ={diff:f2}");
}

double[] arraA = FillArray();

PrintArray(arraA);

SearchDiff(arraA);

