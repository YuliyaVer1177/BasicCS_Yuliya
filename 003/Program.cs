Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"max = {a}");
}
if (a < b)
{
    Console.WriteLine($"max = {b}");
}
else Console.WriteLine($"{a} = {b}");