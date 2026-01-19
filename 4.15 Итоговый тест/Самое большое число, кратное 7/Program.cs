// See https://aka.ms/new-console-template for more information
int a = int.TryParse(Console.ReadLine(), out a) ? a : 0;
int b = int.TryParse(Console.ReadLine(), out b) ? b : 0;
int i;
bool e = false;
for (i = b; i >= a; i--)
{
    if (i % 7 == 0)
    {
        e = true;
        break; 
    }
}
Console.WriteLine(e ? i : "NO");