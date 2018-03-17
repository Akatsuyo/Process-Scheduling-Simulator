using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    public interface IAlgorithm
    {
        void IssueWork(List<Process> prList, Queue<int> rQueue, CPU cpu);
    }
}
