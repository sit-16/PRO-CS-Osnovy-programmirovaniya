// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

int n = (int.TryParse(Console.ReadLine(), out n)) ? n : 0;
int a1 = -30;
int a2 = 2;
int b1 = 7;
int b2 = 25;

if ((n > a1 && n <= a2) || (n > b1 && n <= b2))
{
    Console.WriteLine("Принадлежит");
}
else
{
    Console.WriteLine("Не принадлежит");
}
