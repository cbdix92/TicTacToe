using System;
using Common;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            RenderEngine.SetScreenSize(20);

            Board board = new Board();
            Player playerOne = new Player();
            Player playerTwo = new Player();
            WinLose winlose = new WinLose();
            LoopController LoopController = new LoopController();
            KeyHandler keyHandler = new KeyHandler();

            while (winlose.Check(board))
            {
                // Clear the screen
                Console.Clear();

                // Render the screen
                RenderEngine.FillScreen();
                RenderEngine.Draw();

                // Get player Input
                keyHandler.Input();
                keyHandler.Update(board);


                // Slow GameLoop
                speedController.Wait(10);
            }
        }
    }
}
