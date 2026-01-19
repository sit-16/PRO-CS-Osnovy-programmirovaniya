// See https://aka.ms/new-console-template for more information

int n = (int.TryParse(Console.ReadLine(), out n)) ? n : 0;
int a1 = -3;
int a2 = 1;
int b1 = 5;
int b2 = 9;

if ((n >= a1 && n <= a2) || (n >= b1 && n <= b2))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}