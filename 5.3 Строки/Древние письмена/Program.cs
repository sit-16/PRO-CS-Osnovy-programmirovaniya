// See https://aka.ms/new-console-template for more information
int n = int.TryParse(Console.ReadLine(),out n)?n:0;
for (int j = 0; j < n; j++)
{
    string? s = Console.ReadLine();
    int l = s.Length;
    int sum = 0;
    for (int i = 0; i < l; i++)
    {
        char c = s[i];
        int w = 0;
        switch (c)
        {
            case '/':
                w = 10000;
                break;
            case '$':
                w = 1000;
                break;
            case '?':
                w = 100;
                break;
            case 'л':
                w = 10;
                break;
            case '|':
                w = 1;
                break;
        }
        sum += w;
    }
    Console.WriteLine(sum);
}
