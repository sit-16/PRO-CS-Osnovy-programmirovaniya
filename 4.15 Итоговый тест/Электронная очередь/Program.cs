// See https://aka.ms/new-console-template for more information
int line_Lenght = 0;
string line_Status = "Ожидание";
bool wday = true;
while (wday)
{
    string? order = Console.ReadLine();
    string message = "";
    switch (order){
        case "Новый клиент":
            line_Lenght++;
            break;
        case "Начало обслуживания":
            if (line_Status == "Обслуживание")
            {
                message = "Обслуживание не начато, не завершено обслуживание предыдущего клиента";
            }
            else if (line_Lenght == 0)
            {
                message = "Обслуживание не начато, в очереди никого нет";
            }
            else
            {
                line_Lenght--;
                line_Status = "Обслуживание";
             }
            break;
        case "Завершение обслуживания":
            line_Status = "Ожидание";
            break;
        case "Длина очереди":
            message = "Длина очереди: " + line_Lenght;
            break;
        case "Текущий статус":
            message = "Текущий статус: " + line_Status;
            break;
        case "Конец рабочего дня":
            wday = false;
            break;
        default:
            message = "Неизвестная команда";            
            break;
    }
    if (message!="") Console.WriteLine(message);
}
