// See https://aka.ms/new-console-template for more information
string[] s = Console.ReadLine().Split(' ');
int prev = int.Parse(s[0]);
int count = 0;
for (int i = 1; i < s.Length; i++)
{
    if (int.Parse(s[i]) > int.Parse(s[i - 1]))
        count++;
}
Console.WriteLine(count);