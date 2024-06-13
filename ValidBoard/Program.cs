internal class Program
{
    private static void Main(string[] args)
    {
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

        if (ParcoursEtValidation(board))
        {
            Console.WriteLine("Valide");
        }
        else
        {
            Console.WriteLine("Invalide");
        }
    }
    public static bool Verification(string valeurCourante, ref string cumuleur)
    {
        if (cumuleur.Contains(valeurCourante) && valeurCourante != ".")
        {
            return false;
        }
        else
        {
            cumuleur += valeurCourante;
        }
        return true;
    }

    public static bool ParcoursEtValidation(string[][] board)
    {
        bool isValid1 = true, isValid2 = true, isValid3 = true;
        string cumuleur1, cumuleur2, cumuleur3;

        for (int i = 0; i < board.Length && isValid1 && isValid2 && isValid3; i++)
        {
            cumuleur1 = "";
            cumuleur2 = "";
            cumuleur3 = "";
            for (int j = 0; j < board[0].Length && isValid1 && isValid2 && isValid3; j++)
            {
                isValid1 = Verification(board[i][j], ref cumuleur1);
                isValid2 = Verification(board[j][i], ref cumuleur2);
                isValid3 = Verification(board[(3 * (i / 3)) + (j / 3)][(3 * (i % 3)) + (j % 3)], ref cumuleur3);
            }
        }
        return (isValid1 && isValid2 && isValid3);
    }
}