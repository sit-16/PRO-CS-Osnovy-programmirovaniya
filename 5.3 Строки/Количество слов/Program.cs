// See https://aka.ms/new-console-template for more information
string s = Console.ReadLine();
int count = 1;
for (int i = 0; i < s.Length; i++)
{
    if (s[i] == ' ') count++;
}
Console.WriteLine(count);
