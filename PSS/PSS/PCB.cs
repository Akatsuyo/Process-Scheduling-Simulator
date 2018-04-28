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
        private int pID;

        /// <summary>
        /// Priority (if algorithm needs)
        /// </summary>
        private int priority;

        /// <summary>
        /// Is process currently on CPU
        /// </summary>
        private bool onCPU;

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
            this.pID = pID;
            this.onCPU = false;
            this.currentProcess = currentProcess;
            processState = ProcessState.NEW;
        }

        /// <summary>
        /// Returns the Process ID
        /// </summary>
        public int PID => pID;

        /// <summary>
        /// Property of process
        /// </summary>
        public Process Process
        {
            get { return currentProcess; }
            set { currentProcess = value; }
        }

        /// <summary>
        /// Property of priority
        /// </summary>
        public int Priority
        {
            get { return priority; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Paramter must be positive", "Priority");
                }
                this.priority = value;
            }
        }

        /// <summary>
        /// Resumes the process
        /// </summary>
        public void Resume()
        {
            processState = ProcessState.RUNNING;
            onCPU = true;
        }
    
        /// <summary>
        /// Run the process
        /// </summary>
        public void Run()
        {
            currentProcess.WaitForIO();
            if (onCPU)
            {
                currentProcess.Do();
            }
        }

        /// <summary>
        /// Pause the process
        /// </summary>
        public void Pause()
        {
            processState = ProcessState.READY;
            onCPU = false;
        }

        /// <summary>
        /// Resets process control block state
        /// </summary>
        public void Reset()
        {
            currentProcess.Reset();
            processState = ProcessState.NEW;
            onCPU = false;
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
    }
}
