// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
int n0 = n;
int nn = 0;
int i = 1;
while (n > 0)
{
    int d = n % 10;
    n /= 10;
    if (d == 5 || d == 7) continue;
    nn += d * i;
    i *= 10;
}
//Console.WriteLine(n0 + " " + nn);
Console.WriteLine(nn);
