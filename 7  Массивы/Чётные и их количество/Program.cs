// See https://aka.ms/new-console-template for more information
string[] ss = Console.ReadLine().Split(' ');
int counter = 0;
for (int i = 0; i < ss.Length; i++)
{
    if (Convert.ToInt32(ss[i]) % 2 == 0)
    {
        counter++;
        Console.Write(ss[i] + " ");
    }
}
Console.WriteLine("\n" + counter);