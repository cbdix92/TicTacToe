using System;

namespace Common
{
    static class RenderEngine
    {
        public static char[,] screen;

        // Default size of the screen if the SetScreenMethod is never called prior to Draw Method
        private static int defaultScreeSize = 6;

        public static void Draw()
        {
          // Check if screen size was ever set. If not, use default size
          if (screen == null)
          { SetScreenSize(defaultScreeSize); }
          for (int Row = 0; Row < screen.Length; Row++)
          {
            for (int Col = 0; Col < screen.GetLength(0); Col++)
            {
              Console.Write(screen[Row, Col]);
            }
            Console.WriteLine();
          }
        }

        public static void SetScreenSize(int newScreenSize)
        {
          if (screen == null)
          {
            screen = new char[newScreenSize, newScreenSize];
          }
        }

        public static void FillScreen([]char[,] BufferFill)
        {
          if (screen == null) { SetScreenSize(defaultScreeSize); }

          foreach (char[,] arrayItem in BufferFill)
          {
            for (int Row = 0; Row < arrayItem.Length; Row++)
            {
              for (int Col = 0; Col < arrayItem.GetLength(0); Col++)
              {
                screen[Row, Col] = arrayItem[Row, Col];
              }
            }
          }
        }

    }
}
