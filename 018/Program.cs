//По двум заданным числам проверять яв-ся ли одно квадратом другого. Исп Подпрограмму
Console.WriteLine("Введите число"); 
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число"); 
int b = Convert.ToInt32(Console.ReadLine()); 
bool checkout (int a, int b)
{
    return a == b*b || b == a*a;
}
System.Console.WriteLine(checkout(a, b));