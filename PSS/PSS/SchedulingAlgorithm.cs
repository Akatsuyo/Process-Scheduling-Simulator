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

        /// <summary>
        /// Scheduler Description
        /// </summary>
        protected String desc="No Description";

        /// <summary>
        /// Currently running process
        /// </summary>
        protected PCB current;

        /// <summary>
        /// Is scheduler ready 
        /// </summary>
        protected bool ready;

        /// <summary>
        /// Constructor of the scheduling algorithm
        /// </summary>
        public SchedulingAlgorithm()
        {
            ready = false;
        }

        /// <summary>
        /// Populates the algorithm with processes
        /// </summary>
        /// <param name="pool"></param>
        public void Initialize(List<PCB> pool)
        {
            // Copy list instead referencing it
            this.pool = pool.ToList();
            ready = true;
        }

        /// <summary>
        /// Adds new processes (even at runtime)
        /// </summary>
        /// <param name="pcb"></param>
        public void AddNewProcess(PCB pcb)
        {
            pool.Add(pcb);
        }

        /// <summary>
        /// Clears the algorithm, resets it to defaults
        /// </summary>
        public virtual void Reset()
        {
            pool.Clear();
            current = null;
            ready = false;
        }

        /// <summary>
        /// Get Description
        /// </summary>
        public virtual String Desc()
        {
            return desc;
        }

        /// <summary>
        /// List of processes
        /// </summary>
        public List<PCB> Pool
        {
            get { return pool; }
        }

        /// <summary>
        /// Currently running process
        /// </summary>
        public PCB RunningProcess
        {
            get { return current; }
        }

        /// <summary>
        /// Is algorithm done
        /// </summary>
        public bool Done
        {
            get { return Pool.Count(x => x.State != PCB.ProcessState.DEAD) == 0; }
        }

        /// <summary>
        /// Scheduler should swap processes
        /// </summary>
        public bool ShouldSwap
        {
            get { return current != null; }
        }

        /// <summary>
        /// This is where the algorithm works (does its job)
        /// </summary>
        public abstract void Work();

        /// <summary>
        /// Returns the algorithm settings of the algorithm
        /// </summary>
        /// <returns>Algorithm settings</returns>
        public abstract AlgorithmSettings GetAlgorithmSettings();
    }
}
