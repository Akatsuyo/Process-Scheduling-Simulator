using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS
{
    public class Scheduler
    {
        private List<Process> prList;
        private IAlgorithm selectedAlg;
        private int animSpeed;
        private Queue<int> rQueue;
        private CPU cpu;
        private int worktime;
        private int turn;
        private int elapsed;

        public Scheduler(List<Process> list, IAlgorithm alg, int speed)
        {
            prList = list;
            selectedAlg = alg;
            animSpeed = speed;
            rQueue = new Queue<int>();
            cpu = new CPU();
            worktime = 0;
            turn = 0;
            elapsed = 0;
        }

        public int ProcessCount
        {
            get { return prList.Count; }
        }

        public Process ProcessAt(int i)
        {
            return prList[i];
        }

        public List<int> QueueList
        {
            get { return rQueue.ToList(); }
        }

        public IAlgorithm Algorithm
        {
            get { return selectedAlg; }
            set { selectedAlg = value; }
        }

        public int AnimationSpeed
        {
            get { return animSpeed; }
            set { animSpeed = value; }
        }

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

        public bool Step()
        {
            selectedAlg.IssueWork(prList, rQueue, cpu);

            // Do cpu work
            if (cpu.DoWork())
                worktime++;

            // Update progress
            if (cpu.ProcessID != -1)
                prList.Where(x => x.ID == cpu.ProcessID).First().Progress = cpu.CurrentProgress;

            elapsed++;
            
            // Check if all processes are done
            bool done = true;
            foreach (var pr in prList)
            {
                if (pr.Progress != pr.Burst)
                {
                    done = false;
                    break;
                }
            }
            return !done;
        }
    }
}
