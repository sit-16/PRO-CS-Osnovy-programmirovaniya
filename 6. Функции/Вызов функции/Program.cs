// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
int res = ProcessNumber(n);
Console.WriteLine(res);

static int Square(int number)
{
    return number * number;
}
static int ProcessNumber(int number)
{
    int squared = Square(number);
    return squared + 10;
}