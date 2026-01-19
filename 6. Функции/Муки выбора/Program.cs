// See https://aka.ms/new-console-template for more information
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
double res = GetDecision(GetSum(n1), GetSum(n2));
Console.WriteLine(res);

static int GetDecision(int n1, int n2)
{
    if (n1>n2)
        return 1;
    else if (n1 < n2)
        return -1;
    else return 0;
}

static int GetSum(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}
