// Вывести на экран таблицу кубов чисел от 1 до N
Console.WriteLine("Введите число"); 
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;
System.Console.Write("number | " );
System.Console.WriteLine("  cube" );
System.Console.WriteLine("_______________" );

while (i <= a)
{
    //System.Console.WriteLine(i*i);
    System.Console.Write($"{i}      |");
    System.Console.WriteLine($" {Math.Pow(i,3)}" );
    System.Console.WriteLine("_______________" );
    i = i + 1;
}

