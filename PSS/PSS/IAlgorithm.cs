using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    /// <summary>
    /// Schedule algorithm
    /// </summary>
    public interface IAlgorithm
    {
        /// <summary>
        /// Sets the initial processes
        /// </summary>
        /// <param name="processes">List of the processes</param>
        void SetProcesses(List<PCB> processes);
  
        /// <summary>
        /// Returns the running process
        /// </summary>
        /// <returns>Running PCB</returns>
        PCB GetRunningPCB();

        /// <summary>
        /// Returns the ready queue
        /// </summary>
        /// <returns>Ready queue</returns>
        Queue<PCB> GetReadyPCBs();

        /// <summary>
        /// Returns the blocked queue
        /// </summary>
        /// <returns>Blocked queue</returns>
        Queue<PCB> GetBlockedPCBs();

        /// <summary>
        /// Returns true if there are no more processes left
        /// Warning! This also returns true, if the current process is running yet
        /// </summary>
        /// <returns>Returns true if there are no more processes left</returns>
        bool IsDone();

        /// <summary>
        /// Returns the amount of remaining processes (includes all queue)
        /// </summary>
        /// <returns>Amount of remaining processes</returns>
        int CountRemainingProcess();

        /// <summary>
        /// Returns the process name where IDs are equal
        /// </summary>
        /// <param name="pID">ID to be checked</param>
        /// <returns>Fetched name</returns>
        string GetProcessNameByID(int pID);

        /// <summary>
        /// Adds process to the scheduling algorithm
        /// </summary>
        /// <param name="process">The new process</param>
        void AddProcess(PCB process);

        /// <summary>
        /// Returns the process state where IDs are equal
        /// </summary>
        /// <param name="pID">ID to be checked</param>
        /// <returns>Fetched state</returns>
        PCB.ProcessState GetProcessStateByID(int pID);

        /// <summary>
        /// Calls the scheduling algorithm
        /// </summary>
        void Work();

        /// <summary>
        /// Clears the algorithm, including everything (queues, variables, etc.)
        /// </summary>
        void Clear();
    }
}
