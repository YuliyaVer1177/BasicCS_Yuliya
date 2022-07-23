//С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.
Console.WriteLine("Введите число"); 
int a = Convert.ToInt32(Console.ReadLine()); 
if (a < 100)
{
   Console.WriteLine("Это число не имеет третьей цифры"); 
}
else Console.WriteLine(a.ToString()[2]);