// See https://aka.ms/new-console-template for more information
int d1 = (int.TryParse(Console.ReadLine(), out d1)) ? d1 : 0;
int d2 = (int.TryParse(Console.ReadLine(), out d2)) ? d2 : 0;
int d3 = (int.TryParse(Console.ReadLine(), out d3)) ? d3 : 0;

int way1 = d1 + d2 + d3;
int way2 = (d1 + d3) * 2;
int way3 = (d2 + d3) * 2;
int way4 = (d1 + d2) * 2;

Console.WriteLine(Math.Min(way1, Math.Min(way2, Math.Min(way3, way4))));
