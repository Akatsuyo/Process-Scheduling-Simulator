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
        public enum ProcessState {
            /// <summary>
            /// The process is new
            /// </summary>
            NEW,
            /// <summary>
            /// The process is waiting for its turn
            /// </summary>
            READY,
            /// <summary>
            /// The rpocess is on the CPU
            /// </summary>
            RUNNING,
            /// <summary>
            /// The process is waiting for I/O
            /// </summary>
            WAITING,
            /// <summary>
            /// THe process is completed
            /// </summary>
            DEAD
        };

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

        /// <summary>
        /// Make something happen (simulates the process running)
        /// </summary>
        /// <returns>Process work was userful (not blocked/dead)</returns>
        public bool Work()
        {
            processState = ProcessState.RUNNING;
            return currentProcess.Do();
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
        /// Handles I/O operations and changes state to ready when there is no I/O operation
        /// </summary>
        public void IOWork()
        {
            currentProcess.WaitForIO();
            if (!currentProcess.Blocked)
            {
                processState = ProcessState.READY;
            }
        }

        /// <summary>
        /// Returns the state of the process
        /// </summary>
        public ProcessState State {
            get
            {
                if (currentProcess.Blocked)
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

        /// <summary>
        /// Returns the string representation of the class
        /// </summary>
        /// <returns>Parsed string</returns>
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
