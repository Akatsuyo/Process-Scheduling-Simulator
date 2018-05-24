using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    /// <summary>
    /// FIFO (First In First Out) Scheduling Algorithm
    /// </summary>
    public class FIFO : SchedulingAlgorithm
    {
        Queue<PCB> rQueue;

        /// <summary>
        /// Constructor of the algorithm
        /// </summary>
        public FIFO()
        {
            rQueue = new Queue<PCB>();
        }

        /// <summary>
        /// Returns the algorithm settings of the algorithm
        /// </summary>
        /// <returns>Algorithm settings</returns>
        public override AlgorithmSettings GetAlgorithmSettings()
        {
            return null;
        }

        /// <summary>
        /// This is where the algorithm works (does its job)
        /// </summary>
        public override void Work()
        {
            if (!ready)
                return;

            // Enqueue
            foreach (var pcb in Pool)
            {
                if (pcb.State == PCB.ProcessState.NEW || pcb.State == PCB.ProcessState.READY)
                {
                    if (!rQueue.Contains(pcb))
                    {
                        rQueue.Enqueue(pcb);
                    }
                }
            }

            // Swap
            if (current != null)
            {
                if (current.State == PCB.ProcessState.WAITING || current.State == PCB.ProcessState.DEAD)
                {
                    current = null;
                }  
            } 
            else if (rQueue.Count > 0)
            {
                current = rQueue.Dequeue();
            }
        }

        /// <summary>
        /// Clears the algorithm, resets it to defaults
        /// </summary>
        public override void Reset()
        {
            base.Reset();
            rQueue.Clear();
        }
    }
}
