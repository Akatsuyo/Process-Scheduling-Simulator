using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PSS;

namespace PSSTests
{
    [TestClass]
    public class IOTests
    {
        [TestMethod]
        public void IODone()
        {
            IO io = new IO(IO.Speed.FAST);
            int length = io.Length;
            for (int i = 0; i < io.Length; i++)
            {
                io.GetData();
            }
            Assert.IsTrue(io.Done);
        }
    }
}
