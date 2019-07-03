using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
namespace ProcessOn
{
    class ProcessSimulation
    {
        #region 调用controller
        public event Action<List<Process>, 
            List<Process>, List<Process>, List<Process>, List<Process>> OneStepWent;
        #endregion
        protected List<Process> waitingPool;
        protected IContainer<Process> readyPool;
        protected List<Process> runningPool;
        protected List<Process> finishedPool;
        protected List<Process> blockedPool;

        public int Speed { get; set; }
        public int Time { get; set; }
        protected int Core;
        public bool Pause { get; set; }

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
            list.Sort((u,v) => u.Createtime - v.Createtime);
            list.ForEach(u => waitingPool.Add(u));
        }

        /**
         * <summary>
         * 设置时间片用完后的进程状态
         * </summary>
         */
        protected void OutOfTime(Process p) { }

        /**
         *  阻塞当前进程
         */
        public void BlockProcess(string Name)
        {
            if (!runningPool.Exists(u => u.Name == Name))
            {
                Console.Out.WriteLine(Name + "not found!");
                return;
            }
            Process p = runningPool.SingleOrDefault(u => u.Name == Name);
            p.State = Process.BLOCKED;
            blockedPool.Add(p);
            runningPool.Remove(p);
            Flush();
        } 
    
        /**
         * 恢复阻塞的进程
         */
         public void ReadyProcess(string Name)
        {
            if (!blockedPool.Exists(u => u.Name == Name))
            {
                Console.Out.WriteLine(Name + "not found!");
                return;
            }
            Process p = blockedPool.SingleOrDefault(u => u.Name == Name);
            p.State = Process.READY;
            readyPool.Push(p);
            blockedPool.Add(p);
            Flush();
        }

        /**
         * 
         */
        public void Flush()
        {
            OneStepWent?.Invoke(waitingPool, readyPool.Array(), runningPool, finishedPool, blockedPool);
        }

        /**
         * 步长为1 tick的模拟.
         */
        public void OneTick()
        {
            if (waitingPool.Count == 0 && runningPool.Count == 0 && blockedPool.Count == 0 && readyPool.IsEmpty())
            {
                Pause = true;
                return;
            }
            waitingPool = waitingPool.SkipWhile(u => {
                if (u.Createtime <= Time)
                {
                    u.State = Process.READY;
                    readyPool.Push(u);
                    return false;
                }
                else return true;
            }).ToList();//将等待队列中有效的进程插入就绪序列
            if (runningPool.Count < Core) //从就绪队列中加入进程
            {
                for(int i = runningPool.Count;i < Core; i++)
                {
                    if (!readyPool.IsEmpty())
                    {
                        Process p = readyPool.Top();
                        p.State = Process.RUNNING;
                        p.Runningtime = 0;
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
                        u.State = Process.FINISH;
                        finishedPool.Add(u);
                        runningPool.Remove(u);
                    }
                    else if (u.Round > 0 && u.Runningtime > u.Round)//到达时间片时长
                    {
                        u.State = Process.READY;
                        OutOfTime(u);
                        readyPool.Push(u);
                        runningPool.Remove(u);
                    }
                });
            }
            Flush();
        }

        public async void RunAsync()
        {
            await Task.Run(() =>
            {
                int WaitTime = 1000 / Speed;
                while (!Pause)
                {
                    OneTick();
                    Thread.Sleep(WaitTime);
                }
            });
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
