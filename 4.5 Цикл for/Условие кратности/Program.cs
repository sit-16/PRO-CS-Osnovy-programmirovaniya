// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
int c = int.TryParse(Console.ReadLine(), out c) ? c : 0;
int d = int.TryParse(Console.ReadLine(), out d) ? d : 0;

for (int i = 1; i <= n; i++)
    if  (i % c == 0 && i % d != 0)
        Console.WriteLine(i);

