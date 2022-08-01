// Задача 1: Есть монотонная последовательность, каждое число встречается ровно 
//то количество раз, какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... 
//Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:
// N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5


int Prompt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(System.Console.ReadLine());
}

int CalcNum(int n)
{
    int PrintNum(int k, int m)
    {
        if (k > 0)
        {
            System.Console.Write($"{m}");
            PrintNum(k - 1, m);
        }
        return k;
    }


    if (n <= 0) return 0;

    for (int i = 1; i <= n; i++)
    {
        PrintNum(i, i);
    }
    return n;


}

CalcNum(Prompt("write N"));