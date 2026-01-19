// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
string[] sArr = Console.ReadLine().Split(' ');

for (int i = 0; i < n; i++)
{
    if (int.Parse(sArr[i]) % 3 == 0)
        Console.Write(sArr[i] + " ");
}