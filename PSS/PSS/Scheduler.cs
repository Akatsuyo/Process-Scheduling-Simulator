using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    class Scheduler
    {
        private string selectedAlg;
        private int animSpeed;
        private int util;
        private int turn;
        private int elapsed;

        public string Algorithm
        {
            get { return selectedAlg; }
            set { selectedAlg = value; }
        }

        public int AnimationSpeed
        {
            get { return animSpeed; }
            set { animSpeed = value; }
        }

        public int Utilization
        {
            get { return util; }
            set { util = value; }
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

        public void Step()
        {
            typeof(Algorithm).GetMethod(selectedAlg).Invoke(null, null);
        }
    }
}
