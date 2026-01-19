// See https://aka.ms/new-console-template for more information
int n0 = int.TryParse(Console.ReadLine(), out n0) ? n0 : 0;
int n = n0;
int max = n % 10;
int ather_count = 0;
int max_count = 0;
while (n > 0)
{
    int t = n % 10;
    max = t > max ? t : max;
    n = n / 10;
}
Console.WriteLine("Самая большая цифра: " + max);
n = n0;
while (n > 0)
{
    int t = n % 10;
    if (t == max)
    {
        max_count++;
    }
    else
    {
        ather_count++;
    }
    n = n / 10;
}
Console.WriteLine("Она встречается " + max_count + " раз");
Console.WriteLine(ather_count >= max_count ? "True" : "False");