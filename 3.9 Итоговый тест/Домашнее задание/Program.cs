// See https://aka.ms/new-console-template for more information
int k = int.TryParse(Console.ReadLine(), out k) ? k : 0;
int m = int.TryParse(Console.ReadLine(), out m) ? m : 0;
double d =(double) k / m;
int res = (int)Math.Ceiling(d);
Console.WriteLine(res);
