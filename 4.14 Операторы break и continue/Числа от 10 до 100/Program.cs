// See https://aka.ms/new-console-template for more information
while (true)
{
    int m = int.TryParse(Console.ReadLine(), out m) ? m : 0;
    if (m < 10) continue;
    if (m > 100) break;
    Console.WriteLine(m);
}

