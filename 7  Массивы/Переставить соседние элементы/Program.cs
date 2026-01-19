// See https://aka.ms/new-console-template for more information
string[] s = Console.ReadLine().Split(' ');
string[] n = new string[s.Length];
s.CopyTo(n,0);
for (int i = 1; i < s.Length; i += 2)
{
    n[i - 1] = s[i];
    n[i] = s[i - 1];
}

for (int i = 0; i<s.Length; i++)
    Console.Write(n[i] + " ");
