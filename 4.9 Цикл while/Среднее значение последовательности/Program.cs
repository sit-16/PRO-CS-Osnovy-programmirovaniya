// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
int count = 0;
double sum = 0;
while (n != 0)
{
    count++;
    sum += n; 
    n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
}
Console.WriteLine(sum/count);
