using System;
using Sudoku_Solver.Strategies;
using Sudoku_Solver.Workers;

namespace Sudoku_Solver
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SudokuMapper sudokuMapper = new SudokuMapper();
                SudokuBoardStateManager sudokuBoardStateManager = new SudokuBoardStateManager();
                SudokuSolverEngine sudokuSolverEngine = new SudokuSolverEngine(sudokuBoardStateManager, sudokuMapper);
                SudokuFileReader sudokuFileReader = new SudokuFileReader();
                SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();

                Console.WriteLine("Please enter the filename containing the Sudoku puzzle: ");
                var filename = "SudokuEasy.txt";//Console.ReadLine();

                var sudokuBoard = sudokuFileReader.ReadFile(filename);
                sudokuBoardDisplayer.Display("Initial State", sudokuBoard);

                bool isSudokuSolved = sudokuSolverEngine.Solve(sudokuBoard);
                sudokuBoardDisplayer.Display("Final State", sudokuBoard);

                Console.WriteLine(isSudokuSolved ?
                    "You have successfully solved this Sudoku Puzzle!" :
                    "Unfortunately, current algorithm(s) were not enough to solve the current Sudoku Puzzle");
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} {1}", "Sudoku puzzle can't be solved because there was an error:", ex.Message);
            }
        }
    }
}
