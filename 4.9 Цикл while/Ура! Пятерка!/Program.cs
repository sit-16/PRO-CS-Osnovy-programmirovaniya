// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
int count = 0;
while (n != 5)
{
    n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
    count++;
}
Console.WriteLine(count--);
