using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
 
namespace ProcessOn
{
    public class ProcessSimulation
    {
        #region 调用controller
        public event Action<ProcessSimulation> OneStepWent;
        #endregion
        public List<Process> waitingPool;
        public IContainer<Process> readyPool;
        public List<Process> runningPool;
        public List<Process> finishedPool;
        public List<Process> blockedPool;

        private List<string> blockWaiting = new List<string>();
        
        private List<Process> finishedWaiting = new List<Process>();
        
        private List<Process> outOfTimeWaiting = new List<Process>();

        public int Speed { get; set; }
        public int Time { get; set; }
        public int ActualRunningTime { get; set; }
        public int Core { get; }
        public bool Pause { get; set; }
        private bool runFinished;

        public ProcessSimulation(int speed = 1,int Core = 1)
        {
            waitingPool = new List<Process>();
            runningPool = new List<Process>();
            finishedPool = new List<Process>();
            blockedPool = new List<Process>();
            Speed = speed;
            Time = 0;
            Pause = true;
            runFinished = true;
            ActualRunningTime = 0;
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
        protected virtual void OutOfTime(Process p) { }

        /**
         * <summary>
         *  阻塞当前进程
         *  </summary>
         */
        public void BlockProcess(string Name)
        {
            if (!runningPool.Exists(u => u.Name == Name))
            {
                Console.Out.WriteLine(Name + "not found!");
                return;
            }
            if (!IsStoped())//正在模拟
            {
                blockWaiting.Add(Name);
            }
            else
            {
                Process p = runningPool.SingleOrDefault(u => u.Name == Name);
                if (p.Needtime <= 0) return;
                p.State = Process.BLOCKED;
                blockedPool.Add(p);
                runningPool.Remove(p);
                Flush();
            }
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
            blockedPool.Remove(p);
            Flush();
        }

        /**
         * 暂停或继续。一旦状态从暂停变为运行，则检查模拟线程是否存在，不存在则开始模拟。
         */
        public void SetPause()
        {
            Pause = !Pause;
            if (Pause == false)
            {
                if (runFinished) RunAsync();
            }
        }

        public void SetSpeed(int speed)
        {
            Speed = speed;
        }

        /**
         * 
         */
        public void Flush()
        {
            OneStepWent?.Invoke(this);
        }

        public bool IsStoped()
        {
            return Pause == true && runFinished == true;
        }

        /**
         * 步长为1 tick的模拟.
         */
        public void OneTick()
        {
            //处理完成等待队列
            if (finishedWaiting.Count > 0)
            {
                finishedWaiting.ForEach(u =>
                {
                    if (runningPool.Exists(x => x.Name == u.Name))
                    {
                        runningPool.RemoveAll(x => x.Name == u.Name);
                        finishedPool.Add(u);
                    }
                });
                finishedWaiting.Clear();
            }
            //处理超时等待队列
            if (outOfTimeWaiting.Count > 0)
            {
                outOfTimeWaiting.ForEach(u => {
                    if (runningPool.Exists(x => x.Name == u.Name))
                    {
                        runningPool.RemoveAll(x => x.Name == u.Name);
                        readyPool.Push(u);
                    }
                });
                outOfTimeWaiting.Clear();
            }
            //处理阻塞等待队列
            if (blockWaiting.Count > 0)
            {
                blockWaiting.ForEach(u =>
                {
                    if (runningPool.Exists(x => x.Name == u))
                    {
                        Process p = runningPool.Find(x => x.Name == u);
                        blockedPool.Add(p);
                        runningPool.Remove(p);
                    }
                }
                );
                blockWaiting.Clear();
            }
            //判断是否停机
            if (waitingPool.Count == 0 && runningPool.Count == 0 && blockedPool.Count == 0 && readyPool.IsEmpty())
            {
                Pause = true;
                return;
            }
            //等待队列加入就绪队列
            waitingPool = waitingPool.SkipWhile(u => {
                if (u.Createtime <= Time)
                {
                    u.State = Process.READY;
                    readyPool.Push(u);
                    return true;
                }
                else return false;
            }).ToList();
            //就绪队列加入运行队列
            if (runningPool.Count < Core)
            {
                for (int i = runningPool.Count;i < Core; i++)
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
            //处理运行队列
            if (runningPool.Count > 0)
            {
                //处理每个运行的进程
                ActualRunningTime += runningPool.Count;
                runningPool.ForEach(u =>
                {
                    u.Needtime--;
                    u.Runningtime++;
                    if (u.Needtime <= 0)//已完成
                    {
                        u.State = Process.FINISH;
                        finishedWaiting.Add(u);
                    }
                    else if (u.Round > 0 && u.Runningtime >= u.Round)//到达时间片时长
                    {
                        u.State = Process.READY;
                        OutOfTime(u);
                        outOfTimeWaiting.Add(u);
                    }
                });
            }
            //结 束 了
            if (runningPool.Count == finishedWaiting.Count && waitingPool.Count == 0 && blockedPool.Count == 0 && readyPool.IsEmpty())
            {
                finishedWaiting.ForEach(v => {
                    runningPool.RemoveAll(x => x.Name == v.Name);
                    finishedPool.Add(v);
                });
                finishedWaiting.Clear();
            }
            Time++;
            Flush();
        }

        public async Task RunAsync()
        {
            runFinished = false;
            await Task.Run(() =>
            {
                while (!Pause)
                {
                    int WaitTime = 1000 / Speed;
                    OneTick();
                    Thread.Sleep(WaitTime);
                }
            });
            runFinished = true;
        }
    }

    class PriorityProcessSimulation : ProcessSimulation
    {
        public PriorityProcessSimulation(int speed = 1, int Core = 1) : base(speed, Core)
        {
            readyPool = new Heap<Process>();
        }

        override
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

        override
        protected void OutOfTime(Process p)
        { }

    }

}
