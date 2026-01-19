// See https://aka.ms/new-console-template for more information
int w = int.TryParse(Console.ReadLine(), out w) ? w : 0;
bool bMinW = w > 2; //Делится ли вес на 2 без остатка
bool bOddW = w % 2 == 0; //Делится ли вес на 2 без остатка


string res = (bMinW && bOddW) ? "YES" : "NO";
Console.WriteLine(res);
