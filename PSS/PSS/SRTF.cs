using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    class SRTF : SchedulingAlgorithm
    {
  
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
