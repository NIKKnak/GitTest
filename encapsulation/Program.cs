

internal class Program
{
    static void Main(string[] args)
    {
        Renderer renderer = new Renderer();
        Player player = new Player(55, 10);

        renderer.Draw(player.X, player.Y);

    }
}


class Renderer
{
    public void Draw(int x, int y, char character = '@')
    {
        Console.CursorVisible = false;
        Console.SetCursorPosition(x, y);
        System.Console.Write(character);
        Console.ReadKey(true);


    }
}

class Player
{
    private int _x;
    private int _y;

    // public int X
    // {
    //     get
    //     {
    //         return _x;
    //     }

    //     private set
    //     {
    //         //if (X > 0 && X < 100)
    //         _x = value;
    //     }
    // }
    public int X { get; private set; }
    // запись Y = записи X
    public int Y { get; private set; }

    public Player(int x, int y)
    {
        //_x
        X = x;
        Y = y;
        //_y
    }



}



