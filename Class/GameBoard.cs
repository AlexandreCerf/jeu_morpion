using System;
using Jeu_Morpion.Interfaces;

public class Board : IWrite
{
    private char[,] grid;


    public Board()
    {
        grid = new char[3, 3]
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };
    }

    public void Display()
    {
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            DisplayRow(i);
            if (i < 2) DisplaySeparator();
        }
    }

    private void DisplayRow(int row)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write($" {grid[row, j]} ");
            if (j < 2) Console.Write("|");
        }
        Console.WriteLine();
    }

    private void DisplaySeparator()
    {
        Console.WriteLine("---+---+---");
    }

    public bool PlayMove(string choice, char playerSymbol)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (grid[i, j].ToString() == choice)
                {
                    grid[i, j] = playerSymbol;
                    return true;
                }
            }
        }
        return false;
    }

    public bool CheckWinner(char playerSymbol)
    {
        for (int i = 0; i < 3; i++)
        {
            if (IsEqual(playerSymbol, grid[i, 0], grid[i, 1], grid[i, 2]) ||
            IsEqual(playerSymbol, grid[0, i], grid[1, i], grid[2, i]))
            {
                return true;
            }
        }

        if(IsEqual(playerSymbol, grid[0, 0], grid[1, 1], grid[2, 2]) ||
        IsEqual(playerSymbol, grid[0, 2], grid[1, 1], grid[2, 0]))
            {
            return true;
        }

        return false;
    }

    private bool IsEqual(char playerSymbol, char char1, char char2, char char3)
    {
        return char1 == playerSymbol && char2 == playerSymbol && char3 == playerSymbol;

    }

    public bool IsFull()
    {
        foreach (char cell in grid)
        {
            if (char.IsDigit(cell)) return false;
        }
        return true;
    }
}
