// Найти сумму чисел от 1 до А
/*Console.WriteLine("Введите число A = ");
int A = Convert.ToInt32(Console.ReadLine());
int[] array = new int[A];
int n = 1;          
if (n <= A)
{
    System.Console.WriteLine ((A + n) * (A - n + 1) / 2);
}*/

Console.WriteLine("Введите число A = ");
int A = Convert.ToInt32(Console.ReadLine());
int i = 1;
int sum = 0;
while (i <= A)
{
    sum = sum + i;
    i = i + 1;
}
 System.Console.WriteLine(sum);