// See https://aka.ms/new-console-template for more information
int n = (int.TryParse(Console.ReadLine(), out n)) ? n : 0;

int n01 = n % 10;
int n11 = n % 100;

string ending;
if (n01 == 1 && n11 != 11)
{
    ending = "";
}
else if ((n01 == 2 || n01 == 3 || n01 == 4) && (n11 != 12 || n11 != 13 || n11 != 14))
{
    ending = "a";
}
else
{
    ending = "ов";
}
Console.WriteLine(n + " Гимназист" + ending);
