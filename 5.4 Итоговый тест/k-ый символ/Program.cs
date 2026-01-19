// See https://aka.ms/new-console-template for more information
string? s = Console.ReadLine();
int n = int.Parse(Console.ReadLine());
int l = s.Length;
if (n > l)
    Console.WriteLine("NO");
else
    Console.WriteLine(s[n-1]);