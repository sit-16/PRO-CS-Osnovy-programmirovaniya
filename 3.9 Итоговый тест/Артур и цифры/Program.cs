// See https://aka.ms/new-console-template for more information
int k2 = int.TryParse(Console.ReadLine(), out k2) ? k2 : 0;
int k3 = int.TryParse(Console.ReadLine(), out k3) ? k3 : 0;
int k5 = int.TryParse(Console.ReadLine(), out k5) ? k5 : 0;
int k6 = int.TryParse(Console.ReadLine(), out k6) ? k6 : 0;

int count256 = Math.Min(k2, Math.Min(k5, k6));
k2 = k2 - count256;
k5 = k5 - count256;
k6 = k6 - count256;

int count32 = Math.Min(k2, k3);
k2 = k2 - count32;
k3 = k3 - count32;

Console.WriteLine(count256 * 256 + count32 * 32);