// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
for (int i = 1; i <= 10; i++)
    Console.WriteLine(n + " * " + i + " = " + (i*n));
