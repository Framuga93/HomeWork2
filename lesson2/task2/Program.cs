//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

int i = new Random().Next(100,999);
int max = (i/100)*10+i%10;
System.Console.WriteLine(i);
System.Console.WriteLine(max); 


