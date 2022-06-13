//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("напишите число ");
string param1 = Console.ReadLine();
int num1 = int.Parse(param1);
if (num1 % 2 == 0)
{
    System.Console.WriteLine($"число {num1} является четным");
}
else 
{
    System.Console.WriteLine($"число {num1} является не четным");
}