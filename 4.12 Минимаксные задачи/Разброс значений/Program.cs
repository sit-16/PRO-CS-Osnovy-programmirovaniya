// See https://aka.ms/new-console-template for more information
int min = 0;
int max = 0;
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;

for (int i = 0; i < n; i++)
{
    int a = int.TryParse(Console.ReadLine(), out a) ? a : 0;
    if (i == 0) 
    {
        min = a;
        max = a;
    }
    else
    {
        min = a < min ? a : min;
        max = a > max ? a : max;
    }

}

Console.WriteLine(max-min);