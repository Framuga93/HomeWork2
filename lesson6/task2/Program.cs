//Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}





double b1 = Prompt("введите значение b1 ");
double k1 = Prompt("введите значение k1 ");
double b2 = Prompt("введите значение b2 ");
double k2 = Prompt("введите значение k2 ");


if (k1==k2 || b1==b2)
{
    System.Console.WriteLine("точки пересечения нет");
}

double x = (b1-b2)/(k1-k2);
double y = k1*x+b1;
System.Console.WriteLine($"координаты точек пересечения {x} , {y}");



