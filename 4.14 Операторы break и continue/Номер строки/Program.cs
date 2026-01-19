// See https://aka.ms/new-console-template for more information
using System;
int count = 0;
string? m = Console.ReadLine();
while (true)
{
    string? s = Console.ReadLine();
    count++;
    if (m == s) break;
}
Console.WriteLine(count);