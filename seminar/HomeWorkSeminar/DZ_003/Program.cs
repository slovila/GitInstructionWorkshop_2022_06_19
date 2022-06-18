Console.Write("enter the number > ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 2;
if (result == 0)
{
    Console.WriteLine(" Число " + number + " четное");
}
else
{
    Console.WriteLine(" Число " + number + " нечетное");
}