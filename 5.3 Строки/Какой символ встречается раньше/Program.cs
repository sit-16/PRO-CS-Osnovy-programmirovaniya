// See https://aka.ms/new-console-template for more information
string? s = Console.ReadLine();
string res = "-1";
for (int i = 0; i < s.Length; i++)
{
    if (s[i] == 'x')
    {
        res = Convert.ToString(s[i]);
        break;
    }else if (s[i] == 'w')
    {
        res = Convert.ToString(s[i]);
        break;
    }
}
Console.WriteLine(res);
