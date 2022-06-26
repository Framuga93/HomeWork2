int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}
int VozvVStepen(int Osnovanie, int Stepen)
{
    int result = 1;
    for (int i = 0; i < Stepen; i++)
    {
        result=result*Osnovanie;
    }
    return result;
}

int numberA = Prompt("Введмте число A > ");
int numberB = Prompt("Введмте число B > ");
System.Console.WriteLine($"{VozvVStepen(numberA,numberB)}");