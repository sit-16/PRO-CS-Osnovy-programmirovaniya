// See https://aka.ms/new-console-template for more information
int a = int.TryParse(Console.ReadLine(), out a) ? a : 0;
int b = int.TryParse(Console.ReadLine(), out b) ? b : 0;
int k = int.TryParse(Console.ReadLine(), out k) ? k : 0;


for (int i = a; i <= b; i++)
{
    int d_count = 0;
    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0)
        {
            d_count++;
        }       
    }
    if (d_count <= k)
        Console.Write(i + " ");
}

