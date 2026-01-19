// See https://aka.ms/new-console-template for more information
string? s = Console.ReadLine();
int len = s.Length;
bool found = false;
int i;
for (i = 0; i < len-1; i++)
{
    for (int j = i+1; j < len; j++)
    {
        if (s[i] == s[j])
        {
            found = true;
            break;
        }
    }
    if (found) break;
}
if (found) Console.WriteLine(s[i]);
else Console.WriteLine("NO");