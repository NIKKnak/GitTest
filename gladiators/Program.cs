int health = 5, maxHealth = 10;
int mana = 7, maxMana = 10;

while (true)
{

    DrafBar(health, maxHealth, ConsoleColor.Green, 0, '|');
    DrafBar(mana, maxMana, ConsoleColor.DarkCyan, 1);


    Console.SetCursorPosition(0, 5);
    Console.Write("Введите число на которое изменяться жизни");
    health += Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число на которое изменяться мана");
    mana += Convert.ToInt32(Console.ReadLine());
    Console.ReadKey();
    Console.Clear();

}


static void DrafBar(int value, int MaxValue, ConsoleColor color, int position, char simbol = '_')
{
    ConsoleColor defaultColor = Console.BackgroundColor;

    string bar = "";

    for (int i = 0; i < value; i++)
    {
        bar += simbol;
    }

    Console.SetCursorPosition(0, position);
    Console.Write("[");
    Console.BackgroundColor = color;
    Console.Write(bar);
    Console.BackgroundColor = defaultColor;

    bar = "";

    for (int i = value; i < MaxValue; i++)
    {
        bar += simbol;
    }

    System.Console.Write("]");

}