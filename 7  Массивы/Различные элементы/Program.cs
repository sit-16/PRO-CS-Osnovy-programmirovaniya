// See https://aka.ms/new-console-template for more information
string[] ss = Console.ReadLine().Split(' ');
int old = Convert.ToInt32(ss[0]);
int counter = 1;
for (int i = 1; i < ss.Length; i++)
{
    if (Convert.ToInt32(ss[i]) > old)
    {
        counter++;
        old = Convert.ToInt32(ss[i]);
    }
}
Console.WriteLine(counter);