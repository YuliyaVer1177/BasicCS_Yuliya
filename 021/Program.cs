// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти"); 
int part = Convert.ToInt32(Console.ReadLine());
if (part == 1)
{
    System.Console.WriteLine("x > 0 , y > 0");
}
else if (part == 2)
{
    System.Console.WriteLine("x < 0 , y > 0");
}
else if (part == 3)
{
    System.Console.WriteLine("x < 0 , y < 0");
}
else if (part == 4)
{
    System.Console.WriteLine("x > 0 , y < 0");
}
else System.Console.WriteLine("Введите от 1 до 4");
