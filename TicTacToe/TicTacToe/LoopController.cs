using System;
using System.Diagnostics;
using System.Threading;

namespace Common
{
    class LoopController
    {
        private Stopwatch timer;
        private int actualLoopsPerSecond = 0;
        private int pauseForMilliseconds = 100;

        public SpeedController()
        {
            timer = new Stopwatch();
            timer.Start();
        }

        public void Wait(int targetLoopsPerSecond)
        {
            // increment update counter
            actualLoopsPerSecond++;

            // Pause the loop
            Thread.Sleep(pauseForMilliseconds);

            // Check if one second has passed
            if (timer.ElapsedMilliseconds >= 1000)
            {
                // Reset the timer
                timer.Reset();
                timer.Start();

                // Adjust refresh rate
                if (actualLoopsPerSecond > targetLoopsPerSecond)
                {
                    pauseForMilliseconds += 1;
                }
                else
                {
                    pauseForMilliseconds -= 1;
                }
                actualLoopsPerSecond = 0;
            }
        }
    }
}
