// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
int counter = 0;
while (n > 0)
{
    int digit = n % 10;
    counter += digit == 4 ? 1 : 0;
    n/= 10;
}
Console.WriteLine(counter);
