// See https://aka.ms/new-console-template for more information
int count = int.TryParse(Console.ReadLine(), out count) ? count : 0;
for (int i = 0; i < count; i++)
{
    int code = int.TryParse(Console.ReadLine(), out code) ? code : 0;
    string country = "";
    switch (code)
    {
        case 460:
        case 461:
        case 462:
        case 463:
        case 464:
        case 465:
        case 466:
        case 467:
        case 468:
        case 469:
            country = "Россия";
            break;
        case 471:
            country = "Тайвань";
            break;
        case 474:
            country = "Эстония";
            break;
        case 475:
            country = "Латвия";
            break;
        case 476:
            country = "Азербайджан";
            break;
        case 477:
            country = "Литва";
            break;
        case 478:
            country = "Узбекистан";
            break;
        case 479:
            country = "Шри-Ланка";
            break;
        case 480:
            country = "Филиппины";
            break;
        case 481:
            country = "Беларусь";
            break;
        default:
            Console.WriteLine("Тут я тебе не помощник!");
            break;
    }
    if (country != "")
        Console.WriteLine("Код страны изготовителя (" + country + ")");
}
