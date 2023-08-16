namespace Minesweeper;

public class Minefield
{

    public int Rows { get; }
    public int Columns { get; }
    private bool[,] _bombLocations = new bool[5, 5];
    private bool[,] _uncoveredCell = new bool[5, 5];

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
        return _uncoveredCell[row, col];
    }

}
