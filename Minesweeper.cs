namespace Minesweeper;

public static class Minesweeper
{
    static void Main()
    {
        var field = new Minefield(5, 5);
        bool gameOver = false;

        //set the bombs...
        field.SetBomb(0, 0);
        field.SetBomb(0, 1);
        field.SetBomb(1, 1);
        field.SetBomb(1, 4);
        field.SetBomb(4, 2);

        //the mine field should look like this now:
        //  01234
        //4|1X1
        //3|11111
        //2|2211X
        //1|XX111
        //0|X31

        // Game code...

        Console.WriteLine("Minefield:");
        PrintBoard(field);

        do
        {
            var usersInput = GetUserInput();

            if (usersInput?.Length == 2 && int.TryParse(usersInput[0], out int row) && int.TryParse(usersInput[1], out int col))
            {
                if (field.IsInsideGameGrid(row, col))

                {
                    if (field.IsBomb(row, col))
                    {
                        PrintBoard(field);
                        Console.WriteLine("You hit a bomb, game over");
                        gameOver = true;
                    }
                    else if (!field.IsUncovered(row, col))
                    {
                        field.UncoverCell(row, col);
                        PrintBoard(field);
                    }
                    else
                    {
                        Console.WriteLine("This cell is already uncovered.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid row or column.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

        }
        while (!gameOver);
    }

    public static string[] GetUserInput()
    {
        Console.WriteLine("Your move: (X Y)");
        string[] input = Console.ReadLine().Split(' ');
        return input;
    }


    private static void PrintBoard(Minefield field)
    {

        Console.Write("  ");
        for (int i = 0; i < field.Rows; i++)
        {
            Console.Write(i);
        }
        Console.WriteLine();



        for (int i = field.Columns - 1; i >= 0; i--)
        {
            Console.Write(i + "|");

            for (int j = 0; j < field.Columns; j++)
            {
                if (field.IsUncovered(j, i))
                {
                    if (field.IsBomb(j, i))
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        // Cell doesn't contain a bomb, display the count of neighboring bombs.
                        int neighboringBombs = field.CountNeighborBombs(j, i);
                        if (neighboringBombs != 0)
                        {
                            Console.Write(neighboringBombs);
                        }
                    }
                }
                else
                {
                    Console.Write("?");
                }
            }
            Console.WriteLine();
        }

    }

}
