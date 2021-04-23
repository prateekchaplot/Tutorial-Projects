using Sudoku_Solver.Data;

namespace Sudoku_Solver.Workers
{
    class SudokuMapper
    {
        public SudokuMap Find(int givenRow, int givenCol)
        {
            SudokuMap sudokuMap = new SudokuMap();

            // Set start row
            if (givenRow >= 0 && givenRow <= 2)
            {
                sudokuMap.StartRow = 0;
            }
            else if (givenRow >= 3 && givenRow <= 5)
            {
                sudokuMap.StartRow = 3;
            }
            else if (givenRow >= 6 && givenRow <= 8)
            {
                sudokuMap.StartRow = 6;
            }

            // Set start col
            if (givenCol >= 0 && givenCol <= 2)
            {
                sudokuMap.StartCol = 0;
            }
            else if (givenCol >= 3 && givenCol <= 5)
            {
                sudokuMap.StartCol = 3;
            }
            else if (givenCol >= 6 && givenCol <= 8)
            {
                sudokuMap.StartCol = 6;
            }

            return sudokuMap;
        }
    }
}