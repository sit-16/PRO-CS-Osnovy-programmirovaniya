// See https://aka.ms/new-console-template for more information
string[] size = Console.ReadLine().Split(' ');
int m = Convert.ToInt32(size[0]);
int n = Convert.ToInt32(size[1]);
int[,] mn = new int[m, n];

for (int i = 0; i < m; i++)
{
    string[] s = Console.ReadLine().Split(' ');
    for (int j = 0; j < n; j++)
    {
        mn[i, j] = int.Parse(s[j]);
    }
}
int max_m = 0;
int max_sum = 0;

for (int i = 0; i < m; i++)
{
    int sum = 0;
    for (int j = 0; j < n; j++)
    {
        sum+=mn[i, j];
    }
    if (sum > max_sum)
    {
        max_m = i;
        max_sum = sum;
    }
}

Console.WriteLine(max_sum);
Console.WriteLine(max_m);