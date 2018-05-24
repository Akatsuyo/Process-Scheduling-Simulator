using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.Tests
{
    [TestClass()]
    public class SchedulerTests
    {
        [TestMethod()]
        public void SchedulerTest()
        {
            List<Process> processes = new List<Process>
            {
                new Process("pr1", 0.2, IO.Speed.FAST, 500),
                new Process("pr2", 0.2, IO.Speed.FAST, 500),
                new Process("pr3", 0.2, IO.Speed.FAST, 500)
            };
            Scheduler scheduler = new Scheduler(processes, new FIFO());
            //process time and io time
            int maxCounter = 500 * 300 * 3;
            int minCounter = 500 * 3;
            int counter = 0;
            while (!scheduler.Step())
            {
                Assert.IsTrue(counter < 100000000, "Possible infinite loop");
                counter++;
            }

            Assert.IsTrue(scheduler.ElapsedTime <= maxCounter, "Scheduler runs more than it should");
            Assert.IsTrue(scheduler.ElapsedTime >= minCounter, "Scheduler runs less than it should");
        }

        [TestMethod()]
        public void SchedulerWorkTimeAccuracyTest()
        {
            List<Process> processes = new List<Process>
            {
                new Process("pr1", 0.2, IO.Speed.FAST, 500),
                new Process("pr2", 0.2, IO.Speed.FAST, 500),
                new Process("pr3", 0.2, IO.Speed.FAST, 500)
            };
            Scheduler scheduler = new Scheduler(processes, new FIFO());
            //process time and io time
            int counter = 0;
            while (!scheduler.Step())
            {
                Assert.IsTrue(counter < 100000000, "Possible infinite loop");
                counter++;
            }

            int theoreticalCounter = 0;

            foreach (var process in scheduler.ProcessList)
            {
                theoreticalCounter += process.Process.CPUTime;
            }

            Assert.IsTrue(theoreticalCounter == scheduler.Worktime, "Scheduler work time is inaccurate");
        }

        [TestMethod()]
        public void SchedulerTotalTimeAccuracyTest()
        {
            List<Process> processes = new List<Process>
            {
                new Process("pr1", 0.2, IO.Speed.FAST, 500),
                new Process("pr2", 0.2, IO.Speed.FAST, 500),
                new Process("pr3", 0.2, IO.Speed.FAST, 500)
            };
            Scheduler scheduler = new Scheduler(processes, new FIFO());
            //process time and io time
            int counter = 0;
            while (!scheduler.Step())
            {
                Assert.IsTrue(counter < 100000000, "Possible infinite loop");
                counter++;
            }

            int theoreticalCounter = 0;

            foreach (var process in scheduler.ProcessList)
            {
                theoreticalCounter += process.Process.CPUTime;
            }
            Assert.IsTrue(theoreticalCounter + scheduler.Turns + scheduler.WastedTime == scheduler.ElapsedTime, "Scheduler total time is inaccurate");
        }
    }
}