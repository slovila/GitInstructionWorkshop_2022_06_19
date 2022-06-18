int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
Console.Write("Введите первое число > ");
int a = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите второе число > ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число > ");
int c = Convert.ToInt32(Console.ReadLine());

int max = Max(a, b, c);
Console.WriteLine("Максимальное число: " + max);
