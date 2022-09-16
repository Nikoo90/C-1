int num1, num2;
Console.Write("Enter one numbers: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter two numbers: ");
num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"Max number-{num1}, min number-{num2}");
}
else
{
    Console.WriteLine($"Max number-{num2}, min number-{num1}");
}