//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите число"); 
int a = Convert.ToInt32(Console.ReadLine()); 
bool x = true;
if (a == 6 || a == 7)
{
    System.Console.WriteLine(x);
}
else System.Console.WriteLine(!x);
