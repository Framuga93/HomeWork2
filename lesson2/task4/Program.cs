//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число");
string param = Console.ReadLine();
int num = int.Parse(param);
if (num > 0 && num < 8)
{
if (num > 0 && num <=5)
{
    System.Console.WriteLine($"{num} это будни");
}

if (num >= 6 && num <=7)
{
    System.Console.WriteLine($"{num} это выходной");
}
}
else 
{
    System.Console.WriteLine("такого дня недели нет");
}