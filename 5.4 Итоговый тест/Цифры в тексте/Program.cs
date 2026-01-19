// See https://aka.ms/new-console-template for more information
string? s = Console.ReadLine();
for (int i = 0; i < s.Length; i++)
{
    if (s[i] >= '0' && s[i] <= '9')
        Console.Write(s[i] + " ");
}
