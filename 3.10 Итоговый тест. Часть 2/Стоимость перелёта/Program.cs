// See https://aka.ms/new-console-template for more information
int ticketCost = (int.TryParse(Console.ReadLine(), out ticketCost)) ? ticketCost : 0;
int windowCost = (int.TryParse(Console.ReadLine(), out windowCost)) ? windowCost : 0;
int foodCost = (int.TryParse(Console.ReadLine(), out foodCost)) ? foodCost : 0;
int luggageCost = (int.TryParse(Console.ReadLine(), out luggageCost)) ? (luggageCost <= 3 ? 0 : 200 * (luggageCost - 3)) : 0;

int totalCost = ticketCost + windowCost + foodCost + luggageCost;
Console.WriteLine("Полёт обойдётся в " + totalCost + " рублей");
