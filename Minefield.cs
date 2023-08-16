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

}
