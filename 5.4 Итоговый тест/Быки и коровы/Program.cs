// See https://aka.ms/new-console-template for more information
string? w = Console.ReadLine();
string? g = Console.ReadLine();
int b = 0;
int c = 0;
string tw = "";
string tg = "";
for (int i = 0; i < 4; i++)
{
    if (w[i] == g[i])
        b++;
    else {
        tw += w[i];
        tg += g[i];
    }
}
int l = tw.Length;
for (int i = 0; i < l; i++)
{
    for (int j = 0; j < l; j++)
    {
        if (tg[i] == tw[j])
            c++;
    }
}
if (b == 4) Console.WriteLine("Четыре быка! Ты выиграл!");
else if (c == 4) Console.WriteLine("Четыре коровы. Правильно расставьте цифры");
else Console.WriteLine($"Быки-{b}, коровы-{c}");