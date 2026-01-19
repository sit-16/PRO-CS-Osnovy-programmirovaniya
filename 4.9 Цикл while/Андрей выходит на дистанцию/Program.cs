// See https://aka.ms/new-console-template for more information
double n = double.TryParse(Console.ReadLine(), out n) ? n : 0;
double n0 = 1;
bool stop = false;
int counter = 0;
double factor = 0.2;
while (!stop)
{
    if (n0 < n)
    {
        n0 += n0 * factor;
        counter++;
    }
    else
    {
        stop = true;
    }
}
Console.WriteLine(counter);