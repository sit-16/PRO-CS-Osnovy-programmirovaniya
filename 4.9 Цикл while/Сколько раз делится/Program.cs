// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
bool stop = false;
int counter = 0;
int denominator = 3;
while (!stop)
{
    if (n % denominator == 0)
    {
        n /= denominator;
        counter++;
    }
    else
    {
        stop = true;
    }
}
Console.WriteLine(counter);
