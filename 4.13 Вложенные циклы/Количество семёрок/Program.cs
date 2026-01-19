// See https://aka.ms/new-console-template for more information
int max = int.TryParse(Console.ReadLine(), out max) ? max : 0;
int counter = 0;

for (int i = 1; i <= max; i++)
{
    int n = i;
    while (n > 0)
    {
        int d = n % 10;
        if (d == 7)
            counter++;
        n = n / 10;
    }
}
Console.WriteLine(counter);