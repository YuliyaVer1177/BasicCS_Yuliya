// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");//метод
//Console.WriteLine((2+2)*(2/2-2%2)); 

//Объявление переменных
//int a, b=0;
//double c;
//string s;

/* Многострочный комментарий
int a=2, b=3;
int s=a+b;
Console.WriteLine(a+ "+" +b+ "=" +s); //Строка склеивания строк
System.Console.WriteLine($"{a}+{b}={s}"); // Строка интерполяции
System.Console.WriteLine("{0}+{1}={2}", a,b,s); // Строка форматирования
*/

//Ввести с клавиатуры целое число и вывести квадрат этого числа на экран
/*int a;
int b;
string? s;
s=Console.ReadLine();
a=Convert.ToInt32(s);
b=a*a;
System.Console.WriteLine($"{a}^2={b}");
*/

//Введение дробного числа
double a;
double b;
string? s;
s=Console.ReadLine();
a=Convert.ToDouble(s);
//a=3,14;
b=a*a;
System.Console.WriteLine($"{a}^2={b}");

