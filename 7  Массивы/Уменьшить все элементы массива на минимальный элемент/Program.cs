// See https://aka.ms/new-console-template for more information
string[] s = Console.ReadLine().Split(' ');
int[] n = new int[s.Length];
for (int i = 0; i < n.Length; i++)
    n[i] = int.Parse(s[i]);
int min = n[0];
for (int i = 0; i < n.Length; i++)
    if (n[i] < min)
        min = n[i];
for (int i = 0; i < n.Length; i++)
    Console.Write($"{n[i] - min} " );