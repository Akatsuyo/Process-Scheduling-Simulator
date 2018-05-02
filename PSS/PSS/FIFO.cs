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
        List<PCB> pool;
        List<PCB> blocked;
        private Queue<PCB> queue;
        private PCB current;
        private bool started;

        public void Initialize(List<PCB> processes)
        {
            pool = processes;
            queue = new Queue<PCB>();
            blocked = new List<PCB>();
        }

        // Should set current and started
        public void Start()
        {
            pool.ForEach(x => queue.Enqueue(x));
            current = queue.Dequeue();
            started = true;
        }

        public List<PCB> Pool
        {
            get { return pool; }
        }

        public void AddProcess(PCB process)
        {
            pool.Add(process);
            queue.Enqueue(process);
        }

        public int RemainingProcessCount
        {
            get { return pool.Select(x => x.Process.IsDone).Count(); }
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

        public List<PCB> ReadyPCBs
        {
            get { return queue.ToList(); }
        }

        public PCB RunningPCB
        {
            get { return current; }
        }

        public bool ProcessAvailable
        {
            get { return current != null; }
        }

        public bool Done
        {
            get { return pool.Count == pool.Count(x => x.State == PCB.ProcessState.DEAD); }
        }

        public void Work()
        {
            if (!started)
                return;

            // Enqueue all PCBs that are now not blocked anymore
            foreach (var pcb in blocked)
            {
                if (!pcb.Process.IsBlocked)
                {
                    queue.Enqueue(pcb);
                }
            }
            // And remove them from the list
            blocked.RemoveAll(x => !x.Process.IsBlocked);

            if (current != null)
            {
                // If there's a process currently assigned to the CPU

                if (current.State == PCB.ProcessState.DEAD)
                {
                    // If it's dead, get the next one
                    current = Next();
                }
                else if (current.State == PCB.ProcessState.WAITING)
                {
                    // If it's blocked, add it to the blocked list, and get the next one
                    blocked.Add(current);
                    current = Next();
                }
            }
            else
            {
                // If there's not
                current = Next();
            }
        }

        // Returns next process to assign (null if not available)
        private PCB Next()
        {
            return queue.Count == 0 ? null : queue.Dequeue();
        }

        public void Clear()
        {
            // Must call Initialize() again before using the algorithm
            pool = null;
            blocked = null;
            queue = null;
            current = null;
        }
    }
}
