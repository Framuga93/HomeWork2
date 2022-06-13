//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
string param = Console.ReadLine();
int i = int.Parse(param);
int num = i % 10;
if (i<100)
{
    System.Console.WriteLine($"третьей цифры нет ");
    Environment.Exit(0);
}
System.Console.WriteLine(num);
