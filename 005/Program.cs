//Из трех введенных чисел найти максимальное
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c || a==b)
{
    Console.WriteLine($"{a}");
}
if (b > a && b > c || b ==c)
{
    Console.WriteLine($"{b}");
}
if (c > a && c > b || c == a)
{
    Console.WriteLine($"{c}");
}
if (c == a && c == b)
{
    Console.WriteLine("Числа равны");
}