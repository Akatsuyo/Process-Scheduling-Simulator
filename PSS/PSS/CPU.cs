using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    /// <summary>
    /// CPU Simulation
    /// </summary>
    public class CPU
    {
        /// <summary>
        /// Program Control Block of the process which is currently processed by the CPU
        /// </summary>
        private PCB currentProcess;

        /// <summary>
        /// Is CPU Working? (e.g. process is not blocked and not dead)
        /// </summary>
        private bool working;

        /// <summary>
        /// Constructor of the CPU Simulator
        /// </summary>
        public CPU()
        {
            working = false;
            currentProcess = null;
        }

        /// <summary>
        /// Sets the current process
        /// </summary>
        /// <param name="process">Process which is dhould be processed by the CPU</param>
        public void SetProcess(PCB process)
        {
            currentProcess = process;
            process.Resume();
            working = true;
        }

        /// <summary>
        /// Removes the current process from the CPU
        /// </summary>
        public void StopProcess()
        {
            if (currentProcess != null)
            {
                currentProcess.Pause();
                currentProcess = null;
                working = false;
            }
        }

        /// <summary>
        /// As the method name says, it does work (everything)
        /// </summary>
        public void DoWork()
        {
            if (currentProcess != null)
            {
                currentProcess.Run();
                if (currentProcess.State == PCB.ProcessState.DEAD)
                {
                    StopProcess();
                }
            }
        }

        /// <summary>
        /// Returns the PID of the current process (if there is no process on CPU it returns -1)
        /// </summary>
        public int ProcessID
        {
            get { return (currentProcess != null) ? currentProcess.PID : -1; }
        }

        /// <summary>
        /// Is CPU currently working
        /// </summary>
        public bool Working
        {
            get { return working; }
        }
    }
}
