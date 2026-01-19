// See https://aka.ms/new-console-template for more information
string txt = Console.ReadLine();
string path = Console.ReadLine();
WriteToFile(txt, path);

static void WriteToFile(string t, string p)
{
    Console.WriteLine($"Текст {t} записан в файл по адресу {p}");
}
