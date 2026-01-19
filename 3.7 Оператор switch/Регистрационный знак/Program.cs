// See https://aka.ms/new-console-template for more information
int m = int.TryParse(Console.ReadLine(), out m) ? m : 0;
switch (m % 10)
{
    case 1:
        Console.WriteLine("Брестская область"); break;
    case 2:
        Console.WriteLine("Витебская область"); break;
    case 3:
        Console.WriteLine("Гомельская область"); break;
    case 4:
        Console.WriteLine("Гродненская область"); break;
    case 5:
        Console.WriteLine("Минская область"); break;
    case 6:
        Console.WriteLine("Могилевская область"); break;
    case 7:
        Console.WriteLine("г. Минск"); break;
    default:
        Console.WriteLine("Что-то не так разглядела"); break;
}
