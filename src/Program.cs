namespace src;

class Program
{
    static void Main(string[] args)
    {
        int [,] matrice3x3 = {{1, 2, 3},
                              {1, 2, 3},
                              {1, 2, 3}};
        int colonna = -1;
        int righe = 0;
        for (int i = 0; i < 9; i++) // 3 x 3 = 9
        {
            // example: (3%3 = 0), 0, 1, 2 (6%3 = 0), 0, 1, 2 (9%3 = 0), 0, 1, 2
            // every module 3 i increment the column and do carriage return
            if (i % 3 == 0 && colonna < 2)
            {
                colonna ++;
                Console.WriteLine($"");
            }
            righe = i % 3; // 1, 2, 3 // row iteration
            Console.Write($"{matrice3x3[colonna, righe]}");
        }
    }
}
