// See https://aka.ms/new-console-template for more information
char c1 = Convert.ToChar(Console.ReadLine());
char c2 = Convert.ToChar(Console.ReadLine());
char min = c1 < c2 ? c1 : c2;
char max = c1 > c2 ? c1 : c2;
for (char c = min; c <= max; c++)
    Console.Write(c + " ");