using System;
using System.Collections.Generic;

namespace ProcessOn
{
    public class ProcessController
    {
        #region 调用form
        public static event Action<ProcessSimulation> ToForm;
        #endregion

        public static ProcessSimulation processSimulation;

        public static void CreateProcessSimulation(bool isPriority,List<Process> processes,int speed = 1,int core = 1)
        {
            if (isPriority) processSimulation = new PriorityProcessSimulation(speed,core);
            else processSimulation = new QueueProcessSimulation(speed,core);
            processSimulation.OneStepWent += Solve;
            processSimulation.Pause = true;
            processSimulation.InsertIntoWaitingPool(processes);
        }

        public static void OneTick()
        {
            if (!processSimulation.IsStoped()) return;
            processSimulation?.OneTick();
        }

        public static void Pause()
        {
            processSimulation?.SetPause();
        }

        public static void Block(string name)
        {
            processSimulation?.BlockProcess(name);
        }

        public static void Ready(string name)
        {
            processSimulation?.ReadyProcess(name);
        }

        public static void Speed(int speed)
        {
            processSimulation?.SetSpeed(speed);
        }

        public static Process CreateProcess(string name, int priority, int round, int cputime, int count, int needtime, int createtime, int state)
        {
            return new Process(name, priority, round, cputime, count, needtime, createtime, state);
        }

        public static Process CreateRandomProcess(Random random ,string name, int round, int min_createtime, int max_createtime, int min_cputime, int max_cputime, int min_priority = -1, int max_priority = -1)
        {
            int createtime = random.Next(min_createtime, max_createtime);
            int cputime = random.Next(min_cputime, max_cputime);
            int priority = random.Next(min_priority, max_priority);
            return CreateProcess(name, priority, round, cputime, 0, cputime, createtime, Process.WAIT);
        }

        public static List<Process> CreateRandomProcesses(int size, int round, int min_createtime, int max_createtime, int min_cputime, int max_cputime, int min_priority = -1, int max_priority = -1)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            List<Process> list = new List<Process>();
            for (int i = 1; i <= size; i++)
            {
                String name = "P" + i;
                Process p = CreateRandomProcess(random,name, round, min_createtime, max_createtime, min_cputime, max_cputime, min_priority, max_priority);
                list.Add(p);
            }
            return list;
        }
        public static void Solve(ProcessSimulation ps)
        {
            ToForm?.Invoke(ps);
        }
    }
}
