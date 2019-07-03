using System;
using System.Collections.Generic;

namespace ProcessOn
{
    class ProcessController
    {
        public static Process CreateProcess(string name, int priority, int round, int cputime, int count, int needtime, int createtime, int state)
        {
            return new Process(name, priority, round, cputime, count, needtime, createtime, state);
        }

        public static Process CreateRandomProcess(Random random ,string name, int round, int min_createtime, int max_createtime, int min_cputime, int max_cputime, int min_priority = -1, int max_priority = -1)
        {
            int createtime = random.Next(min_createtime, max_createtime);
            int cputime = random.Next(min_cputime, max_cputime);
            int priority = random.Next(min_priority, max_priority);
            return CreateProcess(name, priority, round, cputime, 0, cputime, createtime, 2);
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

    }
}
