// See https://aka.ms/new-console-template for more information
string s1 = Console.ReadLine();
string s2 = Console.ReadLine();
int res = CountLetter(s1, 'b') + CountLetter(s2, 'b');
Console.WriteLine(res);

static int CountLetter(string s, char c)
{
    int sum = 0;
    for (int i = 0; i < s.Length; i++)    
        sum += s[i] == c ? 1 : 0;
    return sum;
}
