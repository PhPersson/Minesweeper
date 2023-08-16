using System.Runtime.CompilerServices;

namespace Minesweeper;

public class Minefield
{

    public int Rows { get; }
    public int Columns { get; }
    private bool[,] _bombLocations = new bool[5, 5];
    private bool[,] _uncoveredCells = new bool[5, 5];

    public Minefield(int rows, int cols)
    {
        Rows = rows;
        Columns = cols;
    }


    public void SetBomb(int x, int y)
    {
        _bombLocations[x, y] = true;
    }

    internal bool IsBomb(int row, int col)
    {
        return _bombLocations[row, col];
    }

    internal bool IsUncovered(int row, int col)
    {
        return _uncoveredCells[row, col];
    }

    internal bool IsInsideGameGrid(int row, int col)
    {
        // Check if the given row and column are within the grid.
        return row >= 0 && row < Rows && col >= 0 && col < Columns;
    }

    public void UncoverCell(int row, int col)
    {
        if (!_uncoveredCells[row, col])
        {
            _uncoveredCells[row, col] = true;
        }
    }


}
