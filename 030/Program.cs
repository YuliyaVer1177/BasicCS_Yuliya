//Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число"); 
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;
int mult = 1;
 
int Multiplication(int a)
{
    while (i <= a)
    {
        mult = mult*i;
        i ++;
    }
    return mult;
}
System.Console.WriteLine(Multiplication(a));