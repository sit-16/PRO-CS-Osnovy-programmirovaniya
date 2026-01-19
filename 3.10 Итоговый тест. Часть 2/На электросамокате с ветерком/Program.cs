// See https://aka.ms/new-console-template for more information
int dayRent = (int.TryParse(Console.ReadLine(), out dayRent)) ? dayRent : 0;
int freeMinutes = (int.TryParse(Console.ReadLine(), out freeMinutes)) ? freeMinutes : 0;
int totalMinutes = (int.TryParse(Console.ReadLine(), out totalMinutes)) ? totalMinutes : 0;
int costPerMinute = (int.TryParse(Console.ReadLine(), out costPerMinute)) ? costPerMinute : 0;

int delta = totalMinutes - freeMinutes;
int additionalMinutes = delta>0 ? delta : 0;

int totalCost = dayRent + additionalMinutes * costPerMinute;

Console.WriteLine(totalCost);