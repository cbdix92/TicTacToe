using System;

namespace Common
{
    static class RenderEngine
    {
        public static char[] Buffer;

        public static void Draw()
        {
            foreach (char Item in Buffer)
            {
                Console.Write(Item);
            }
        }

        public static void SetBufferSize(int newBufferSize)
        {
            Buffer = new char[newBufferSize];
        }

        public static void RasterizeBuffer(char[] BufferFill)
        {
            foreach (char Item in BufferFill)
            {

            }
        }
    }
}