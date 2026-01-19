// See https://aka.ms/new-console-template for more information
int n = 0;
int i = 1;
while (n<3)
{
    i++;
    int sum = 0;
    for (int j = 1; j < i; j++)
    {
        if (i % j == 0)
        {
            sum += j;
        }
    }
    if (sum == i)
    {
        Console.WriteLine(i);
        n++;
    }
}
