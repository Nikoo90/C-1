int num1, num2, num3;

Console.Write("Enter one number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter two number: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter fhree number: ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"Max number-{num1}");
}
else if (num3 > num2 && num3 > num1)
{
    Console.WriteLine($"Max number-{num3}");
}
else
{
    Console.WriteLine($"Max number-{num2}");
}
