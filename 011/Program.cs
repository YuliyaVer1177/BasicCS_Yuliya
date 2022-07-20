Console.WriteLine("Введите число"); 
int a = Convert.ToInt32(Console.ReadLine()); 
int b = a % 100 / 10;
if (a <= 9)
{
    Console.WriteLine("Введите число больше 9"); 
}
else 

Console.WriteLine(b);
