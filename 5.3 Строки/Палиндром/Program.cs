string? s = Console.ReadLine();
string polyndrome = "";
for (int i = s.Length - 1; i >=0 ; i--)
{
    polyndrome += s[i];
}
if (s == polyndrome) Console.WriteLine("YES"); 
else Console.WriteLine("NO");



/*
string? s = Console.ReadLine();
bool polyndrome = true;
int len = s.Length - 1;
for (int i = 0; i <= len; i++)
{
    if (s[i] != s[len - i])
    {
        polyndrome = false;
        break;
    }
}
if (polyndrome) Console.WriteLine("YES"); 
else Console.WriteLine("NO");
*/