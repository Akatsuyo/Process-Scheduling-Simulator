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

        public FIFO()
        {
            rQueue = new Queue<PCB>();
        }

        public override void Work()
        {
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

        public override void Reset()
        {
            base.Reset();
            rQueue.Clear();
        }
    }
}
