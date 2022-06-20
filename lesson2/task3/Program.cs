//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
string param = Console.ReadLine();
int i = int.Parse(param);
while (i >=100)
{
if (i<1000)
{
    int num = i % 10;
    System.Console.WriteLine(num);
    Environment.Exit(0);
    
}
else 
{
    i = i/10;
}
}
// вроде исправил, но если воодишь слишком большое число пищет 
// Unhandled exception. System.OverflowException: Value was either too large or too small for an Int32.
// at System.Number.ThrowOverflowOrFormatException(ParsingStatus status, TypeCode type)
// at System.Int32.Parse(String s)
// at Program.<Main>$(String[] args) in /Users/alekseydem
