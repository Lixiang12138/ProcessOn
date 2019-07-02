using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessOn
{
    class Process : IComparable
    {

        private static readonly String[] stateName = {"Finish","Running","Wait","Blocked"};

        private string name;
        private int priority;
        private int round;
        private int cputime;
        private int count;
        private int needtime;
        private int createtime;
        private int state;//-1:FLAG 0:FINISH 1:RUNNING 2:WAIT 3:BLOCKED
        Process next;

        public Process(string name = null,int priority = -1,int round = -1,int cputime = -1,int count = -1,int needtime = -1,int createtime = -1,int state = -1)
        {
            this.name = name;
            this.priority = priority;
            this.round = round;
            this.cputime = cputime;
            this.count = count;
            this.needtime = needtime;
            this.createtime = createtime;
            this.state = state;
            this.next = null;
        }

        public int State { get => state; set => state = value; }
        internal Process Next { get => next; set => next = value; }

        public int CompareTo(object obj)
        {
            return priority.CompareTo(obj);
        }
        
        public string ShowProcess()
        {
            string str = "";
            str += name.PadRight(8,' ');
            str += priority.ToString().PadRight(8,' ');
            str += createtime.ToString().PadRight(8, ' ');
            str += (cputime - needtime).ToString().PadRight(8, ' ');
            str += stateName[state].PadRight(8, ' ');
            return str;
        }
    }

    class ProcessHandler
    {
        public static Process CreateProcess(string name, int priority, int round, int cputime, int count, int needtime, int createtime, int state)
        {
            return new Process(name, priority, round, cputime, count, needtime, createtime, state);
        }

        public static Process CreateRandomProcess(string name,int round,int min_createtime,int max_createtime,int min_cputime,int max_cputime,int min_priority = -1,int max_priority = -1)
        {
            Random random = new Random();
            int createtime = random.Next(min_createtime, max_createtime);
            int cputime = random.Next(min_cputime, max_cputime);
            int priority = random.Next(min_priority, max_priority);
            return CreateProcess(name, priority, round, cputime, 0, cputime, createtime, 2);
        }

        public static List<Process> CreateRandomProcesses(int size,int round,int min_createtime, int max_createtime, int min_cputime, int max_cputime, int min_priority = -1, int max_priority = -1)
        {
            List<Process> list = new List<Process>();
            for(int i = 1;i <= size; i++)
            {
                String name = "P" + i;
                Process p = CreateRandomProcess(name, round, min_createtime, max_createtime, min_cputime, max_cputime, min_priority, max_priority);
                list.Add(p);
            }
            return list;
        }
    }
}
