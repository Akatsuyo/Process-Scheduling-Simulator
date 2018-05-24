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
    public class HRRN : SchedulingAlgorithm
    {
        /// <summary>
        /// Constructor of the algorithm
        /// </summary>
        public HRRN()
        {
            desc = "In this scheduling, processes with highest response ratio is scheduled. This algorithm avoids starvation.";
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
            double maxRespRatio=0;

            foreach (var pcb in Pool)
            {
                //calculate Response Ratio
                if (pcb.State != PCB.ProcessState.WAITING && pcb.State != PCB.ProcessState.DEAD && (pcb.Process.WaitTime+pcb.Process.RemainingTick) / pcb.Process.RemainingTick > maxRespRatio)
                {
                    //set shortest
                    shortest = pcb;
                    //set max burst time
                    maxRespRatio = (pcb.Process.RemainingTick + pcb.Process.Progress)/ pcb.Process.RemainingTick;
                }
                
            }
            if (current != shortest)
            {
                current = shortest;
            }
        }
    }
}
