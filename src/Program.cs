namespace src;
/// <summary>
///   ____ ___  _   _ ____   ___  _     _____           _____ ____  ___ ____  
///  / ___/ _ \| \ | / ___| / _ \| |   | ____|         |_   _|  _ \|_ _/ ___| 
/// | |  | | | |  \| \___ \| | | | |   |  _|    _____    | | | |_) || |\___ \
/// | |__| |_| | |\  |___) | |_| | |___| |___  |_____|   | | |  _ < | | ___) |
///  \____\___/|_| \_|____/ \___/|_____|_____|           |_| |_| \_\___|____/
/// </summary>
class Program
{
    private const char SYMBOL_PLAYER1 = 'x';
    private const char SYMBOL_PLAYER2 = 'O';

    /// <summary>
    /// Game Logic
    /// until we have a won, ask players to insert the input inside the Grid
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Console.WriteLine($"HOW TO PLAY - use the keys as follow to play");
        Console.WriteLine($"[q, w, e]");
        Console.WriteLine($"[a, s, d]");
        Console.WriteLine($"[z, x, c]");
        Console.WriteLine($"PRESS ANY KEY TO PLAY");
        Console.ReadLine();

        Console.Clear();
        Grid grid = new Grid();

        grid.PrintGrid(' ', ' ');

        char inputPlayer = ' ';
        int play = 1;
        char symbol = ' ';
        bool won = false;
        do
        {
            if (play == 1)
            {
                symbol = SYMBOL_PLAYER1;
                play = 2;
                Console.WriteLine($"Player 1 choose: ");
                inputPlayer = InputPlayer();
                Console.Clear();
                grid.PrintGrid(inputPlayer, symbol); // print player1 choice
            }
            else
            {
                play = 1;
                symbol = SYMBOL_PLAYER2;
                Console.WriteLine($"Player 2 choose: ");
                inputPlayer = InputPlayer();
                Console.Clear();
                grid.PrintGrid(inputPlayer, symbol); // print player2 choice
            }
            won = CheckWin(inputPlayer);
        } while (!won && !Grid.IsFull());

        if (won)
        {
            if (symbol == SYMBOL_PLAYER1)
                Console.WriteLine($"Player 1 won the game");
            else
                Console.WriteLine($"Player 2 won the game");
        } else
        {
            Console.WriteLine($"Noone had won!");
        }

        Console.WriteLine($"do you want to play again? [Y/n]");
        string choice = Console.ReadLine() ?? "";
        if (choice.ToLower() == "n")
        {
            Environment.Exit(1);
        }
        else
        {
            Grid.ResetGrid();
            Main(null!);
        }
    }

    /// <summary>
    /// <para>require player input and check if the value is already inserted on the Grid</para>
    /// <para>HOW TO PLAY - use the keys as follow to play</para>
    /// <c>
    /// <para>[q, w, e]</para>
    /// <para>[a, s, d]</para>
    /// <para>[z, x, c]</para>
    /// </c>
    /// </summary>
    /// <param name="input"></param>
    /// <returns>player input</returns>
    static char InputPlayer()
    {
        char input = ' ';
        bool valid = false;

        while (!valid)
        {
            input = Console.ReadKey().KeyChar;
            // if already exist we skip all other cases check
            valid = !Grid.SymbolAlreadyExist(input);

            // check if the input is valid
            switch (input, valid)
            {
                case ('q', true):
                case ('w', true):
                case ('e', true):
                case ('a', true):
                case ('s', true):
                case ('d', true):
                case ('z', true):
                case ('x', true):
                case ('c', true):
                    valid = true;
                    break;
                default:
                    valid = false;
                    string warning = "Attenzione! non valido, riprova:";
                    Console.WriteLine(warning);
                    break;
            }
        }
        return input;
    }

    /// <summary>
    /// for every player input we check if he has won
    /// </summary>
    /// <returns>true if he has won, false otherwhise</returns>
    static bool CheckWin(char choice)
    {
        bool won = false;

        /// <para>|x|x|x| ___ | | | | ___ | | | |</para>
        /// <para>| | | | ___ |x|x|x| ___ | | | |</para>
        /// <para>| | | | ___ | | | | ___ |x|x|x|</para>
        bool upHorizontal = Grid.q == Grid.w && Grid.w == Grid.e;
        bool midHorizontal = Grid.a == Grid.s && Grid.s == Grid.d;
        bool downHorizontal = Grid.z == Grid.x && Grid.x == Grid.c;

        /// <para>|x| | | ___ | |x| | ___ | | |x|</para>
        /// <para>|x| | | ___ | |x| | ___ | | |x|</para>
        /// <para>|x| | | ___ | |x| | ___ | | |x|</para>
        bool leftVertical = Grid.q == Grid.a && Grid.a == Grid.z;
        bool midVertical = Grid.w == Grid.s && Grid.s == Grid.x;
        bool rightVertical = Grid.e == Grid.d && Grid.d == Grid.c;

        /// <para>|x| | | ___ | | |x|</para>
        /// <para>| |x| | ___ | |x| |</para>
        /// <para>| | |x| ___ |x| | |</para>
        bool decreaseDiagonal = Grid.q == Grid.s && Grid.s == Grid.c;
        bool increaseDiagonal = Grid.z == Grid.s && Grid.s == Grid.e;

        switch (choice)
        {
            case 'q':
                won = upHorizontal || leftVertical || decreaseDiagonal;
                break;
            case 'w':
                won = upHorizontal || midVertical;
                break;
            case 'e':
                won = rightVertical || upHorizontal || increaseDiagonal;
                break;
            case 'a':
                won = leftVertical || midHorizontal;
                break;
            case 's':
                won = increaseDiagonal || decreaseDiagonal || midHorizontal || midVertical;
                break;
            case 'd':
                won = rightVertical || midHorizontal;
                break;
            case 'z':
                won = leftVertical || increaseDiagonal || downHorizontal;
                break;
            case 'x':
                won = downHorizontal || midVertical;
                break;
            case 'c':
                won = rightVertical || decreaseDiagonal || downHorizontal;
                break;

            default:
                break;
        }
        return won;
    }
}
