// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите число A = ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= a)
{
    int b = i*i*i; //формула i в кубе Math.Pow(i,3)
    if (b % 2 == 0)
    {
        System.Console.WriteLine(b);
    }
    i ++;
}
// вывели только четные 1^3=1, 2^3=8, 3^3=27, 4^3=64