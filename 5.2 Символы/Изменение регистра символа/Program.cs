// See https://aka.ms/new-console-template for more information
while (true)
{
    char ch = Convert.ToChar(Console.ReadLine());
    char newCh = '*';
    int d = 'a' - 'A';
    if (ch >= 'A' && ch <= 'Z')
    {
        newCh = (char)(ch + d);
    }
    else if (ch >= 'a' && ch <= 'z')
    {
        newCh = (char)(ch - d);
    }
    Console.WriteLine(newCh);
}