// See https://aka.ms/new-console-template for more information
string? s = Console.ReadLine();
int l = s.Length;
while (l > 0) 
{
    char c = s[0];
    for (int i = 0; i < l; i++) 
        if (s[i]<c) c = s[i];
    int count = 0;
    string sTemp = "";
    for (int j = 0; j < l; j++)
    {
        if (s[j] != c) sTemp += s[j];
        else count++;
    }
    Console.WriteLine($"{c} {count}");
    s = sTemp;
    l -= count;
}