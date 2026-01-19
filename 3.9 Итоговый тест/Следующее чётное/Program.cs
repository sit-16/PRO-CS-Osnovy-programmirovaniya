// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n)?n:0;
int odd = n % 2;
int res = odd == 0? n + 2: n + 1;
Console.WriteLine(res);