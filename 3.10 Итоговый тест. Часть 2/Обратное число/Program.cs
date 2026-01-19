// See https://aka.ms/new-console-template for more information

double n = (double.TryParse(Console.ReadLine(), out n)) ? n : 0;
if (n == 0)
    Console.WriteLine("Обратного числа не существует");
else
{     
    Console.WriteLine(1/n);
}