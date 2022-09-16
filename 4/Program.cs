int num, count;
Console.Write("Enret number: ");
num = Convert.ToInt32(Console.ReadLine());
count = 1;
while (count <= num)
{
    if (count % 2 == 0) { Console.Write($"{count} "); }
    count++;
}