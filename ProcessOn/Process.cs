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

        public Process(string name = null,int priority = -1,int round = -1,int cputime = -1,int count = -1,int needtime = -1,int createtime = -1,int state = -1)
        {
            this.Name = name;
            this.Priority = priority;
            this.Round = round;
            this.Cputime = cputime;
            this.Count = count;
            this.Needtime = needtime;
            this.Createtime = createtime;
            this.State = state;
            this.Next = null;
        }

        public int State { get; set; }//-1:FLAG 0:FINISH 1:RUNNING 2:WAIT 3:BLOCKED
        public int Createtime { get ; }
        public int Needtime { get ; set ; }
        public int Count { get ; set ; }
        public int Cputime { get ; }
        public int Round { get; set; }
        public int Priority { get; set; }
        public string Name { get; }
        internal Process Next { get; set; }

        public int CompareTo(object obj)
        {
            return Priority.CompareTo(obj);
        }
        
        public string ShowProcess()
        {
            string str = "";
            str += Name.PadRight(8,' ');
            str += Priority.ToString().PadRight(8,' ');
            str += Createtime.ToString().PadRight(8, ' ');
            str += (Cputime - Needtime).ToString().PadRight(8, ' ');
            str += stateName[State].PadRight(8, ' ');
            return str;
        }
        
    }

    class InitProcessHandler
    {
        public static Process CreateProcess(string name, int priority, int round, int cputime, int count, int needtime, int createtime, int state)
        {
            return new Process(name, priority, round, cputime, count, needtime, createtime, state);
        }

        public static Process CreateRandomProcess(string name,int round,int min_createtime,int max_createtime,int min_cputime,int max_cputime,int min_priority = -1,int max_priority = -1)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
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
