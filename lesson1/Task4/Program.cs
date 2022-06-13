 //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine("напишите число ");
string param1 = Console.ReadLine();
int num1 = int.Parse(param1);
int num2 = 2;
while (num2<=num1)
{
    System.Console.WriteLine($"{num2}");
    num2 = num2 + 2;
}


