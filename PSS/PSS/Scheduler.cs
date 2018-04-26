using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS
{
    /// <summary>
    /// This class contains the process scheduling logic
    /// </summary>
    public class Scheduler
    {
        /// <summary>
        /// PID counter
        /// </summary>
        public int counter;

        /// <summary>
        /// List of the process control vlocks
        /// </summary>
        private List<PCB> processList;

        /// <summary>
        /// Selected algorithm
        /// </summary>
        private IAlgorithm selectedAlgorithm;

        /// <summary>
        /// CPU which 'does the work'
        /// </summary>
        private CPU cpu;

        private int worktime;
        private int turn;
        private int elapsed;

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="list">List of the processes</param>
        /// <param name="alg">Instance of the chosen algorithm</param>
        public Scheduler(List<Process> list, IAlgorithm alg)
        {
            //Set PID default value
            counter = 0;

            processList = EncapsulateProcesses(list);
            selectedAlgorithm = alg;

            //Forward all process to the algorithm (which is possibly makes a queue of it)
            selectedAlgorithm.SetProcesses(processList);

            //Init the CPU and set the current process
            cpu = new CPU();
            cpu.SetProcess(selectedAlgorithm.GetRunningPCB());

            worktime = 0;
            turn = 0;
            elapsed = 0;
        }

        /// <summary>
        /// Resets the Scheduler to defaults
        /// </summary>
        public void Reset()
        {
            //Clears algorithm storage (queue, etc.)
            selectedAlgorithm.Clear();
            //Reset all process
            processList.ForEach(i => i.Reset());
            //Forward the processes (again...)
            selectedAlgorithm.SetProcesses(processList);

            //Make a new CPU and set the current process
            cpu = new CPU();
            cpu.SetProcess(selectedAlgorithm.GetRunningPCB());

            worktime = 0;
            turn = 0;
            elapsed = 0;
        }

        /// <summary>
        /// Encapsulate the processes into PCB (Process Control Block)
        /// </summary>
        /// <param name="processes">List of the processes</param>
        /// <returns>List of the encapsulated processes (PCB)</returns>
        private List<PCB> EncapsulateProcesses(List<Process> processes)
        {
            List<PCB> list = new List<PCB>();
            processes.ForEach(x => list.Add(new PCB(counter++, x)));
            return list;
        }

        /// <summary>
        /// Encapsulate a single process into PCB (Process Control Block)
        /// </summary>
        /// <param name="process">The process</param>
        /// <returns>The encapsulated PCB</returns>
        public PCB AddAndEncapsulateProcess(Process process)
        {
            PCB pcb = new PCB(counter++, process);
            ProcessList.Add(pcb);
            //Add process to the scheduling algorithm too
            selectedAlgorithm.AddProcess(pcb);
            return pcb;
        }

        /// <summary>
        /// Returns the amount of processes
        /// </summary>
        public int ProcessCount
        {
            get { return processList.Count; }
        }

        /// <summary>
        /// Returns the process by the index
        /// </summary>
        /// <param name="i">Index</param>
        /// <returns>Returned process</returns>
        public PCB ProcessAt(int i)
        {
            return processList[i];
        }

        /// <summary>
        /// Returns the list of the processes
        /// </summary>
        public List<PCB> ProcessList { get => processList;  }

        /// <summary>
        /// Returns the current scheduling algorithm
        /// </summary>
        IAlgorithm Algorithm
        {
            get { return selectedAlgorithm; }
            set { selectedAlgorithm = value; }
        }

        /// <summary>
        /// Returns the Ready Queue
        /// </summary>
        public Queue<PCB> ReadyQueue { get => selectedAlgorithm.GetReadyPCBs(); }

        public int Worktime
        {
            get { return worktime; }
            set { worktime = value; }
        }

        public int Turnaround
        {
            get { return turn; }
            set { turn = value; }
        }

        public int ElapsedTime
        {
            get { return elapsed; }
            set { elapsed = value; }
        }

        /// <summary>
        /// Returns the Process instance by an ID
        /// </summary>
        /// <param name="PID">Process ID</param>
        /// <returns>Process Instance</returns>
        public PCB GetProcessByID(int PID)
        {
            PCB pcb = null;
            processList.ForEach(x => {
                if (x.PID == PID)
                {
                    pcb = x;
                    return;
                }
            });
            return pcb;
        }

        /// <summary>
        /// One step of the scheduler
        /// </summary>
        /// <returns>Returns true if there are no active process, otherwise false</returns>
        public bool Step()
        {
            selectedAlgorithm.Work();

            if (selectedAlgorithm.GetRunningPCB().PID != cpu.ProcessID)
            {
                cpu.StopProcess();
                cpu.SetProcess(selectedAlgorithm.GetRunningPCB());
            }

            // Do cpu work
            cpu.DoWork();
            if (cpu.Working)
                worktime++;

            elapsed++;

            // Check if all processes are done
            return (selectedAlgorithm.IsDone() && selectedAlgorithm.GetRunningPCB().State == PCB.ProcessState.DEAD);
        }
    }
}
