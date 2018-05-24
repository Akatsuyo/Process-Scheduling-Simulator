using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    class HRRN : IAlgorithm
    {
        LinkedList<PCB> processes;

        public HRRN()
        {
        }

        public List<PCB> Pool => throw new NotImplementedException();

        public List<PCB> ReadyPCBs => throw new NotImplementedException();

        public PCB RunningPCB => throw new NotImplementedException();

        public bool ProcessAvailable => throw new NotImplementedException();

        public bool Done => throw new NotImplementedException();

        public int RemainingProcessCount => throw new NotImplementedException();

        public void AddProcess(PCB process)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public string GetProcessNameByID(int pID)
        {
            throw new NotImplementedException();
        }

        public PCB.ProcessState GetProcessStateByID(int pID)
        {
            throw new NotImplementedException();
        }

        public void Initialize(List<PCB> processes)
        {
            this.processes = new LinkedList<PCB>(processes);
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }

        private double ResponseRatio(PCB pcb)
        {
            int turnaround = 
            int burst
            return (double)turnaround / (double)burst;
        }
    }
}
