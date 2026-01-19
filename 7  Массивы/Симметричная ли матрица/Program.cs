// See https://aka.ms/new-console-template for more information
int m = Convert.ToInt32(Console.ReadLine());
int[,] mm = new int[m, m];
for (int i = 0; i < m; i++)
{
    string[] s = Console.ReadLine().Split(' ');
    for (int j = 0; j < m; j++)
    {
        mm[i, j] = int.Parse(s[j]);
    }
}

int l = m - 1;
bool res = true;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (mm[i, j] != mm[j, i])
            res = false;
    }
}
if (res)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");