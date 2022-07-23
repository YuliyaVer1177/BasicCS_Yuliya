// Программа проверяет пятизначное число на палиндромом
Console.WriteLine("Введите число"); 
int a = Convert.ToInt32(Console.ReadLine());
bool checkout (int a)
{
 int a1 = a / 10000;
 int a2 = a / 1000 % 10;
 int a3 = a % 100 / 10;
 int a4 = a %  10;
 return a1==a4 && a2==a3;
}
System.Console.WriteLine(checkout (a));