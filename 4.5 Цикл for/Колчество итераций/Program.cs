// See https://aka.ms/new-console-template for more information
int a = int.TryParse(Console.ReadLine(), out a) ? a : 0;
int b = int.TryParse(Console.ReadLine(), out b) ? b : 0;
a = a % 2 == 0 ? a : a + 1;
for (int i = a; i <= b; i = i + 2)
    Console.WriteLine(i);