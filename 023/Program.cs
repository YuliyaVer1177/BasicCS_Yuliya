// Найти расстояние между точками в пространстве 2D
Console.WriteLine("Введите x1"); 
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1"); 
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2"); 
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2"); 
int y2 = Convert.ToInt32(Console.ReadLine());
double Distanse  (int x1, int x2, int y1, int y2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
}
System.Console.WriteLine(Distanse(x1, y1, x2, y2));
