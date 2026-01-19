// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
int product = 1;
for (int i = 1; i <= n; i++)
    product *= i%2 == 0?i:1;
Console.WriteLine(product);
