// See https://aka.ms/new-console-template for more information
int a = int.TryParse(Console.ReadLine(), out a) ? a : 0;
bool dubl = true;
while (dubl)
{
    a++;
    dubl = false;
    int n = a;
    while (n > 0)
    {
        int d = n % 10;
        n /= 10;
        int m = n;
        while (m > 0)
        {
            int b = m % 10;
            m /= 10;
            if (b == d)
            {
                dubl = true; 
                break;  
            }            
        }
        if (dubl) break;
    }
}
Console.WriteLine(a);