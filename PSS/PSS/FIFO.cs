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

        public void IssueWork(List<Process> prList, IEnumerable<int> rQueue, CPU cpu)
        {
            var queue = rQueue as Queue<int>;
            // Check for arriving processes
            foreach (var pr in prList)
            {
                if (pr.Arrival == stepCount)
                {
                    // Enqueue process
                    queue.Enqueue(pr.ID);
                }
            }

            // If cpu is not working, start next process in queue
            if (!cpu.Working && queue.Count > 0)
            {
                int next = queue.Dequeue();
                cpu.SetProcess(prList.Where(x => x.ID == next).First());
            }

            rQueue = queue as IEnumerable<int>;
            stepCount++;
        }
    }
}
