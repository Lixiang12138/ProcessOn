using System;
using System.Collections.Generic;

namespace ProcessOn
{
    class Process : IComparable
    {
        public static readonly int FINISH = 0;
        public static readonly int RUNNING = 1;
        public static readonly int READY = 2;
        public static readonly int BLOCKED = 3;
        public static readonly int WAIT = 4;

        private static readonly String[] stateName = {"Finish","Running","Ready","Blocked","Wait"};

        public Process(string name = null,int priority = -1,int round = -1,int cputime = -1,int count = -1,int needtime = -1,int createtime = -1,int state = -1)
        {
            this.Name = name;
            this.Priority = priority;
            this.Round = round;
            this.Cputime = cputime;
            this.Count = count;
            this.Needtime = needtime;
            this.Runningtime = 0;
            this.Createtime = createtime;
            this.State = state;
            this.Next = null;
        }

        public int State { get; set; }//-1:FLAG 0:FINISH 1:RUNNING 2.READY 3:BLOCKED 4.WAIT
        public int Createtime { get ; }
        public int Needtime { get ; set ; }
        public int Count { get ; set ; }
        public int Cputime { get ; }
        public int Round { get; set; }
        public int Priority { get; set; }
        public int Runningtime { get; set; }
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
}
