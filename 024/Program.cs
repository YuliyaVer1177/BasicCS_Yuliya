// Вывести на экран таблицу квадратов чисел от 1 до N
Console.WriteLine("Введите число"); 
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= a)
{
    //System.Console.WriteLine(i*i);
    System.Console.Write($" {Math.Pow(i,2)}" );
    i = i + 1;
}
