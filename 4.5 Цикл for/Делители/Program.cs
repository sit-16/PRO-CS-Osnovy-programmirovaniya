// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
int count = 0;
for (int i = 1; i <= n; i++)
    count = n % i == 0 ? count+1 : count;
Console.WriteLine(count);