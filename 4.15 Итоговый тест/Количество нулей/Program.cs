// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
int counter = 0;
int count = int.TryParse(Console.ReadLine(), out count) ? count : 0;
for (int i = 0; i < count; i++)
{
    int n = int.TryParse(Console.ReadLine(), out n) ? n : -1;
    if (n == 0) counter++;
}
Console.WriteLine(counter);