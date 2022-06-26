// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

void FillArray(int[] collection)        
{
    int length = collection.Length;                     
    for (int index = 0;index < length; index++)              
    {
        collection[index] = new Random().Next(100, 1000);                            
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0;position < count;position++)
    {
        Console.Write($"{col[position]} ");
    }
}

int[] arr = new int[8];

FillArray(arr);
PrintArray(arr);