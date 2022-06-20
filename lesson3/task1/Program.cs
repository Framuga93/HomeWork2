//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// int[] Array(int num, string param)
// {
//     int[] array = new int[param.Length];
//     int index = array.Length - 1;

//     while (num > 0)
//     {
//         array[index] = num % 10;
//         num = num / 10;
//         index--;
//     }
//     return array;
// }
// System.Console.WriteLine("введите число: ");
// string param = Console.ReadLine();
// int number = int.Parse(param);

// int[] array = Array(number, param);

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(col[position]);
//         position++;
//     }
// }
// for (int i = 0; i <= array.Length; i++)
//     if (array[i] != array[array.Length - 1])
//     {
//         System.Console.WriteLine("not poly");
//         break;
//         // Environment.Exit(0);
//     }
//     else 
//     {
//         System.Console.WriteLine(" poly");
//         break;
//     } 

// PrintArray(array);
// System.Console.WriteLine();
// System.Console.WriteLine(array[1]);
// System.Console.WriteLine(array.Length);

// тут искал пути решения 
// ниже решил все сократить и сделать без функций 

System.Console.WriteLine("введите число: ");
string param = Console.ReadLine();
int number = int.Parse(param);
int[] array = new int[param.Length];
int index = array.Length - 1;
    while (number > 0)
    {
        array[index] = number % 10;
        number = number / 10;
        index--;
    }
for (int i = 0; i <= array.Length; i++)
    if (array[i] != array[array.Length - 1])
    {
        System.Console.WriteLine("не палиндром ");
        break;
    }
    else 
    {
        System.Console.WriteLine("палиндром ");
        break;
    } 
