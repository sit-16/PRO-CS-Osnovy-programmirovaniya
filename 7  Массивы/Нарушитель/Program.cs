using System;

public class MainClass
{
    public static void Main()
    {
        int stud = Convert.ToInt32(Console.ReadLine());
        string net = Console.ReadLine();
        string[] line = new string[2];
        string[] ip = new string[4];

        bool failure = false;
        for (int i = 0; i < stud; i++)
        {
            line = Console.ReadLine().Split(' ');
            ip = line[1].Split('.');
            if (ip[0] != net)
            {
                Console.WriteLine($"{line[0]} нарушитель, писал(а) тест с телефона.");
                failure = true;
            }
        }
        if (!failure) Console.WriteLine("Никто не нарушил, все молодцы");
    }
}