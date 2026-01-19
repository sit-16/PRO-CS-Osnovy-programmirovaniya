// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
int count = 0;
while (n != 0)
{
    count += ((n % 2 == 0) && (n % 3 != 0)) ? n : 0;
    n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
}
Console.WriteLine(count);
