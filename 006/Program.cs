//6. написать программу вычисления значения функций y = sin(a)

/*Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
double y;
y = Math.Sin(a);
Console.WriteLine(y);*/

double x=Math.PI;
double y=Math.Sin(x);
double y1=Math.Sin(x*2);
System.Console.WriteLine($"{y:G}");
System.Console.WriteLine(9.0/10000000.0);

if (Math.Abs(y-y1)<= 1E-10) System.Console.WriteLine("ОК"); // сравнение двух дробных чисел с погрешностью
else System.Console.WriteLine("Wrong");