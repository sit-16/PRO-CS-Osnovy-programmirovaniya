// See https://aka.ms/new-console-template for more information

int n = (int.TryParse(Console.ReadLine(), out n)) ? n : 0;
if (n % 2 != 0)
    Console.WriteLine("YES");
else
{
    if (n >= 2 && n <= 5)
        Console.WriteLine("NO");
    else
    {
        if (n >= 6 && n <= 20)
        {
            Console.WriteLine("YES");
        }
        else
        {
            if (n > 20)
                Console.WriteLine("NO");
        }
    }
}