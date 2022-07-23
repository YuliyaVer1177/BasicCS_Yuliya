//Вывести на экран числа от -N до N

Console.WriteLine("Введите число"); 
int a = Convert.ToInt32(Console.ReadLine());
int b = -a;
int i = b;
while (i <= a)
{
    Console.WriteLine(i); 
    i = i +1;
}
