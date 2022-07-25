// Посчитать сумму цифр в числе
Console.WriteLine("Введите число"); 
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int sumDig(int a)
{
    while (a != 0)
    {
        int k = a%10;
        sum = sum + k;
        a = a/10;
    }
    return sum;
}

System.Console.WriteLine(sumDig(a));