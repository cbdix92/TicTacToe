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
          { this.SetScreenSize(defaultScreeSize); }
          for (int Row = 0; Row < screen.Length; Row++)
          {
            for (int Col = 0; Col < screen[Row].Length; Col++)
            {
              Console.Write(Screen[Row][Col]);
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
          if (screen == null) { this.SetScreenSize(defaultScreeSize); }

          foreach (char[,] arrayItem in BufferFill)
          {
            for (int Row = 0; Row < arrayItem.Length; Row++)
            {
              for (int Col = 0; Col < arrayItem[Row].Length; Col++)
              {
                screen[Row][Col] = arrayItem[Row][Col];
              }
            }
          }
        }

    }
}
