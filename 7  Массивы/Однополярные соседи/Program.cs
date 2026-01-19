// See https://aka.ms/new-console-template for more information
string[] s = Console.ReadLine().Split(' ');
int[] n = new int[s.Length];

for (int i = 0; i < s.Length; i++)
{
    n[i] = int.Parse(s[i]);
}
bool res = false;
for (int i = 1; i < n.Length; i++)
{
    if (n[i - 1] * n[i]>0)
        { res = true; break; }
}

if (res)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");