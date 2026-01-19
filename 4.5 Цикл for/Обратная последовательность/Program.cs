// See https://aka.ms/new-console-template for more information
int a = int.TryParse(Console.ReadLine(), out a) ? a : 0;
int b = int.TryParse(Console.ReadLine(), out b) ? b : 0;
for (int i = b; i >= a; i--)
    Console.WriteLine(i);