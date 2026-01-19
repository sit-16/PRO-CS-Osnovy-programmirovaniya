// See https://aka.ms/new-console-template for more information
int[] a = [7, 9, 8, 1, 2, 3, 3, 10, 8, 6];
int s = 0;

for (int i = 1; i < 10; i++)
{
    if (a[i - 1] < a[i])
    {
        a[i] = a[i - 1] + 1;
        s = s + 1;
    }
}
Console.WriteLine(s);