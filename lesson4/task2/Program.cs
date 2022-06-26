// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
System.Console.WriteLine("напишите число ");
string param = Console.ReadLine();
int num = int.Parse(param);
int len = param.Length;
int sum = 0;
for (int i = 0; i < len; i++)
{
    int A = num % 10;
    num = num / 10;
    sum = sum + A;
}
System.Console.WriteLine($"сумма цифр в числе {sum}");