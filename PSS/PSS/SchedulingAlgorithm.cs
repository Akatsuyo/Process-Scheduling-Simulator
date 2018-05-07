using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    /// <summary>
    /// An abstract class for all the scheduling algorithms.
    /// </summary>
    public abstract class SchedulingAlgorithm
    {
        private List<PCB> pool;
        protected PCB current;
        protected bool ready;

        public SchedulingAlgorithm()
        {
            ready = false;
        }

        public void Initialize(List<PCB> pool)
        {
            // Copy list instead referencing it
            this.pool = pool.ToList();
            ready = true;
        }

        public void AddNewProcess(PCB pcb)
        {
            pool.Add(pcb);
        }

        public virtual void Reset()
        {
            pool.Clear();
            current = null;
            ready = false;
        }

        public List<PCB> Pool
        {
            get { return pool; }
        }

        public PCB RunningProcess
        {
            get { return current; }
        }

        public bool Done
        {
            get { return Pool.Count(x => x.State != PCB.ProcessState.DEAD) == 0; }
        }

        public bool ProcessAvailable
        {
            get { return current != null; }
        }

        public abstract void Work();
    }
}
