using System;

public class MainClass
{
    public static void Main()
    {
        int m = 3;
        int n = 5;
        int roses = 100;
        char[,] par = new char[m, n];
        string[] line = new string[n];
        for (int i = 0; i < m; i++)
        {
            line = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                par[i, j] = line[j][0];
            }
        }

        line = Console.ReadLine().Split(' ');
        int price_k = Convert.ToInt32(line[0]);
        int price_b = Convert.ToInt32(line[1]);
        int price_r = Convert.ToInt32(line[2]);

        int sum = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                switch (par[i, j])
                {
                    case 'к': sum += price_k * roses; break;
                    case 'б': sum += price_b * roses; break;
                    case 'р': sum += price_r * roses; break;
                }
            }
        }
        Console.WriteLine(sum);
    }
}
