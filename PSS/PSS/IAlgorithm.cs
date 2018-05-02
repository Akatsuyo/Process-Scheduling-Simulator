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
        void Initialize(List<PCB> processes);

        /// <summary>
        /// Returns the pcb pool
        /// </summary>
        /// <returns>PCB pool</returns>
        List<PCB> Pool { get; }

        /// <summary>
        /// Gets ready to go pcbs (not blocked or finished)
        /// </summary>
        /// <returns>Ready PCB List</returns>
        List<PCB> ReadyPCBs { get; }

        /// <summary>
        /// Returns the running process
        /// </summary>
        PCB RunningPCB { get; }

        /// <summary>
        /// Checks if there is a process that could be assigned for the CPU at the moment.
        /// </summary>
        bool ProcessAvailable { get; }

        /// <summary>
        /// Returns true if there are no more processes left
        /// Warning! This also returns true, if the current process is running yet
        /// </summary>
        bool Done { get; }

        /// <summary>
        /// Returns the amount of remaining processes (includes all queue)
        /// </summary>
        int RemainingProcessCount { get; }

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
        /// Starts the algorithm.
        /// </summary>
        void Start();

        /// <summary>
        /// Clears the algorithm, including everything (queues, variables, etc.)
        /// </summary>
        void Clear();
    }
}
