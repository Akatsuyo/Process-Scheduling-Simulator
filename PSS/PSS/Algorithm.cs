using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    public static class Algorithm
    {
        public static void FIFO()
        {
            for (int i = 0; i < Simulation.processList.Count; i++)
            {
                if (Simulation.processList[i].Progress < 100)
                {
                    Simulation.processList[i].Progress += 5;
                }
            }
        }
    }
}
