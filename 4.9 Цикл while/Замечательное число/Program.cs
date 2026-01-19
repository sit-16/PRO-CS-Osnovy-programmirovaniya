// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
int n0 = n;
int sum = 0;
while (n > 0)
{
    int digit = n % 10;
    sum += digit;
    n /= 10;
}
string result = n0 % sum == 0 ? "YES" : "NO";
Console.WriteLine(result);
