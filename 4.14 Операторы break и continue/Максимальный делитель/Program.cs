// See https://aka.ms/new-console-template for more information
int max = int.TryParse(Console.ReadLine(), out max) ? max : 0;
int n = max;
while (n > 0)
{
    n--;
    if (max % n == 0)
        break;
}
Console.WriteLine(n);
