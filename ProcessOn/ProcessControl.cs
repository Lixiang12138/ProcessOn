using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessOn
{
    public partial class ProcessControl : UserControl
    {
        public event Action ReturnButtonClicked;
        public List<Process> ProcessPool;
        #region 常量定义
        /**
         * <summary>
         *      初始状态
         * </summary>
         * */
        private const int INITIAL_STATUS = 0;
        /** 
         * <summary>
         * 运行状态
         * </summary>
         */
        private const int RUNNING_STATUS = 1;
        /**
         * <summary>
         * 暂停状态
         * </summary>
         */
        private const int PAUSE_STATUS = 2;
        #endregion
        private int _runningStatus;
        public int RunningStatus {
            get => _runningStatus;
            set
            {
                _runningStatus = value;
                if(value == PAUSE_STATUS)
                {
                    StatusButton.Text = "继续";
                }
                else
                {
                    StatusButton.Text = "暂停";
                }
            }
        }
        public int RunningType { get; set; }
        
        public ProcessControl()
        {
            InitializeComponent();
            // Set the view to show details.
            RunningView.View = View.Details;
            ReadyView.View = View.Details;
            BlockView.View = View.Details;
            FinishView.View = View.Details;
            // Allow the user to edit item text.
            RunningView.LabelEdit = true;
            ReadyView.LabelEdit = true;
            BlockView.LabelEdit = true;
            FinishView.LabelEdit = true;
            // Allow the user to rearrange columns.
            RunningView.AllowColumnReorder = true;
            ReadyView.AllowColumnReorder = true;
            BlockView.AllowColumnReorder = true;
            FinishView.AllowColumnReorder = true;
            // Display grid lines.
            RunningView.GridLines = true;
            ReadyView.GridLines = true;
            BlockView.GridLines = true;
            FinishView.GridLines = true;
            RunningView.Columns.Add("进程编号", 100, HorizontalAlignment.Left);
            RunningView.Columns.Add("优先数", 100, HorizontalAlignment.Left);
            RunningView.Columns.Add("创建时间", 100, HorizontalAlignment.Left);
            RunningView.Columns.Add("当轮用时", 100, HorizontalAlignment.Left);
            RunningView.Columns.Add("总计用时", 100, HorizontalAlignment.Left);
            RunningView.Columns.Add("所需时间", 100, HorizontalAlignment.Left);

            ReadyView.Columns.Add("进程编号", 100, HorizontalAlignment.Left);
            ReadyView.Columns.Add("优先数", 100, HorizontalAlignment.Left);
            ReadyView.Columns.Add("创建时间", 100, HorizontalAlignment.Left);
            ReadyView.Columns.Add("总计用时", 100, HorizontalAlignment.Left);
            ReadyView.Columns.Add("所需时间", 100, HorizontalAlignment.Left);

            BlockView.Columns.Add("进程编号", 100, HorizontalAlignment.Left);
            BlockView.Columns.Add("优先数", 100, HorizontalAlignment.Left);
            BlockView.Columns.Add("创建时间", 100, HorizontalAlignment.Left);
            BlockView.Columns.Add("总计用时", 100, HorizontalAlignment.Left);
            BlockView.Columns.Add("所需时间", 100, HorizontalAlignment.Left);

            FinishView.Columns.Add("进程编号", 100, HorizontalAlignment.Left);
            FinishView.Columns.Add("优先数", 100, HorizontalAlignment.Left);
            FinishView.Columns.Add("创建时间", 100, HorizontalAlignment.Left);
            FinishView.Columns.Add("总计用时", 100, HorizontalAlignment.Left);


            ProcessController.ToForm += ShowList;
        }

        public void restartList()
        {
            RunningView.Items.Clear();
            ReadyView.Items.Clear();
            BlockView.Items.Clear();
            TimeLabel.Text = "CPU时间: ";
            StatusButton.Text = "开始";
            RateNumeric.Value = 1;
            RunningStatus = INITIAL_STATUS;
        }
        private void ShowList(ProcessSimulation result)
        {
            TimeLabel.Text = "CPU时间: " + result.Time.ToString();
            EfficiencyLabel.Text = "CPU利用率：" + (result.ActualRunningTime * 1.0 / Math.Max(result.Time,1) / result.Core).ToString("0.##%");
            #region 进程表格
            RunningView.Items.Clear();
            ReadyView.Items.Clear();
            BlockView.Items.Clear();
            FinishView.Items.Clear();
            List<Process> tmpList  = result.runningPool;
            for (int i = 0; i < tmpList.Count(); i++)
            {
                ListViewItem tmp = new ListViewItem(tmpList[i].Name, 0);
                tmp.SubItems.Add(RunningType == 1 ? "-" : tmpList[i].Priority.ToString());
                tmp.SubItems.Add(tmpList[i].Createtime.ToString());
                tmp.SubItems.Add(tmpList[i].Runningtime.ToString());
                tmp.SubItems.Add((tmpList[i].Cputime - tmpList[i].Needtime).ToString());
                tmp.SubItems.Add(tmpList[i].Needtime.ToString());
                RunningView.Items.Add(tmp);
            }
            tmpList = result.readyPool.Array();
            for (int i = 0; i < tmpList.Count(); i++)
            {
                ListViewItem tmp = new ListViewItem(tmpList[i].Name, 0);
                tmp.SubItems.Add(RunningType == 1 ? "-" : tmpList[i].Priority.ToString());
                tmp.SubItems.Add(tmpList[i].Createtime.ToString());
                tmp.SubItems.Add((tmpList[i].Cputime - tmpList[i].Needtime).ToString());
                tmp.SubItems.Add(tmpList[i].Needtime.ToString());
                ReadyView.Items.Add(tmp);
            }
            tmpList = result.blockedPool;
            for (int i = 0; i < tmpList.Count(); i++)
            {
                ListViewItem tmp = new ListViewItem(tmpList[i].Name, 0);
                tmp.SubItems.Add(RunningType == 1 ? "-" : tmpList[i].Priority.ToString());
                tmp.SubItems.Add(tmpList[i].Createtime.ToString());
                tmp.SubItems.Add((tmpList[i].Cputime - tmpList[i].Needtime).ToString());
                tmp.SubItems.Add(tmpList[i].Needtime.ToString());
                BlockView.Items.Add(tmp);
            }
            tmpList = result.finishedPool;
            for (int i = 0; i < tmpList.Count(); i++)
            {
                ListViewItem tmp = new ListViewItem(tmpList[i].Name, 0);
                tmp.SubItems.Add(RunningType == 1 ? "-" : tmpList[i].Priority.ToString());
                tmp.SubItems.Add(tmpList[i].Createtime.ToString());
                tmp.SubItems.Add((tmpList[i].Cputime - tmpList[i].Needtime).ToString());
                FinishView.Items.Add(tmp);
            }
            #endregion
            #region 下拉框
            tmpList = result.runningPool;
            RunningBox.Items.Clear();
            RunningBox.Items.AddRange(tmpList.Select(u => u.Name).ToArray());

            tmpList = result.blockedPool;
            BlockBox.Items.Clear();
            BlockBox.Items.AddRange(tmpList.Select(u => u.Name).ToArray());
            #endregion
        }

        private void ProcessControl_Load(object sender, EventArgs e)
        {

        }
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            ReturnButtonClicked?.Invoke();
            RunningView.Items.Clear();
            ReadyView.Items.Clear();
            BlockView.Items.Clear();
            FinishView.Items.Clear();
            RunningStatus = INITIAL_STATUS;
        }

        private void StatusButton_Click(object sender, EventArgs e)
        {
            ProcessController.Pause();
            if (RunningStatus == RUNNING_STATUS)
                RunningStatus = PAUSE_STATUS;
            else
                RunningStatus = RUNNING_STATUS;
        }

        private void StepButton_Click(object sender, EventArgs e)
        {
            //如果是运行状态时点击单步会强制暂停
            if(RunningStatus == RUNNING_STATUS)
                ProcessController.Pause();
            RunningStatus = PAUSE_STATUS;
            ProcessController.OneTick();
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            ProcessController.Block(RunningBox.Text);
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            ProcessController.Ready(BlockBox.Text);
        }

        private void RateNumeric_ValueChanged(object sender, EventArgs e)
        {
            ProcessController.Speed((int)RateNumeric.Value);
        }
    }
}
