// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
int i = n % 10;
string r = i % 2 == 0 ? "YES" : "NO";
Console.WriteLine(r);