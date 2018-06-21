using System;
using System.Diagnostics;
using System.Threading;

namespace Common
{
    public enum State { None, X, Y , Cursor};

    public class Board
    {

        // Current players turn
        public State playerTurn { get; set; } = State.X;

        // TicTacToe Board full of empty space
        public Sprite[,] board = new Sprite[3, 3];


        public char GetStateChar(Position position)
        {
            // Return char element of specified board position
            if (board[position.Row, position.Col].GetState() == State.X) return 'X';
            if (board[position.Row, position.Col].GetState() == State.Y) return 'Y';
            if (board[position.Row, position.Col].GetState() == State.Cursor) return '#';
            else return ' ';
        }

        public bool SetState(Position position, State state)
        {
            if (state == State.None) { return false; }
            else if (state != State.None)
            {
                board[position.Row, position.Col].SetState(state);
                return true;
            }
            return false;
        }
    }



    public class Player
    {

      public int Score{ get; set; }

    }

    public class Sprite
    {
      State state = State.None;

      // Display the Cursor instead of the Sprite State when "True".
      private bool cursorDisplayFlag = false;
      private State cursor = State.Cursor;

      public bool SetState(State newState)
      {
        // Check if Sprite state has already been set, if not, set it.
        if (state != State.None)
        {
          state = newState;
          return true;
        }
        // Sprite has already been assigned a State
        else { return false; }
      }

      public State GetState()
      {
        if (cursorDisplayFlag)
        {
          return cursor;
        }
        else {return state;}
      }

      public void ToggleCursorDisplayFlag()
      {
        if (cursorDisplayFlag == true) { cursorDisplayFlag = false; }
        else { cursorDisplayFlag = true; }
      }
    }

    public class WinLose
    {
      public bool Check(Board board)
    {
            // Check if a player has won the game
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
