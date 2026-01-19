// See https://aka.ms/new-console-template for more information
string[] size = Console.ReadLine().Split(' ');
int n = Convert.ToInt32(size[0]);
int m = Convert.ToInt32(size[1]);
char[,] pix = new char[n, m];
string[] line;
for (int i = 0; i < n; i++)
{
    line = Console.ReadLine().Split(' ');
    for (int j = 0; j < m; j++)
    {
        pix[i, j] = line[j][0];
    }
}

bool color = false;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (pix[i, j] == 'C' || pix[i, j] == 'M'|| pix[i, j] == 'Y')
        {
            color = true;
            break;
        }
    }
}

Console.WriteLine(color ? "#Color" : "#Black&White");


