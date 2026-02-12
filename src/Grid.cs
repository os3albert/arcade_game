class Grid
{
    public static char q = ' ', w = ' ', e = ' ';
    public static char a = ' ', s = ' ', d = ' ';
    public static char z = ' ', x = ' ', c = ' ';

    /// <summary>
    /// Print the grid
    /// <c>
    /// <para>[ | | ]</para>
    /// <para>[ | | ]</para>
    /// <para>[ | | ]</para>
    /// </c>
    /// </summary>
    public void PrintGrid(char scelta, char player)
    {
        switch (scelta)
        {
            /// [q, w, e]
            /// [ ,  ,  ]
            /// [ ,  ,  ]
            case 'q': q = player; break;
            case 'w': w = player; break;
            case 'e': e = player; break;

            /// [ ,  ,  ]
            /// [a, s, d]
            /// [ ,  ,  ]
            case 'a': a = player; break;
            case 's': s = player; break;
            case 'd': d = player; break;

            /// [ ,  ,  ]
            /// [ ,  ,  ]
            /// [z, x, c]
            case 'z': z = player; break;
            case 'x': x = player; break;
            case 'c': c = player; break;

            default:
                break;
        }
        string grid = "";
        grid += $"[{q}|{w}|{e}]\n";
        grid += $"[{a}|{s}|{d}]\n";
        grid += $"[{z}|{x}|{c}]\n";
        Console.WriteLine($"{grid}");
    }

    /// <summary>
    /// used to avoid to check keypressed keys if the player input already exist
    /// </summary>
    /// <param name="input"></param>
    /// <returns>ritorna true se il valore e' gia' presente</returns>
    public static bool SymbolAlreadyExist(char input)
    {
        bool result = false;
        switch (input)
        {
            /// [q, w, e]
            /// [ ,  ,  ]
            /// [ ,  ,  ]
            case 'q': result = !string.IsNullOrWhiteSpace(Convert.ToString(Grid.q)); break;
            case 'w': result = !string.IsNullOrWhiteSpace(Convert.ToString(Grid.w)); break;
            case 'e': result = !string.IsNullOrWhiteSpace(Convert.ToString(Grid.e)); break;

            /// [ ,  ,  ]
            /// [a, s, d]
            /// [ ,  ,  ]
            case 'a': result = !string.IsNullOrWhiteSpace(Convert.ToString(Grid.a)); break;
            case 's': result = !string.IsNullOrWhiteSpace(Convert.ToString(Grid.s)); break;
            case 'd': result = !string.IsNullOrWhiteSpace(Convert.ToString(Grid.d)); break;

            /// [ ,  ,  ]
            /// [ ,  ,  ]
            /// [z, x, c]
            case 'z': result = !string.IsNullOrWhiteSpace(Convert.ToString(Grid.z)); break;
            case 'x': result = !string.IsNullOrWhiteSpace(Convert.ToString(Grid.x)); break;
            case 'c': result = !string.IsNullOrWhiteSpace(Convert.ToString(Grid.c)); break;

            default:
                break;
        }
        return result;
    }

    public static void ResetGrid()
    {
        q = ' '; w = ' '; e = ' ';
        a = ' '; s = ' '; d = ' ';
        z = ' '; x = ' '; c = ' ';
    }

    public static bool IsFull()
    {
        return !string.IsNullOrWhiteSpace(Convert.ToString(q)) &&
        !string.IsNullOrWhiteSpace(Convert.ToString(w)) &&
        !string.IsNullOrWhiteSpace(Convert.ToString(e)) &&
        !string.IsNullOrWhiteSpace(Convert.ToString(a)) &&
        !string.IsNullOrWhiteSpace(Convert.ToString(s)) &&
        !string.IsNullOrWhiteSpace(Convert.ToString(d)) &&
        !string.IsNullOrWhiteSpace(Convert.ToString(z)) &&
        !string.IsNullOrWhiteSpace(Convert.ToString(x)) &&
        !string.IsNullOrWhiteSpace(Convert.ToString(c));
    }

}