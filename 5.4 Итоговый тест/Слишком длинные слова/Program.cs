// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string? s = Console.ReadLine();
    int l = s.Length;
    if (l > 10)
        Console.WriteLine($"{s[0]}{l - 2}{s[^1]}");
    else Console.WriteLine(s);
}