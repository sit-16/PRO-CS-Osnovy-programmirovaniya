// See https://aka.ms/new-console-template for more information
int w = int.TryParse(Console.ReadLine(), out w) ? w : 0;
if (w < 60)
{
    Console.WriteLine("Легкий вес");
}
else
{
    if (w >= 60 && w < 64)
    {
        Console.WriteLine("Первый полусредний вес");
    }
    else
    {
        if (w >= 64 && w < 69)
        {
            Console.WriteLine("Полусредний вес");
        }
        else
        {
            Console.WriteLine("Too havy");
        }
    }
}