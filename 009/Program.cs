//Вывести на экран четные числа от1 до N
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= a)
{
    Console.WriteLine(i); 
    i = i +2;
}
