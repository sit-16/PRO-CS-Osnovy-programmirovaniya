// See https://aka.ms/new-console-template for more information
int age = int.TryParse(Console.ReadLine(), out age)?age:0;
string? gender = Console.ReadLine();
if (age >= 12 && age <= 18 && gender == "m")
{ 
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}