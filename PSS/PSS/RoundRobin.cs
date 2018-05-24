using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    /// <summary>
    /// Round Robin
    /// </summary>
    public class RoundRobin : SchedulingAlgorithm
    {
        int currentIndex;
        int qTicks;
        int tickCounter;

        /// <summary>
        /// Constructor of the algorithm
        /// </summary>
        public RoundRobin()
        {
            currentIndex = 0;
            qTicks = 10;
            tickCounter = 0;
        }

        /// <summary>
        /// Returns the algorithm settings of the algorithm
        /// </summary>
        /// <returns>Algorithm settings</returns>
        public override AlgorithmSettings GetAlgorithmSettings()
        {
            return new AlgorithmSettings(new AlgorithmSettings.ISetting[]{
                new AlgorithmSettings.RangeSetting("QT", "Quantum Time", 1, 10, 1, 3, SetQT)
            });
        }

        /// <summary>
        /// Sets the Quantum Time of the algorithm
        /// </summary>
        /// <param name="qTicks"></param>
        public void SetQT(string qTicks)
        {
            this.qTicks = Int32.Parse(qTicks);
        }

        /// <summary>
        /// This is where the algorithm works (does its job)
        /// </summary>
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
            
            if (current == null)
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

        /// <summary>
        /// Clears the algorithm, resets it to defaults
        /// </summary>
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
