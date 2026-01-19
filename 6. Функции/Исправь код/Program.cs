// See https://aka.ms/new-console-template for more information

string n = Console.ReadLine();
string f = Console.ReadLine();
string o = Console.ReadLine();
Console.WriteLine($"{n} {ChangeName(f)} {ChangeName(o)}");

static string ChangeName(string s)
{
    return s[0] + ".";    
}

static bool IsCharacterUnique(string input, char symbol)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++) 
    {
        if (input[i] == symbol)
        {
            count++;
        }
    }
    return count==1?true:false;
}