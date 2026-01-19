// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
while (n > 0)
{
    int digit = n % 10;
    Console.Write(digit);
    n /= 10;
}

