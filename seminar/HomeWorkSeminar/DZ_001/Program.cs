
Console.Write("Enter first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.Write("maximal number is: " + numberA);
}
if (numberA < numberB)
{
    Console.Write("Maximal number is: " + numberB);
}
if (numberA == numberB)
{
    Console.Write("*** The numbers are equal ***");
}