// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
int n1111 = n % 10000;
int n0111 = n % 1000;
int n0011 = n % 100;

int n1000 = n1111 / 1000;
int n0100 = n0111 / 100;
int n0010 = n0011 / 10;
int n0001 = n % 10;

string res = n1000 == n0001 && n0100 == n0010 ? "YES" : "NO";
Console.WriteLine(res);

