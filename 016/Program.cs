// Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Введите число"); 
int a = Convert.ToInt32(Console.ReadLine()); 
bool b = true;
if (a % 7 == 0 && a % 23 == 0)
{
    System.Console.WriteLine(b);
}
else System.Console.WriteLine(!b);