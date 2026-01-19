// See https://aka.ms/new-console-template for more information
int n = 3;
int m = 3;
int[,] cap = new int[n, m];
string[] line;
for (int i = 0; i < n; i++)
{
    line = Console.ReadLine().Split(' ');
    for (int j = 0; j < m; j++)
    {
        cap[i, j] = Convert.ToInt32(line[j]);
    }
}
int toFind = Convert.ToInt32(Console.ReadLine());
int attempt = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < attempt; i++)
{
    line = Console.ReadLine().Split(' ');
    int x = Convert.ToInt32(line[0]);
    int y = Convert.ToInt32(line[1]);
    if (x <= n && y <= m)
    {
        if (cap[x, y] == toFind)
        {
            count++;
        }
    }
}
if (count == attempt)
{
    Console.WriteLine("Captcha успешно пройдена");
}
else 
{
    Console.WriteLine("Вы не человек");
}

