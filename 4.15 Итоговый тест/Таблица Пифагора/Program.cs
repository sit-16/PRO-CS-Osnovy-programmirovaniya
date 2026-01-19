// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
if (n == 0)
{
    Console.WriteLine("Таблица пустая");
}
else
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            Console.Write((i * j) + " ");
        }
        Console.WriteLine("");
    }
}
