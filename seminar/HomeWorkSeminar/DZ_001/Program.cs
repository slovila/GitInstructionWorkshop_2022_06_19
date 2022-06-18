
Console.Write("Enter first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB)

{
    Console.Write("*** The numbers are equal ***");
}

if (numberA > numberB)
{
    Console.Write(" Maximal number is: " + numberA + " Minimal number is: " + numberB);
}
else
{
    Console.Write(" Maximal number is: " + numberB + " Minimal number is: " + numberA);
}
