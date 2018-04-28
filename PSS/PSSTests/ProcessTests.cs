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
    }
}
