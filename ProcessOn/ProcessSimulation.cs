using System.Collections.Generic;

namespace ProcessOn
{
    class ProcessSimulation
    {
        protected List<Process> waitingPool;
        protected IContainer<Process> readyPool;
        protected List<Process> runningPool;
        protected List<Process> finishedPool;
        protected List<Process> blockedPool;

        public int Speed { get; set; }
        public int Time { get; set; }
        protected int Core;

        public ProcessSimulation(int speed = 1,int Core = 1)
        {
            waitingPool = new List<Process>();
            runningPool = new List<Process>();
            finishedPool = new List<Process>();
            blockedPool = new List<Process>();
            Speed = speed;
            Time = 0;
            this.Core = Core;
        }

        /**
         * 将随机出来的进程放入等待池中
         */
        public void InsertIntoWaitingPool(List<Process> list)
        {
            list.ForEach(u => waitingPool.Add(u));
        }

        /**
         * 设置时间片用完后的进程状态
         */
        protected void OutOfTime(Process p) { }

        /**
         * 步长为1 tick的模拟.
         */
        public void OneTick()
        {
            waitingPool.ForEach(u => { if (u.Createtime <= Time) readyPool.Push(u);}); //将等待队列中有效的进程插入就绪序列
            if (runningPool.Count < Core) //从就绪队列中加入进程
            {
                for(int i = runningPool.Count;i < Core; i++)
                {
                    if (!readyPool.IsEmpty())
                    {
                        Process p = readyPool.Top();
                        p.Count++;
                        runningPool.Add(p);
                        readyPool.Pop();
                    }
                    else break;
                }
            }
            if (runningPool.Count > 0)
            {
                runningPool.ForEach(u => //处理每个运行的进程
                {
                    u.Needtime--;
                    u.Runningtime++;
                    if (u.Needtime == 0)//已完成
                    {
                        finishedPool.Add(u);
                        runningPool.Remove(u);
                    }
                    else if (u.Runningtime > u.Round)//到达时间片时长
                    {
                        u.Runningtime = 0;
                        OutOfTime(u);
                        readyPool.Push(u);
                        runningPool.Remove(u);
                    }
                });
            }
        }

        public async System.Threading.Tasks.Task RunAsync()
        {
            await Run();
        }

        public System.Threading.Tasks.Task<int> Run()
        {
            var task = System.Threading.Tasks.Task.Run(() =>
            {
                return 1;
            });
            return task;
        }
    }

    class PriorityProcessSimulation : ProcessSimulation
    {
        public PriorityProcessSimulation(int speed = 1, int Core = 1) : base(speed, Core)
        {
            readyPool = new Heap<Process>();
        }

        new
        protected void OutOfTime(Process p)
        {
            p.Priority -= 3;
            p.Round++;
        }

    }

    class QueueProcessSimulation : ProcessSimulation
    {
        public QueueProcessSimulation(int speed = 1, int Core = 1) : base(speed, Core)
        {
            readyPool = new PQueue<Process>();
        }

        new
        protected void OutOfTime(Process p)
        { }

    }

}
