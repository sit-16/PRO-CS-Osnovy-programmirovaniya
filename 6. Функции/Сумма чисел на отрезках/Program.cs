// See https://aka.ms/new-console-template for more information
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
int res = GetSum(n1, n2) + GetSum(n2, n3);
Console.WriteLine(res);

static int GetSum(int n1, int n2)
{
    int sum = 0;
    for (int i = n1; i <= n2; i++)
        sum += i;
    return sum;
}
