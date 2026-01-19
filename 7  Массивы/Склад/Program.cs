using System;

public class MainClass
{
    public static void Main()
    {
        string sup = Console.ReadLine();
        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        string[,] par = new string[m, n];
        string[] line = new string[n];
        for (int i = 0; i < m; i++)
        {
            line = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                par[i, j] = line[j];
            }
        }

        int sum = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (par[i, j] == sup)
                {
                    sum++;
                }
            }
        }
        Console.WriteLine($"{sup} = {sum}");
    }
}