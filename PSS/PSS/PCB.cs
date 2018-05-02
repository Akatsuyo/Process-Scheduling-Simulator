using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    /// <summary>
    /// Process Control Block
    /// </summary>
    public class PCB
    {
        /// <summary>
        /// Possible states of a process
        /// </summary>
        public enum ProcessState { NEW, READY, RUNNING, WAITING, DEAD };

        /// <summary>
        /// The current process
        /// </summary>
        private Process currentProcess;

        /// <summary>
        /// Process ID
        /// </summary>
        public int PID { get; }

        /// <summary>
        /// Current state of the process
        /// </summary>
        private ProcessState processState;

        /// <summary>
        /// Constructor of the PCB
        /// </summary>
        /// <param name="pID">Process ID</param>
        /// <param name="currentProcess">The process</param>
        public PCB(int pID, Process currentProcess)
        {
            if (pID < 0)
            {
                throw new ArgumentException("Parameter must be greater or equal than 0", "Process ID");
            }
            PID = pID;
            this.currentProcess = currentProcess;
            processState = ProcessState.NEW;
        }

        /// <summary>
        /// Property of process
        /// </summary>
        public Process Process
        {
            get { return currentProcess; }
            set { currentProcess = value; }
        }

        public void Work()
        {
            currentProcess.Do();
        }

        /// <summary>
        /// Resets process control block state
        /// </summary>
        public void Reset()
        {
            currentProcess.Reset();
            processState = ProcessState.NEW;
        }

        /// <summary>
        /// Returns the state of the process
        /// </summary>
        public ProcessState State {
            get
            {
                if (currentProcess.IsBlocked)
                {
                    return ProcessState.WAITING;
                }
                else if (currentProcess.IsDone)
                {
                    return ProcessState.DEAD;
                }
                else
                {
                    return processState;
                }
            }
        }

        public override string ToString()
        {
            string ret = "";
            ret += "(#" + PID + ") " + Process.Name + " [";
            ret += "State: " + State + ", ";
            ret += "I/O time: " + Process.IOTime + ", ";
            ret += "CPU time: " + Process.CPUTime + ", ";
            ret += "Total time: " + Process.TotalTime + "]";
            return ret;
        }
    }
}
