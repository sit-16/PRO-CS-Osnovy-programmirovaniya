// See https://aka.ms/new-console-template for more information
int a = int.TryParse(Console.ReadLine(), out a) ? a : 0;
int b = int.TryParse(Console.ReadLine(), out b) ? b : 0;
int c = int.TryParse(Console.ReadLine(), out c) ? c : 0;

if (a == b && b == c && a == c)
{
    Console.WriteLine(3);
}
else
{
    if (a != b && b != c && a != c)
    {
        Console.WriteLine(0);
    }
    else
    {
        Console.WriteLine(2);
    }
}
