using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    public class FIFO : IAlgorithm
    {
        private int stepCount;

        public FIFO()
        {
            stepCount = 0;
        }

        public void IssueWork(List<Process> prList, Queue<int> rQueue, CPU cpu)
        {
            // Check for arriving processes
            foreach (var pr in prList)
            {
                if (pr.Arrival == stepCount)
                {
                    // Enqueue process
                    rQueue.Enqueue(pr.ID);
                }
            }

            // If cpu is not working, start next process in queue
            if (!cpu.Working && rQueue.Count > 0)
            {
                int next = rQueue.Dequeue();
                cpu.SetProcess(prList.Where(x => x.ID == next).First());
            }

            stepCount++;
        }
    }
}
