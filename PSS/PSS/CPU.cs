using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    public class CPU
    {
        private int currPr;
        private int prBurst;
        private int prProgress;
        private bool working;
        private bool didWork;

        public CPU()
        {
            working = false;
            currPr = -1;
        }

        public void SetProcess(Process pr)
        {
            currPr = pr.ID;
            prBurst = pr.Burst;
            prProgress = pr.Progress;
            if (prBurst - prProgress > 0)
                working = true;
        }

        public void Stop()
        {
            working = false;
        }

        public bool DoWork()
        {
            if (working)
            {
                ++prProgress;
                if (prBurst - prProgress <= 0)
                {
                    // Work done
                    working = false;
                }
                didWork = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ProcessID
        {
            get { return currPr; }
        }

        public int CurrentProgress
        {
            get { return prProgress; }
        }

        public bool Working
        {
            get { return working; }
            set { working = value; }
        }
    }
}
