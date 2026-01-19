string? s = Console.ReadLine();
int? k = int.Parse(Console.ReadLine());
for (int i = 0; i < s.Length; i++)
{
    if (i!=(k-1)) Console.Write(s[i]);
}