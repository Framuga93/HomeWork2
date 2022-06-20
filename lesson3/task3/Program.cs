//Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27. 
//5 -> 1, 8, 27, 64, 125
System.Console.WriteLine("введите число =>");
string param = Console.ReadLine();
int num = int.Parse(param);
num = Math.Abs(num);
int i = 1;
int x = 0;
if (num > 0)
{
    while (i <= num)
    {
        x = i * i * i;
        System.Console.WriteLine(x);
        i++;
    }
}