// Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(System.Console.ReadLine());
}

int PrintNatural(int n, int m)
{
    int sum = 0;
    if(n != m)
    {
        sum = m+n;
        return sum + PrintNatural(n-1,m+1);
    }

    sum = m+sum;
    return sum;
}

System.Console.WriteLine(PrintNatural(Prompt("write N "), Prompt("write M"))); 