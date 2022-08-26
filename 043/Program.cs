//43. С клавиатуры вводится число N. Затем вводятся N чисел. 
//Определить сколько чисел больше 0 введено с клавиатуры

using System;
Console.ReadLine();
string s = Console.ReadLine();
//string[] ss = s.Split(' ');
string[] ss = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);//удаляет пустые вхождения
int[] a = Array.ConvertAll<string, int>(ss, int.Parse);

More0(a);


void More0(int[] a)
{
    int k = 0;
    for (int i = 0; i < a.Length; i++)
        if (a[i] > 0)
            k++;

    Console.WriteLine(k);
}

