using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scheduling;

namespace UnitTestTeam3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestToString()
        {
            PCB pcb = new PCB();
            pcb.ProcessName = "B";
            pcb.ProcessPriority = 1;
            Assert.AreEqual("B(1)", pcb.ToString());
        }

        [TestMethod]
        public void TestToString2() //Ændrer automatisk op til 1 prio
        {
            PCB pcb = new PCB();
            pcb.ProcessName = "C";
            pcb.ProcessPriority = 0;
            Assert.AreEqual("C(1)", pcb.ToString());
        }
        [TestMethod]
        public void TestIncorrectProcessPriority()
        {
            PCB pcb2 = new PCB();
            pcb2.ProcessPriority = -5;
            Assert.IsTrue(pcb2.ProcessPriority == 1);
        }
    }
}


