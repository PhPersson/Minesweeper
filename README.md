
# Minesweeper Game :bomb: :video_game:
This is a simple console-based implementation of the classic game Minesweeper written in C#. The game creates a minefield grid and allows players to uncover cells while avoiding hidden bombs.

## How to Play
1. Run the program.
2. The game will generate a 5x5 minefield grid and place bombs on it.
3. The minefield will be displayed with rows and columns labeled.
4. Enter your moves by providing coordinates in the format "X Y", where X is the column number and Y is the row number. For example, "2 3" represents the cell at column 2, row 3.
- If you uncover a cell with a bomb, the game ends.
- If you uncover a cell without a bomb, the cell will show the number of neighboring bombs, or be blank if no neighboring bombs are present.
5. Continue making moves until you uncover all safe cells or hit a bomb.

## Game Controls
* To make a move, enter the coordinates of the cell you want to uncover in the format "X Y".
* The game will inform you if your input is invalid or if you've already uncovered a particular cell.

## Symbols Used
* X: Represents a bomb.
* ?: Represents a covered cell.
* 1, 2, 3, etc.: Represents the number of neighboring bombs when the cell is uncovered.

## Implementation Details
The game is implemented in a simple console application using C#. The minefield is represented by a grid, and bombs are placed  on the grid. The game logic ensures that you can uncover cells and keep track of uncovered and bomb cells. The program provides basic error checking and input validation.