// See https://aka.ms/new-console-template for more information
int n = (int.TryParse(Console.ReadLine(), out n)) ? n : 0;
if (n <= 3)
    Console.WriteLine("начинающий");
else
{
    if (n >= 4 && n <= 7)
        Console.WriteLine("младший разработчик");
    else
    {
        if (n >= 8 && n <= 15)
        {
            Console.WriteLine("средний разработчик");
        }
        else
        {
            if (n >= 16)
                Console.WriteLine("старший разработчик");
        }
    }
}
