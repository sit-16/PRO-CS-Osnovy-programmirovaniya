// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
bool is7 = false;
bool is0 = false;
while (n > 0)
{
    int digit = n % 10;
    is7 |= digit == 7;
    is0 |= digit == 0;
    n /= 10;
}
string result = is7 && !is0 ? "YES" : "NO";
Console.WriteLine(result);