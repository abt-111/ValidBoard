﻿internal class Program
{
    private static void Main(string[] args)
    {
        bool isValid = true;
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

        for(int i = 0; i < board.Length && isValid; i++)
        {
            // Ici on fournit le numéro de la ligne à valider
            isValid = ValidateHorizontal(board, i);
            // Ici on fournit le numéro de la colonne à valider
            isValid = ValidateVertical(board, i);
            // Ici on fournit le numéro de la ligne et de la colone à valider
            isValid = Validate3x3Grid(board, 3 * (i / 3), 3 * (i % 3));
        }

        if(isValid)
        {
            Console.WriteLine("Valide");
        }
        else
        {
            Console.WriteLine("Invalide");
        }
    }

    public static bool Validate(string valeurCourante, ref string alreadyIn)
    {
        if (alreadyIn.Contains(valeurCourante) && valeurCourante != ".")
        {
            return false;
        }
        else
        {
            alreadyIn += valeurCourante;
        }
        return true;
    }

    public static bool ValidateHorizontal(string[][] board, int i)
    {
        bool isValid = true;
        // Variables pour accumuler les valeurs déjà présentes
        string alreadyInHorizontal;

        alreadyInHorizontal = "";

        for (int index = 0; index < board[0].Length && isValid; index++)
        {
            isValid = Validate(board[i][index], ref alreadyInHorizontal);
        }
        return isValid;
    }

    public static bool ValidateVertical(string[][] board, int j)
    {
        bool isValid = true;
        // Variables pour accumuler les valeurs déjà présentes
        string alreadyInVertical;

        alreadyInVertical = "";

        for (int index = 0; index < board[0].Length && isValid; index++)
        {
            isValid = Validate(board[index][j], ref alreadyInVertical);
        }
        return (isValid);
    }

    public static int GetGridNuber(int i, int j)
    {
        // Numééro de grille
        //  0   1   2
        //  3   4   5
        //  6   7   8

        return (3 * (i / 3)) + (j / 3);
    }
    public static bool Validate3x3Grid(string[][] board, int i, int j)
    {
        bool isValid = true;

        int gridNumber = GetGridNuber(i, j);

        // Variables pour accumuler les valeurs déjà présentes
        string alreadyIn3x3Grid;

        alreadyIn3x3Grid = "";

        for (int index = 0; index < board[0].Length && isValid; index++)
        {
            isValid = Validate(board[(3 * (gridNumber / 3)) + (index / 3)][(3 * (gridNumber % 3)) + (index % 3)], ref alreadyIn3x3Grid);
        }
        return isValid;
    }
}