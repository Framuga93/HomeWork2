//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
string param = Console.ReadLine();
int i = int.Parse(param);
int num = i % 100 / 10;
System.Console.WriteLine(num);