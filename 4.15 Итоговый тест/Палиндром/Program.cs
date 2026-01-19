// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
int pnd0 = n;
int pnd1 = 0;
while (n > 0)
{
    int d = n % 10;
    pnd1 = pnd1 * 10 + d;
    n /= 10;
}

Console.WriteLine(pnd0 == pnd1 ? "YES" : "NO");
