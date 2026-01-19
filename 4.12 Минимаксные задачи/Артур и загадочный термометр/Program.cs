// See https://aka.ms/new-console-template for more information
string? input = Console.ReadLine();
double temp = double.TryParse(input, out temp) ? temp : 0;
int err_count = 0;
int temp_count = 0;
double temp_sum = 0;
double min = 0;
double max = 0;

while (input != "кажется, я сломался")
{
    if (temp_count + err_count == 0)
    {
        min = temp;
        max = temp;
    }
    else
    {
        min = temp < min ? temp : min;
        max = temp > max ? temp : max;
    }
    if (temp >= -50 && temp <= 100)
    {
        temp_count++;
        temp_sum += temp;
    }
    else
    {
        err_count++;
    }
    input = Console.ReadLine();
    temp = double.TryParse(input, out temp) ? temp : 0;

}
double average_temp = temp_count != 0 ? temp_sum / temp_count : 0;
Console.WriteLine("Средняя температура: " + average_temp);
Console.WriteLine("Самая низкая температура: " + min);
Console.WriteLine("Самая высокая температура: " + max);
string advise = err_count > temp_count ? "Артур, термометр явно с другой планеты! Выбрось его!" : "Термометр иногда врет, но жить можно. Держи его подальше от микроволновки!";
Console.WriteLine("Совет: " + advise);