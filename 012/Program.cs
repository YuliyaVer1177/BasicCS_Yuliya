//У целого числа из диапазона [10, 99] показать наибольшую цифру числа
Console.WriteLine("Введите число"); 
int a = Convert.ToInt32(Console.ReadLine()); 
int b = a % 10;
int c = a / 10;
if (b >= c)
{
    Console.WriteLine($"{b}"); 
}
else Console.WriteLine($"{c}"); 