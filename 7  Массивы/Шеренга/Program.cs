// See https://aka.ms/new-console-template for more information
string[] ss = Console.ReadLine().Split(' ');
int n = Convert.ToInt32(Console.ReadLine());
bool past = false;

for (int i = 0; i < ss.Length; i++)
{
    if (Convert.ToInt32(ss[i]) < n)
    {
        Console.Write(i + 1);
        past = true;
        break;
    }
}
if (!past)
{
    Console.Write(ss.Length+1);
}
