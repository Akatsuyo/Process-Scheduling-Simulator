using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    class RoundRobin : SchedulingAlgorithm
    {
        int currentIndex;
        int qTicks;
        int tickCounter;

        public RoundRobin(int qt)
        {
            currentIndex = 0;
            qTicks = qt;
            tickCounter = 0;
        }

        public override void Work()
        {
            if (!ready)
                return;

            // Swap
            if (current != null)
            {
                if (current.State == PCB.ProcessState.WAITING || 
                    current.State == PCB.ProcessState.DEAD || 
                    tickCounter >= qTicks)
                {
                    current = null;
                    tickCounter = 0;
                }
                else
                {
                    tickCounter++;
                }
            }
            else
            {
                int counter = Pool.Count;
                while (counter > 0)
                {
                    if (Pool[currentIndex].State == PCB.ProcessState.NEW || Pool[currentIndex].State == PCB.ProcessState.READY)
                    {
                        current = Pool[currentIndex];
                        NextIndex();
                        break;
                    }
                    else
                    {
                        NextIndex();
                    }

                    counter--;
                }
            }
        }

        public override void Reset()
        {
            base.Reset();
            currentIndex = 0;
            tickCounter = 0;
        }

        private void NextIndex()
        {
            if (++currentIndex == Pool.Count)
            {
                currentIndex = 0;
            }
        }
    }
}
