﻿//Удалить вторую цифру целого числа введенного с клавиатуры
Console.WriteLine("Введите число"); 
int a = Convert.ToInt32(Console.ReadLine()); 
if (a <= 9)
{
    Console.WriteLine("Введите число больше 9"); 
}
else if (a >= 10 && a < 100)
{
    Console.WriteLine(a / 10); 
}
else if (a >= 100 && a < 1000)
{
    int b = a / 100;
    int c = a % 10;
    Console.WriteLine($"{b}{c}"); 
}