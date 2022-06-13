//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("напишите три числа ");
string param1 = Console.ReadLine();
int num1 = int.Parse(param1);
string param2 = Console.ReadLine();
int num2 = int.Parse(param2);
string param3 = Console.ReadLine();
int num3 = int.Parse(param3);
int max = num1;

if (num1 == num2 && num2 == num3)
{
    System.Console.WriteLine($"числа равны");
    Environment.Exit(0);
}
if (max < num2);
{
    max = num2;
}
if ( max < num3);
{
    max = num3;
}
System.Console.WriteLine($"максимальное число {max}");