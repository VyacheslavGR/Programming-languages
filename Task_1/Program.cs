Console.WriteLine("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.Write("max=");
    Console.WriteLine(a);
    Console.Write("min=");
    Console.WriteLine(b);
}
if(b > a)
{
    Console.Write("max=");
    Console.WriteLine(b);
    Console.Write("min=");
    Console.WriteLine(a);
}
if(a == b)
Console.Write("you entered the same numbers, try again!");

