// See https://aka.ms/new-console-template for more information
int a = int.TryParse(Console.ReadLine(), out a) ? a : 0;
int b = int.TryParse(Console.ReadLine(), out b) ? b : 0;
string s = Console.ReadLine();
double result = 0;
switch (s)
{
    case "+":
        result = a + b;
        Console.WriteLine(result);
        break;
    case "-":
        result = a - b;
        Console.WriteLine(result);
        break;
    case "*":
        result = a* b;
        Console.WriteLine(result);
        break;
    case "/":
        if (b != 0)
        {
            result = (double)a / b;
            Console.WriteLine(result);
        }
        else 
        {
            Console.WriteLine("На ноль делить нельзя!");
        }
            break;
    default:
        Console.WriteLine("Неверная операция");
        break;
}
    




