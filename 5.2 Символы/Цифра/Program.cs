// See https://aka.ms/new-console-template for more information
while (true)
{
    char ch = Convert.ToChar(Console.ReadLine());
    if (ch >= '0' && ch <= '9')
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}