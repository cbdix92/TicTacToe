using System;
using System.Diagnostics;
using System.Threading;

namespace Common
{
    class SpeedController
    {
        private Stopwatch timer;
        private int updateCounter = 0;
        private int pauseForMilliseconds = 100;

        public SpeedController()
        {
            timer = new Stopwatch();
            timer.Start();

        }

        public void Wait(int refreshPerSecond)
        {
            // increment update counter
            updateCounter++;

            // Pause the loop 
            Thread.Sleep(pauseForMilliseconds);

            // Check if one second has passed
            if (timer.ElapsedMilliseconds >= 1000)
            {
                // Reset the timer
                timer.Reset();
                timer.Start();

                // Adjust refresh rate
                if (updateCounter > refreshPerSecond)
                {
                    pauseForMilliseconds += 1;
                }
                else
                {
                    pauseForMilliseconds -= 1;
                }
                updateCounter = 0;
            }
        }
    }
}