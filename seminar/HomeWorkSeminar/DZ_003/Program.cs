/*Задача 3: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).*/

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