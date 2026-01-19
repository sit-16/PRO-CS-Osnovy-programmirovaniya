// See https://aka.ms/new-console-template for more information
int max = int.TryParse(Console.ReadLine(), out max) ? max : 0;
int resValue = 0;
int resSum = 0;

for (int i = 1; i <= max; i++)
{
    int n = i;
    int sum = 0;
    while (n > 0)
    {
        int d = n % 10;
        sum += d;
        n = n / 10;
    }
    if (sum > resSum)
    {
        resSum = sum;
        resValue = i;
        /*if (resValue == 0)
        {
            resValue = i;
        }
        else if (i < resValue)
        {
            resValue = i;
        }*/
    }
}
Console.WriteLine(resValue + " " + resSum);
