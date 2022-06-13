// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.WriteLine("напишите два числа ");
string param1 = Console.ReadLine();
int num1 = int.Parse(param1);
string param2 = Console.ReadLine();
int num2 = int.Parse(param2);
if (num1 == num2)
{
    System.Console.WriteLine("числа равны");
    Environment.Exit(0);
}
if (num1 > num2)
{
    System.Console.WriteLine("первое число больше");
}
else
{
    System.Console.WriteLine("второе число больше");
}

