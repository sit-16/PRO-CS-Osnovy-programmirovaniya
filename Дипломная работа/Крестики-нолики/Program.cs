// See https://aka.ms/new-console-template for more information
string[,] map = new string[3, 3]
{
        {"1", "2", "3"},
        {"4", "5", "6"},
        {"7", "8", "9"}
};
bool isZeroNow = true;
for (int i = 0; i < 9; i++)
{
    isZeroNow = !isZeroNow;
    if (isZeroNow) Console.WriteLine("Ходят нолики");
    else Console.WriteLine("Ходят крестики");
    PrintMap(map);
    Console.WriteLine("Введите цифру вашего хода:");
    string sInput = GetPlayerCellNumber(map);
    map = MakeMove(map, sInput, isZeroNow);
    if (HasWinner(map)) break;
}
PrintMap(map);
if (HasWinner(map) && isZeroNow) Console.WriteLine("Нолики победили!");
else if (HasWinner(map) && !isZeroNow) Console.WriteLine("Крестики победили!");
else Console.WriteLine("Ничья!");

static void PrintMap(string[,] map)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                switch (map[i, j])
                {
                    case "X":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "O":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                }
                Console.Write(map[i, j] + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }

static string GetPlayerCellNumber(string[,] map)
{
    string sInput;
    while (true)
    {
        sInput = Console.ReadLine();
        int iInput;
        bool isDigit = false;
        bool inRange = false;
        bool isValid = false;
        isDigit = int.TryParse(sInput, out iInput);
        if (isDigit)
        {
            inRange = (iInput >= 0 && iInput <= 9);
            if (inRange)
            {
                isValid = IsMoveCorrect(map, sInput);
                if (isValid)
                {
                    break;
                }
            }
        }
        Console.Write("Неверный ввод. ");
        if (!isDigit || !inRange) Console.WriteLine("Пожалуйста, введите цифру от 1 до 9.");
        else if (!isValid) Console.WriteLine("Пожалуйста, введите цифру пустой ячейки.");
    }
    return sInput;
}

static bool IsMoveCorrect(string[,] map, string sInput)
{
    int count = 1;
    int iInput = int.Parse(sInput);
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (iInput == count)
                if (map[i, j] == "X" || map[i, j] == "O") return false;
            count++;
        }
    }
    return true;
}

static string[,] MakeMove(string[,] map, string sInput, bool isZeroNow)
{
    int count = 1;
    int iInput = int.Parse(sInput);
    string playerSymbol = isZeroNow ? "O" : "X";

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (iInput == count)
            {
                map[i, j] = playerSymbol;
                return map;
            }
            count++;
        }
    }
    return map;
}

static bool HasWinner(string[,] map)
{
    bool[] bv = { true, true, true };
    bool[] bh = { true, true, true };
    bool[] bd = { true, true };
    for (int i = 0; i < 3; i++)
    {
        bv[0] &= map[i, 0] == map[0, 0];
        bv[1] &= map[i, 1] == map[0, 1];
        bv[2] &= map[i, 2] == map[0, 2];
        bh[0] &= map[0, i] == map[0, 0];
        bh[1] &= map[1, i] == map[1, 0];
        bh[2] &= map[2, i] == map[2, 0];
        bd[0] &= map[i, i] == map[0, 0];
        bd[1] &= map[i, 2 - i] == map[0, 2];
    }
    return bv[0] || bv[1] || bv[2] || bh[0] || bh[1] || bh[2] || bd[0] || bd[1];
}