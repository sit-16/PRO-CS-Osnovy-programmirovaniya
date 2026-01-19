// See https://aka.ms/new-console-template for more information
string? correctPass = Console.ReadLine();
string? newPass = "";
int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
int count = 0;
while (count < n && newPass != correctPass)
{
    newPass = Console.ReadLine();
    count++;
}
if (newPass == correctPass)
{
    Console.WriteLine($"Доступ разрешен с {count} попытки"); 
}
else
{
    Console.WriteLine("Вы исчерпали все попытки");
}
