// See https://aka.ms/new-console-template for more information
int max = 0;
bool test = false;
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;

for (int i = 0; i < n; i++)
{
    int a = int.TryParse(Console.ReadLine(), out a) ? a : 0;
    if (i == 0)
    {
        max = a;
    }
    else
    {
        max = a > max ? a : max;
    }
    if (a <= 30) test = true;

}

Console.WriteLine(max + " " + (test ? "YES" : "NO"));