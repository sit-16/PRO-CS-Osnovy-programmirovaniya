// See https://aka.ms/new-console-template for more information
string[] s = Console.ReadLine().Split(' ');
int l = s.Length;
string[] s1 = new string[l];
int shift = 1;
for (int i = 0; i < l; i++)
{    
    s1[GetIndex(i + shift, l)] = s[i];
}

for (int i = 0; i < l; i++)
{
    Console.Write(s1[i] + " ");
}

static int GetIndex(int n, int l)
{
    if (n >= l)
        return n - l;
    else return n;
}
