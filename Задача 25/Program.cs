Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень");
int pow = int.Parse(Console.ReadLine()!);
int Power (int a,int b)
{
    if (b < 0)
    {
        b = -b;
    }
    for(int i = 0; i < b; i++)
    {
        a = a * a; //a *= a
    }
    return a;
}