// See https://aka.ms/new-console-template for more information
int s = int.Parse(Console.ReadLine());
string result = GetClothingDescription(s);
Console.WriteLine(result);

static string GetClothingDescription(int size)
{ 
    if (size<0)
    { 
        return "Ошибка: Размер одежды должен быть положительным числом.";
    }
    else if (size <= 42)
    {
        return "Это маленький размер одежды.";
    }
    else if (size > 42 && size <= 50)
    {
        return "Это средний размер одежды.";
    }
    else
    {
        return "Это большой размер одежды.";
    }
}