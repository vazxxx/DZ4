Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число NIN");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число MAX");
int max = int.Parse(Console.ReadLine()!);

int[] array = GenArray (a,b,c);
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

int[] GenArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}