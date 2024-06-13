internal class Program
{
    private static void Main(string[] args)
    {
        bool isValid = true;
        string cumuleur;
        string[][] board = 
        [
                ["8","3",".",   ".","7",".",    ".",".","."],
                ["6",".",".",   "1","9","5",    ".",".","."],
                [".","9",".",   ".",".",".",    ".","6","."],

                [".",".",".",   ".","6",".",    ".",".","3"],
                ["4",".",".",   "8",".","3",    ".",".","1"],
                ["7",".",".",   ".","2",".",    ".",".","6"],

                [".","6",".",   ".",".",".",    "2","8","."],
                [".",".",".",   "4","1","9",    ".",".","5"],
                [".",".",".",   ".","8",".",    ".","7","9"]
        ];

        // Vérification des lignes horizontales
        for (int i = 0; i < board.Length && isValid; i++)
        {
            cumuleur = "";
            for (int j = 0; j < board[0].Length && isValid; j++)
            {
                isValid = Verification(board[i][j], ref cumuleur, isValid);
            }
        }

        // Vérification des lignes verticale
        for (int i = 0; i < board.Length && isValid; i++)
        {
            cumuleur = "";
            for (int j = 0; j < board[0].Length && isValid; j++)
            {
                isValid = Verification(board[j][i], ref cumuleur, isValid);
            }
        }

        // Vérification de chaque "case" 3x3
        for (int i = 0; i < board.Length && isValid; i++)
        {
            cumuleur = "";
            for (int j = 0; j < board[0].Length && isValid; j++)
            {
                isValid = Verification(board[(3 * (i / 3)) + (j / 3)][(3 * (i % 3)) + (j % 3)], ref cumuleur, isValid);
            }
        }

        // Liste des index pour les case 3x3
        /*for (int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++)
            {
                Console.Write(((3 * (i / 3)) + (j / 3)) + " " + ((3 * (i % 3)) + (j % 3)) + " ");
                if(j % 3 == 2)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }*/

        if (isValid)
        {
            Console.WriteLine("Valide");
        }
        else
        {
            Console.WriteLine("Invalide");
        }
    }
    public static bool Verification(string valeurCourante, ref string cumuleur, bool isValid)
    {
        if (cumuleur.Contains(valeurCourante) && valeurCourante != ".")
        {
            isValid = false;
        }
        else
        {
            cumuleur += valeurCourante;
        }
        return isValid;
    }
}