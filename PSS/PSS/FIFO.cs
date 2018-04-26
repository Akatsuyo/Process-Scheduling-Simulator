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
    public class FIFO : IAlgorithm
    {
        Queue<PCB> queue;
        PCB current;
        private bool started = false;

        public void AddProcess(PCB process)
        {
            queue.Enqueue(process);
        }

        public int CountRemainingProcess()
        {
            return queue.Count;
        }

        public Queue<PCB> GetBlockedPCBs()
        {
            //In FIFO algorithm there is not blocked queue
            return new Queue<PCB>();
        }

        public string GetProcessNameByID(int pID)
        {
            if (current.PID == pID)
            {
                return current.Process.Name;
            }
            foreach (PCB process in queue)
            {
                if (process.PID == pID)
                {
                    return process.Process.Name;
                }
            }
            //If there is no process with this ID
            return "";
        }

        public PCB.ProcessState GetProcessStateByID(int pID)
        {
            if (current.PID == pID)
            {
                return current.State;
            }
            foreach (PCB process in queue)
            {
                if (process.PID == pID)
                {
                    return process.State;
                }
            }

            //If there is no process with this ID
            return PCB.ProcessState.DEAD;
        }

        public Queue<PCB> GetReadyPCBs()
        {
            //In FIFO algorithm we only have one queue
            return queue;
        }

        public PCB GetRunningPCB()
        {
            return current;
        }

        public bool IsDone()
        {
            return (started && queue.Count == 0 );
        }

        public void SetProcesses(List<PCB> processes)
        {
            queue = new Queue<PCB>(processes);
            current = queue.Dequeue();
            started = true;
        }

        public void Work()
        {
            if (current != null) {
                if (current.State == PCB.ProcessState.DEAD)
                {
                    //In FIFO we get the next process when the old one finished
                    current = queue.Dequeue();
                }
            }
        }

        public void Clear()
        {
            started = false;
            queue = null;
            current = null;
        }
    }
}
