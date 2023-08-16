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


        do
        {
            var usersInput = GetUserInput();

            if (usersInput?.Length == 2 && int.TryParse(usersInput[0], out int x) && int.TryParse(usersInput[1], out int y))
            {
                
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



}


