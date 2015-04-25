using System;

namespace NoughtsAndCrosses
{
    public class Game
    {
        public Game() { }
        public Game(CellContent startingPlayer)
        {
            currentPlayer = startingPlayer;
        }

        public enum CellContent
        {
            Empty, O, X
        }
        CellContent[,] board = new CellContent[3, 3];
        CellContent currentPlayer = CellContent.X;

        public int NumberOfRows { get { return board.GetLength(0); } }
        public int NumberOfColumns { get { return board.GetLength(1); } }
        public CellContent CurrentPlayer { get { return currentPlayer; } }
        public CellContent NextPlayer { get { return currentPlayer == CellContent.O ? CellContent.X : CellContent.O; } }

        public void Move(CellContent player, int row, int column)
        {
            if (board[row, column] != CellContent.Empty)
                throw new ApplicationException("Cell is not empty");
            else if (player != currentPlayer)
                throw new ApplicationException("Not player's turn");
            else
            {
                board[row, column] = player;
                currentPlayer = NextPlayer;
            }
        }

        public CellContent Winner
        {
            get
            {
                #region Horizontal Win
                for (int row = 0; row < NumberOfRows; row++)
                    for (int column = 0; column < NumberOfColumns - 2; column++)
                    {
                        if (board[row, column] != CellContent.Empty
                            && board[row, column] == board[row, column + 1]
                            && board[row, column] == board[row, column + 2])
                            return board[row, column];
                    }
                #endregion
                #region Vertical Win
                for (int column = 0; column < NumberOfColumns; column++)
                    for (int row = 0; row < NumberOfRows - 2; row++)
                    {
                        if (board[row, column] != CellContent.Empty
                            && board[row, column] == board[row + 1, column]
                            && board[row, column] == board[row + 2, column])
                            return board[row, column];
                    }
                #endregion
                #region Diagonal
                for (int row = 0; row < NumberOfRows - 2; row++)
                    for (int column = 0; column < NumberOfColumns - 2; column++)
                    {
                        if (board[row, column] != CellContent.Empty
                            && board[row, column] == board[row + 1, column + 1]
                            && board[row, column] == board[row + 2, column + 2])
                            return board[row, column];
                    }
                #endregion
                #region Diagonal
                for (int row = 2; row < NumberOfRows; row++)
                    for (int column = 0; column < NumberOfColumns - 2; column++)
                    {
                        if (board[row, column] != CellContent.Empty
                            && board[row, column] == board[row - 1, column + 1]
                            && board[row, column] == board[row - 2, column + 2])
                            return board[row, column];
                    }
                #endregion
                return CellContent.Empty;
            }
        }
    }
}
