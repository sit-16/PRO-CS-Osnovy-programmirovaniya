// See https://aka.ms/new-console-template for more information
string msg = Console.ReadLine();
int  n = int.Parse(Console.ReadLine());
Repeat(msg, n);
static void Repeat(string msg, int count)
{
    for (int i = 0; i< count; i++)
        Console.WriteLine(msg);
}