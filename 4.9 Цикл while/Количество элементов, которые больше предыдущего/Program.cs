// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
int count = 0;
double old_n = 0;
while (n != 0)
{
    old_n = n;
    n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
    if (old_n < n) count++;
}
Console.WriteLine(count);
