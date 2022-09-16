int num;
Console.Write("Enter number: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"{num}-even number");
}
else
{
    Console.WriteLine($"{num}-no");
}