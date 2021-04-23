using System;

namespace Sudoku_Solver.Workers
{
    class SudokuBoardDisplayer
    {
        public void Display(string title, int[,] sudokuBoard)
        {
            if (!title.Equals(string.Empty)) Console.WriteLine("{0}\n", title);

            for (int row = 0; row < sudokuBoard.GetLength(0); row++)
            {
                Console.Write("|");
                for (int col = 0; col < sudokuBoard.GetLength(1); col++)
                {
                    Console.Write("{0}{1}", sudokuBoard[row, col], "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}