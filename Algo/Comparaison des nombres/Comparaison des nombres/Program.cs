/*
 * VARIABLES
 * 
 * entier numberA;
 * 
 * PROCESS
 * 
 * Write ("Enter your age.");
 * Read numberA;
 * 
 * IF >= 18;
 *     Write ("You're an adult.");
 *     
 * ELSE IF < 0; 
 *     Write ("You are not born.");
 *     
 * ELSE;
 *     Write ("You're a minor.");
 *     
 * ENDIF
 */

int numberA;

Console.WriteLine("Enter your age.");
numberA = int.Parse(Console.ReadLine());

if (numberA >= 18)
{
Console.WriteLine("You're an adult.");
}
else if (numberA < 0)
{
    Console.WriteLine("You are not born.");
}
else
{
    Console.WriteLine("You're a minor.");
}