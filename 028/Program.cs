//Определить колич-во цифр в числе. Сделать подпрограмму
Console.WriteLine("Введите число A = ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 0;

int countDig(int a){ //подпрограмма в которой будет действие
if (a == 0)
{
    return 1;

}
else while (a != 0)
{
    i = i+1;
    a = a/10;
}
return i;
}
System.Console.WriteLine(countDig(a));