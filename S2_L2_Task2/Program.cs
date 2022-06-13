//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("напишите три числа ");
string param1 = Console.ReadLine();
int num1 = int.Parse(param1);
string param2 = Console.ReadLine();
int num2 = int.Parse(param2);
string param3 = Console.ReadLine();
int num3 = int.Parse(param3);
int max = 0;

if (num1 == num2 && num2 == num3)
{
    System.Console.WriteLine($"числа равны");
    Environment.Exit(0);
}
if (num1>num2)
{
 max = num1;
 if (num1>num3)
 {
     System.Console.WriteLine($"макс первое {max}" );
 }  
}
else if (num3>num1)                 //хотел запихнуть это внутрь предидущего if (строка 18), но почему то ругался чувствую что можно записать короче
{
    max = num3;
    System.Console.WriteLine($"макс третье {max}");
}
else
 {
    max = num2;
     System.Console.WriteLine($"макс второе {max}");
 }