//С клавиатуры вводится два числа a и b. Выяснить, кратно ли число а числу b, если нет вывести остаток от деления а на b.
Console.WriteLine("Введите число"); 
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число"); 
int b = Convert.ToInt32(Console.ReadLine()); 
if (a % b == 0)
{
   Console.WriteLine($"{a} кратно {b}");  
}
else Console.WriteLine(a % b);


