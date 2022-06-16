Console.WriteLine("Enter first number");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberB == numberA * numberA) 
{
    Console.WriteLine("Второе число является квадратом первого");
}
if(numberB != numberA * numberA) 
{
    Console.WriteLine("Второе число НЕ является квадратом первого");
}
