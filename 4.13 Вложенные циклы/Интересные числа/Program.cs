// See https://aka.ms/new-console-template for more information
int resCount = 0;

for (int i = 10; i <= 999; i++)
{
    int n = i;
    int sum = 1;
    while (n > 0)
    {
        int d = n % 10;
        sum *= d;
        n = n / 10;
    }
    int t = 2 * sum;
    if (t == i)
    {
        resCount++;
    }
}
Console.Write(resCount);
