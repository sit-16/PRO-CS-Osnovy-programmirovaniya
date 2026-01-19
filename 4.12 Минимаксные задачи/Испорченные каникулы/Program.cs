// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
int min = n % 10;
while (n > 0)
{
    int t = n % 10;
    min = t < min ? t : min;
    n = n / 10;
}
Console.WriteLine(min);