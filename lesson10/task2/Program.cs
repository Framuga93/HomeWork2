// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29


int Prompt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(System.Console.ReadLine());
}


int Akkerman(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Akkerman(m - 1, 1);
    else
      return Akkerman(m - 1, Akkerman(m, n - 1));
}

int c = Akkerman(Prompt("write n"), Prompt("write m"));
System.Console.WriteLine(c);