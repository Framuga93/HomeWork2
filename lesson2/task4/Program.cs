//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число");
string param = Console.ReadLine();
int num = int.Parse(param);
int num2 = num%7;
if (num2 > 0 && num2 < 6)
{
    System.Console.WriteLine($"{num2} это будни");
}
if (num2 > 5 && num2 < 8)
{
    System.Console.WriteLine($"{num2} это выходной");
}
