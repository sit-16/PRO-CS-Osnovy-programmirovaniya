// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
int pCount = 0;
int nCount = 0;
while (n != 0)
{
    if (n > 0)
    {
        pCount++;
    }
    else
    {
        nCount++;
    }
    n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
}
Console.WriteLine(pCount - nCount);
