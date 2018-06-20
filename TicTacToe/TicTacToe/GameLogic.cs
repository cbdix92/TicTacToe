using System;
using System.Diagnostics;
using System.Threading;

namespace Common
{
    public enum State { None, X, Y, Cursor };

    public class Board
    {

        // Current players turn
        public State playerTurn { get; set; } = State.X;

        // TicTacToe Board full of empty space
        public State[,] board = new State[3, 3];


        public char GetState(Position position)
        {
            // Return char element of specified board position
            if (board[position.Row, position.Col] == State.X) return 'X';
            if (board[position.Row, position.Col] == State.Y) return 'Y';
            else return ' ';
        }

        public bool SetState(Position position, State state)
        {
            if (state == State.None) { return false; }
            else if (state != State.None)
            {
                board[position.Row, position.Col] = state;
                return true;
            }
            return false;
        }
    }



    public class Player
    {

    }

    public class WinLose
    {
        public bool Check(Board board)
        {
            return true;
        }
    }

    public class Position
    {
        public int Row { get; }
        public int Col { get; }

        public Position(int row, int col)
        {
            Row = row;
            Col = col;
        }
    }
}