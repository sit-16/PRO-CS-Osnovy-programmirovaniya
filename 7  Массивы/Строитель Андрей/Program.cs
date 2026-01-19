using System;

public class MainClass
{
    public static void Main()
    {
        string[] line = Console.ReadLine().Split(' ');
        int n = line.Length;
        int d = 12;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += Convert.ToInt32(line[i]);
        }
        Console.WriteLine(sum % d > 0 ? sum / d + 1 : sum / d);
    }
}