// See https://aka.ms/new-console-template for more information
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
double res = GetAverage(n1) + GetAverage(n2);
Console.WriteLine(res);

static double GetAverage(int n)
{
    double sum = 0;
    int count = 0;  
    for (int i=1; i<=n; i++)
    {
        sum += i;
        count++;
    }
    return sum/count;
}
