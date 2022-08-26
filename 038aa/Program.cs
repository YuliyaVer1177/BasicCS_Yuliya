//38A Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива. 

int[] a;

Init(out a);
Print(a);
Difference();


void Init(out int[] a, int Length = 5)
{
    a = new int[Length];
    Random random = new Random();//псевдослучайные числа
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(-100, 1000);
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i],6}");
}

int Minim(int[] a)
{
    int mini = a[0];

    for (int i = 0; i < a.Length; i++)



        if (a[i] < mini)

            mini = a[i];

    return mini;

}
int Maxim(int[] a)
{
    int maxi = a[0];

    for (int i = 0; i < a.Length; i++)


        if (maxi < a[i])

            maxi = a[i];

    return maxi;


}

void Difference()
{

    System.Console.WriteLine($" -> {Maxim(a) - Minim(a)}");
}
