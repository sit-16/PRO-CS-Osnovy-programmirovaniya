// See https://aka.ms/new-console-template for more information
int resCount = 0;

for (int i = 100; i <= 999; i++)
{
    int n = i;
    int sum = 0;
    while (n > 0)
    {
        int d = n % 10;
        sum += d;
        n = n / 10;
    }
    if (sum == 8)
    {
        resCount++;
    }
}
Console.WriteLine(resCount);
