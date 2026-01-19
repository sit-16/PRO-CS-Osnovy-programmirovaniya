// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;

while (n / 10 != 0)
{
    int nn = 0;
    while (n > 0)
    {
        int d = n % 10;
        n /= 10;
        nn += d;
    }
    n = nn;
}
Console.WriteLine(n);
