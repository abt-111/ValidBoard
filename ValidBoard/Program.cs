internal class Program
{
    private static void Main(string[] args)
    {
        bool isValid = true;
        string cumuleur, valeurCourante;
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
        // Valide
        /*board =
        [
            ["5","3",".",".","7",".",".",".","."]
            ["6",".",".","1","9","5",".",".","."]
            [".","9","8",".",".",".",".","6","."]
            ["8",".",".",".","6",".",".",".","3"]
            ["4",".",".","8",".","3",".",".","1"]
            ["7",".",".",".","2",".",".",".","6"]
            [".","6",".",".",".",".","2","8","."]
            [".",".",".","4","1","9",".",".","5"]
            [".",".",".",".","8",".",".","7","9"]
        ];*/


        // Vérification des lignes horizontales
        /*for(int i = 0; i < board.Length && isValid; i++)
        {
            cumuleur = "";
            for (int j = 0; j < board[0].Length && isValid; j++)
            {
                // Il y a moyen de faire le deux en un je crois
                if (cumuleur.Contains(board[i][j]) && board[i][j] != ".")
                {
                    isValid = false;
                }
                else
                {
                    cumuleur += board[i][j];
                }
            }
        }*/

        // Vérification des lignes verticale
        /*for (int i = 0; i < board[0].Length && isValid; i++)
        {
            cumuleur = "";
            for (int j = 0; j < board.Length && isValid; j++)
            {
                if (cumuleur.Contains(board[j][i]) && board[j][i] != ".")
                {
                    isValid = false;
                }
                else
                {
                    cumuleur += board[j][i];
                }
            }
        }*/

        // Vérification de chaque "case" 3x3
        for (int i = 0; i < board[0].Length && isValid; i++)
        {
            cumuleur = "";
            for (int j = 0; j < board.Length && isValid; j++)
            {
                valeurCourante = board
                                [(3 * (i / 3)) + (j / 3)]
                                [(3 * (i % 3)) + (j % 3)];

                if (cumuleur.Contains(valeurCourante) && valeurCourante != ".")
                {
                    isValid = false;
                }
                else
                {
                    cumuleur += valeurCourante;
                }
            }
        }

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
            Console.WriteLine("Bravo");
        }
        else
        {
            Console.WriteLine("Bof");
        }
    }
}