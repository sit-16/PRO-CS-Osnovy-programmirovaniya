// See https://aka.ms/new-console-template for more information
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int res = GetDig(n1) * GetDig(n2);
Console.WriteLine(res);


static int GetDig(int n)
{
    int count = 0;
    while (n > 0)
    {
        count++;
        n /= 10;
    }
    return count;
}
