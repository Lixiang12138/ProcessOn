using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProcessOn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessOn.Tests
{
    [TestClass()]
    public class ProcessControllerTests
    {
        [TestMethod()]
        public async Task CreateProcessSimulationTestAsync()
        {
            int min_a = 1;
            int max_a = 10;
            int min_b = 1;
            int max_b = 10;
            int size = 10;
            int round = 1;
            List<Process> list = ProcessController.CreateRandomProcesses(size, round, min_a, max_a, min_b, max_b,min_a,max_a);
            Console.Out.WriteLine("list:" + list.ToString());
            ProcessController.CreateProcessSimulation(true, list,1000,1);
            ProcessController.ToForm += ShowList;
            Console.Out.WriteLine("create process simulation.");
            ProcessController.processSimulation.Pause = false;
            await ProcessController.processSimulation.RunAsync();
            Assert.AreEqual(min_a, 1);
        }
        
        
        private void ShowList(ProcessSimulation ps)
        {
            Console.Out.WriteLine("Time:" + ps.Time);
            Console.Out.WriteLine("Waiting:" + ListToString(ps.waitingPool));
            Console.Out.WriteLine("Ready:" + ListToString(ps.readyPool.Array()));
            Console.Out.WriteLine("Running:" + ListToString(ps.runningPool));
            Console.Out.WriteLine("Finished:" + ListToString(ps.finishedPool));
            Console.Out.WriteLine("Blocked:" + ListToString(ps.blockedPool));
        }

        private string ListToString(List<Process> list)
        {
            string str = "";
            str += "[";
            list.ForEach(u => str += "\r\n" + u.ShowProcess());
            str += "]";
            return str;
        }

        [TestMethod()]
        public void test()
        {
            Heap<int> a = new Heap<int>();
            for (int i = 1; i <= 11; i++) a.Push(12 - i);
            for(int i = 1;i <= 11; i++)
            {
                Console.Out.WriteLine(a.Elements.ToString());
                Console.Out.WriteLine(a.Pop());
            }
        }
    }
}