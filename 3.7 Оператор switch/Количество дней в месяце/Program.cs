// See https://aka.ms/new-console-template for more information
int m = int.TryParse(Console.ReadLine(), out m) ? m : 0;
switch (m)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine(31);
        break;
    case 2:
        Console.WriteLine(29);
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine(30);
        break;
}