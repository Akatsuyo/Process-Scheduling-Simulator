using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    public class Process
    {
        private static int nextId = 1;

        private int id;
        private string name;
        private int burst;
        private int arrival;
        private int priority;
        private int progress;

        public Process(string name, int burst, int arrival, int priority)
        {
            id = nextId++;
            this.name = name;
            this.burst = burst;
            this.arrival = arrival;
            this.priority = priority;
            progress = 0;
        }

        public int ID
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
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

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public int Progress
        {
            get { return progress; }
            set { progress = value; }
        }
    }
}
