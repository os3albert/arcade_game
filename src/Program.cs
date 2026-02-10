using System.Reflection.Metadata;
using System.Text;

namespace src;

class Grid
{
    public static string q = " ", w = " ", e = " ";
    public static string a = " ", s = " ", d = " ";
    public static string z = " ", x = " ", c = " ";

    /// <summary>
    /// <c>
    /// <para>| | | |</para>
    /// <para>| | | |</para>
    /// <para>| | | |</para>
    /// </c>
    /// </summary>
    public static void PrintGrid(string scelta)
    {
        q = scelta;
        string grid = "";
        grid += $"[{q}|{w}|{e}]\n";
        grid += $"[{a}|{s}|{d}]\n";
        grid += $"[{z}|{x}|{c}]\n";
        Console.WriteLine($"{grid}");
    }


}

class Program
{
    static void Main(string[] args)
    {
        Grid.PrintGrid("x");

        Console.WriteLine($"il valore di grid salvato e': {Grid.q}");
        
        // itero la cosa fino a quando non arrivo a 9 mosse
        // recupero la posizione mappata del giocatore 1

        // recupero la posizione mappata del giocatore 2
        // ad ogni mossa controllo se ci sta vincita
    }



    /// <summary>
    /// <c>
    /// <para>q w e (00) (01) (02)</para>
    /// <para>a s d (10) (11) (12)</para>
    /// <para>z x c (20) (21) (22)</para>
    /// <para>Usage: PositionGrid('w') --> (01)</para></c>
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    static int[] PositionGrid(char key)
    {
        return null;
    }

    /// <summary>
    /// possible wins pos (00)
    /// 
    /// <c>
    /// <para>|x| | | ___ |x|x|x| ___ |x| | | ___ |x| | |</para>
    /// <para>| | | | ___ | | | | ___ |x| | | ___ | |x| |</para>
    /// <para>| | | | ___ | | | | ___ |x| | | ___ | | |x|</para>
    /// </c>
    /// possible wins pos (01)
    /// <c>
    /// <para>| |x| | ___ |x|x|x| ___ | |x| |</para>
    /// <para>| | | | ___ | | | | ___ | |x| |</para>
    /// <para>| | | | ___ | | | | ___ | |x| |</para>
    /// </c>
    /// possible wins pos (02)
    /// <c>
    /// <para>| | |x| ___ |x|x|x| ___ | | |x| ___ | | |x|</para>
    /// <para>| | | | ___ | | | | ___ | |x| | ___ | | |x|</para>
    /// <para>| | | | ___ | | | | ___ |x| | | ___ | | |x|</para>
    /// </c>
    /// possible wins pos (10)
    /// <c>
    /// <para>| | | | ___ |x| | | ___ | | | |</para>
    /// <para>|x| | | ___ |x| | | ___ |x|x|x|</para>
    /// <para>| | | | ___ |x| | | ___ | | | |</para>
    /// </c>
    /// possible wins pos (11)
    /// <c>
    /// <para>| | | | ___ | | | | ___ | |x| | ___ | | |x| ___ |x| | |</para>
    /// <para>| |x| | ___ |x|x|x| ___ | |x| | ___ | |x| | ___ | |x| |</para>
    /// <para>| | | | ___ | | | | ___ | |x| | ___ |x| | | ___ | | |x|</para>
    /// </c>
    /// possible wins pos (12)
    /// <c>
    /// <para>| | | | ___ | | |x| ___ | | | |</para>
    /// <para>| | |x| ___ | | |x| ___ |x|x|x|</para>
    /// <para>| | | | ___ | | |x| ___ | | | |</para>
    /// </c>
    /// possible wins pos (20)
    /// <c>
    /// <para>| | | | ___ |x| | | ___ | | | | ___ | | |x|</para>
    /// <para>| | | | ___ |x| | | ___ | | | | ___ | |x| |</para>
    /// <para>|x| | | ___ |x| | | ___ |x|x|x| ___ |x| | |</para>
    /// </c>
    /// possible wins pos (21)
    /// <c>
    /// <para>| | | | ___ | |x| | ___ | | | |</para>
    /// <para>| | | | ___ | |x| | ___ | | | |</para>
    /// <para>| |x| | ___ | |x| | ___ |x|x|x|</para>
    /// </c>
    /// possible wins pos (22)
    /// <c>
    /// <para>| | | | ___ | | |x| ___ | | | | ___ |x| | |</para>
    /// <para>| | | | ___ | | |x| ___ | | | | ___ | |x| |</para>
    /// <para>| | |x| ___ | | |x| ___ |x|x|x| ___ | | |x|</para>
    /// </c>
    /// </summary>
    /// <returns></returns>
    static bool checkWin(int[] posizione, string player)
    {
        return true;
    }



}
