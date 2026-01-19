// See https://aka.ms/new-console-template for more information
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int res = IsHappy(n1) && IsHappy(n2)?1:-1;
Console.WriteLine(res);


static bool IsHappy(int n)
{
    int n1 = n / 1000;
    int n2 = n % 1000;
    return GetSum(n1) == GetSum(n2);
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