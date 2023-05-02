
double numberA;
double numberB;
double numberC;
string result;

Console.WriteLine("Enter the first number.");
numberA = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number.");
numberB = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the third number.");
numberC = double.Parse(Console.ReadLine());

if (numberA < numberB && numberA < numberC)
{
    // ---------------- JE SAIS QUE A EST PLUS PETIT B ET C
    Console.Write(numberA);
    if (numberB < numberC)
    {
        // ---------------- JE SAIS QUE B EST PLUS PETIT C
        Console.Write(numberB);
        Console.Write(numberC);
    }
    else
    {
        // ---------------- DONC JE SAIS QUE C EST PLUS PETIT QUE B
        Console.Write(numberC);
        Console.Write(numberB);
    }
}
else if (numberB < numberA && numberB < numberC)
{
    Console.Write(numberB);
    if (numberA < numberC)
    {
        // ---------------- JE SAIS QUE A EST PLUS PETIT C
        Console.Write(numberA);
        Console.Write(numberC);
    }
    else
    {
        // ---------------- DONC JE SAIS QUE C EST PLUS PETIT QUE A
        Console.Write(numberC);
        Console.Write(numberA);
    }
}
else
{
    // ---------------- DONC JE SAIS QUE C EST PLUS PETIT QUE A et B
    Console.Write(numberC);
    if (numberA < numberB)
    {
        // ---------------- JE SAIS QUE A EST PLUS PETIT C
        Console.Write(numberA);
        Console.Write(numberB);
    }
    else
    {
        // ---------------- DONC JE SAIS QUE C EST PLUS PETIT QUE A
        Console.Write(numberB);
        Console.Write(numberA);
    }

}



