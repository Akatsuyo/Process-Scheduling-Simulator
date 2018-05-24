using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    /// <summary>
    /// Highest Response Ratio Next (HRRN) In this scheduling, processes with highest response ratio is scheduled
    /// </summary>
    public class SJF : SchedulingAlgorithm
    {
        /// <summary>
        /// Constructor of the algorithm
        /// </summary>
        public SJF()
        {
            desc = "Process which have the shortest burst time are scheduled first.";
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

            PCB shortest = null;
            double minLength = int.MaxValue;

            foreach (var pcb in Pool)
            {
                //calculate Response Ratio
                if (pcb.State != PCB.ProcessState.WAITING && pcb.State != PCB.ProcessState.DEAD && pcb.Process.Length < minLength)
                {
                    //set shortest
                    shortest = pcb;
                    //set min burst time
                    minLength = pcb.Process.Length;
                }
                
            }
            if (current != shortest)
            {
                current = shortest;
            }
        }
    }
}
