using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    /// <summary>
    /// Shortest Remaining Time First (SRTF)
    /// </summary>
    public class SRTF : SchedulingAlgorithm
    {

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

            PCB shortest = Pool.Where(x => x.State != PCB.ProcessState.DEAD && x.State != PCB.ProcessState.WAITING)
                    .OrderBy(x => x.Process.Length - x.Process.Progress).FirstOrDefault();

            if (current != shortest)
            {
                current = shortest;
            }
        }
    }
}
