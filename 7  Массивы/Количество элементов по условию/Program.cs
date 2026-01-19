// See https://aka.ms/new-console-template for more information
string[] ss = Console.ReadLine().Split(' ');
string[] ss1 = new string[ss.Length];
string[] ss2 = new string[ss.Length];
int counter = 0;
for (int i = 0; i < ss.Length; i++)
{
    int n = Convert.ToInt32(ss[i]);
    if (n % 3 == 0 && n % 10 == 7)
    {
        counter++;
        ss1[i] = "0";
    }
    else
    {
        ss1[i] = "1";
    }

}
string s = Convert.ToString(counter);
for (int i = 0; i < ss.Length; i++)
{
    if (ss1[i] == "0") 
        ss2[i] = s;
    else if (ss1[i] == "1")
        ss2[i] = ss[i];
    Console.Write(ss2[i] + " ");
}