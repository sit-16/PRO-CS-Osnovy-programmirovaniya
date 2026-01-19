// See https://aka.ms/new-console-template for more information
string? s1 = Console.ReadLine();
string? s2 = Console.ReadLine();
if (s1[0] == s2[^1])
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");
