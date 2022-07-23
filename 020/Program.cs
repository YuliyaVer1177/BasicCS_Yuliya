// Определить номер четверти плоскости, в которой находится точка с координатами x и y, причем x !=0, y !=0 (!= не равно)
Console.WriteLine("Введите x"); 
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y"); 
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    System.Console.WriteLine("I");
}
if (x < 0 && y > 0)
{
    System.Console.WriteLine("II");
}
if (x < 0 && y < 0)
{
    System.Console.WriteLine("III");
}
if (x > 0 && y < 0)
{
    System.Console.WriteLine("IV");
}
