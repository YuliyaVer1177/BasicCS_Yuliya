//Возведите число а в натуральную степень b используя цикл
Console.WriteLine("Введите число a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());
int i = 1;
int pow = 1;
while (i <= b)
{
    pow = pow*a;
    i = i + 1;
}
System.Console.WriteLine(pow);