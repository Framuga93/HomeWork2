// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int x1 = Prompt("Введите Х1 => ");
int y1 = Prompt("Введите У1 => ");
int z1 = Prompt("Введите Z1 => ");
int x2 = Prompt("Введите X2 => ");
int y2 = Prompt("Введите У2 => ");
int z2 = Prompt("Введите Z2 => ");
// int Kv(int a, int b)
// {
//     int res = (b-a)*(b-a);
//     return res;
// }
// double result = Math.Sqrt(Kv(x2,x1)+Kv(y2,y1)+Kv(z2,z1));  
//System.Console.WriteLine(result);
double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2-z1, 2));
System.Console.WriteLine($"Расстояние = {length}");