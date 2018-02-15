using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    public class Process
    {
        private string id;
        private int burst;
        private int arrival;

        public Process(string id, int burst, int arrival)
        {
            this.id = id;
            this.burst = burst;
            this.arrival = arrival;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public int Burst
        {
            get { return burst; }
            set { burst = value; }
        }

        public int Arrival
        {
            get { return arrival; }
            set { arrival = value; }
        }
    }
}
