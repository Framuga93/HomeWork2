//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь



int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int[] GetNumber(int number)
{
    int[] numberArray = new int[number];
    for (int i = 0; i < number; i++)
    {
        numberArray[i] = Prompt($"введите {i + 1} число ");
    }
    return numberArray;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{col[position]} ");
    }
}

int GetPositiveNumbers(int[] array)
{
    int countPositive = 0;
    foreach (int elemenet in array)
    {
        if (elemenet>0)
        {
            countPositive++;
        }
    }
    return countPositive;
}



int number = Prompt("сколько чисел вы хотите ввести? ");
int[] numberArray = GetNumber(number);
int countPositive = GetPositiveNumbers(numberArray);
System.Console.WriteLine($"вы ввели {countPositive} чисел больше 0");
