// See https://aka.ms/new-console-template for more information
string[] ss = Console.ReadLine().Split(' ');
int n = Convert.ToInt32(ss[0]);
int h = Convert.ToInt32(ss[1]);
ss = Console.ReadLine().Split(' ');
int[] nn = new int[ss.Length];
for (int i = 0; i < n; i++)
{
    if (Convert.ToInt32(ss[i]) > h)
        nn[i] = 2;
    else
        nn[i] = 1;
}
int sum = 0;
for (int i = 0; i < n; i++)
{
    sum+= nn[i];
}
Console.Write(sum);