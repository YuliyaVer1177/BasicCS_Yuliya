Console.WriteLine("Введите число"); 
int a = Convert.ToInt32(Console.ReadLine()); 
int b = a % 10;
int c = a / 10;
if (b >= c)
{
    Console.WriteLine($"{b}"); 
}
else Console.WriteLine($"{c}"); 