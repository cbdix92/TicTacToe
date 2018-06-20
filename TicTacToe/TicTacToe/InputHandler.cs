using System;

namespace Common
{
    class KeyBuffer
    {
        public ConsoleKeyInfo EMPTY;
        private ConsoleKeyInfo[] buffer;
        private ConsoleKeyInfo temp;
        private int source = 0;
        private int queue = 0;

        public KeyBuffer(int size)
        {
            // Set the size of the buffer at init
            buffer = new ConsoleKeyInfo[size];

            // Fill the buffer with EMPTY objects
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = EMPTY;
            }
        }

        public bool Insert(ConsoleKeyInfo item)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                if (buffer[i] == EMPTY)
                {
                    buffer[i] = item;
                    return true;
                }
            }
            return false;
        }

        public ConsoleKeyInfo Pop()
        {
            // Check buffer[queue] and up for value to return
            for (int i = queue; i < buffer.Length; i++)
            {
                if (buffer[i] != EMPTY)
                {
                    temp = buffer[i];
                    buffer[i] = EMPTY;
                    queue = i++;
                    if (queue == buffer.Length) { queue = 0; }
                    return temp;
                }
            }
            // Check buffer[queue] and down to 0 for value to return
            for (int i = 0; i < queue; i++)
            {
                if (buffer[i] != EMPTY)
                {
                    temp = buffer[i];
                    buffer[i] = EMPTY;
                    queue = i++;
                    if (queue == buffer.Length) { queue = 0; }
                    return temp;
                }
            }
            return EMPTY;

        }
    }



    class KeyHandler
    {
        KeyBuffer keyBuffer = new KeyBuffer(3);
        ConsoleKeyInfo currentKey;
        ConsoleKeyInfo nextKeyInQueue;

        public void Input()
        {
            // Get user key input
            try
            {
                currentKey = Console.ReadKey(true);
                keyBuffer.Insert(currentKey);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e);
            }
        }

        public void Update(Board board)
        {
            nextKeyInQueue = keyBuffer.Pop();

            if (nextKeyInQueue.KeyChar == '2')
            {
                Console.WriteLine("Two");
            }
            else if (nextKeyInQueue.KeyChar == '4')
            {
                Console.WriteLine("Four");
            }
            else if (nextKeyInQueue.KeyChar == '6')
            {
                Console.WriteLine("Six");
            }
            else if (nextKeyInQueue.KeyChar == '8')
            {
                Console.WriteLine("Eight");
            }
            else if (nextKeyInQueue.KeyChar == ' ')
            {
                Console.WriteLine("Space");
            }
        }
    }
}
