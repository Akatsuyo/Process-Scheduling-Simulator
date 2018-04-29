using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PSS;

namespace PSSTests
{
    [TestClass]
    public class ProcessTests
    {
        [TestMethod]
        public void ProbabilityPercent()
        {
            double ioProb = 0.69;
            int expected = 69;
            Process process = new Process("test", ioProb, IO.Speed.FAST, 100);
            Assert.AreEqual(expected, process.IOProbabilityPercent);
        }

        [TestMethod]
        public void ProcessWorkGetsDone()
        {
            int length = 100;
            Process process = new Process("test", 0, IO.Speed.FAST, length);
            for (int i = 0; i < length; i++)
            {
                process.Do();
            }

            Assert.IsTrue(process.IsDone);
        }

        [TestMethod]
        public void ProcessStatsTest()
        {
            Process pr1 = new Process("pr", 0, IO.Speed.FAST, 100);
            int counter = 0;
            while (!pr1.IsDone)
            {
                pr1.Do();
                counter++;
                Assert.IsTrue(counter < 1000000, "Possible infinite loop");
            }
            Assert.IsTrue(pr1.TotalTime == counter, "Total time is not accurate");
            Assert.IsTrue(pr1.TotalTime == pr1.CPUTime, "CPU only process has different CPU and total time");
        }
    }
}
