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
        public int runningStatus;
        public int runningType;

        public ProcessControl()
        {
            InitializeComponent();
            // Set the view to show details.
            runningView.View = View.Details;
            readyView.View = View.Details;
            blockView.View = View.Details;
            finishView.View = View.Details;
            // Allow the user to edit item text.
            runningView.LabelEdit = true;
            readyView.LabelEdit = true;
            blockView.LabelEdit = true;
            finishView.LabelEdit = true;
            // Allow the user to rearrange columns.
            runningView.AllowColumnReorder = true;
            readyView.AllowColumnReorder = true;
            blockView.AllowColumnReorder = true;
            finishView.AllowColumnReorder = true;
            // Display check boxes.
            //listView1.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            //listView1.FullRowSelect = true;
            // Display grid lines.
            runningView.GridLines = true;
            readyView.GridLines = true;
            blockView.GridLines = true;
            finishView.GridLines = true;
            runningView.Columns.Add("进程编号", 100, HorizontalAlignment.Left);
            runningView.Columns.Add("优先数", 100, HorizontalAlignment.Left);
            runningView.Columns.Add("创建时间", 100, HorizontalAlignment.Left);
            runningView.Columns.Add("当轮用时", 100, HorizontalAlignment.Left);
            runningView.Columns.Add("总计用时", 100, HorizontalAlignment.Left);
            runningView.Columns.Add("所需时间", 100, HorizontalAlignment.Left);

            readyView.Columns.Add("进程编号", 100, HorizontalAlignment.Left);
            readyView.Columns.Add("优先数", 100, HorizontalAlignment.Left);
            readyView.Columns.Add("创建时间", 100, HorizontalAlignment.Left);
            readyView.Columns.Add("总计用时", 100, HorizontalAlignment.Left);
            readyView.Columns.Add("所需时间", 100, HorizontalAlignment.Left);

            blockView.Columns.Add("进程编号", 100, HorizontalAlignment.Left);
            blockView.Columns.Add("优先数", 100, HorizontalAlignment.Left);
            blockView.Columns.Add("创建时间", 100, HorizontalAlignment.Left);
            blockView.Columns.Add("总计用时", 100, HorizontalAlignment.Left);
            blockView.Columns.Add("所需时间", 100, HorizontalAlignment.Left);

            finishView.Columns.Add("进程编号", 100, HorizontalAlignment.Left);
            finishView.Columns.Add("优先数", 100, HorizontalAlignment.Left);
            finishView.Columns.Add("创建时间", 100, HorizontalAlignment.Left);
            finishView.Columns.Add("总计用时", 100, HorizontalAlignment.Left);
        }

        public void restartList()
        {
            runningView.Items.Clear();
            readyView.Items.Clear();
            blockView.Items.Clear();
            timeLabel.Text = "CPU时间: ";
            statusButton.Text = "开始";
            rateNumeric.Value = 1;
            runningStatus = 0;
        }
        private void showList(ProcessSimulation result)
        {
            timeLabel.Text = "CPU时间: " + result.Time.ToString();
            efficiencyLabel.Text = "CPU利用率：" + (result.ActualRunningTime * 1.0 / Math.Max(result.Time,1) / result.Core).ToString("0.##%");
            #region 进程表格
            runningView.Items.Clear();
            readyView.Items.Clear();
            blockView.Items.Clear();
            finishView.Items.Clear();
            List<Process> tmpList  = result.runningPool;
            for (int i = 0; i < tmpList.Count(); i++)
            {
                ListViewItem tmp = new ListViewItem(tmpList[i].Name, 0);
                tmp.SubItems.Add(runningType == 1 ? "-" : tmpList[i].Priority.ToString());
                tmp.SubItems.Add(tmpList[i].Createtime.ToString());
                tmp.SubItems.Add(tmpList[i].Runningtime.ToString());
                tmp.SubItems.Add((tmpList[i].Cputime - tmpList[i].Needtime).ToString());
                tmp.SubItems.Add(tmpList[i].Needtime.ToString());
                runningView.Items.Add(tmp);
            }
            tmpList = result.readyPool.Array();
            for (int i = 0; i < tmpList.Count(); i++)
            {
                ListViewItem tmp = new ListViewItem(tmpList[i].Name, 0);
                tmp.SubItems.Add(runningType == 1 ? "-" : tmpList[i].Priority.ToString());
                tmp.SubItems.Add(tmpList[i].Createtime.ToString());
                tmp.SubItems.Add((tmpList[i].Cputime - tmpList[i].Needtime).ToString());
                tmp.SubItems.Add(tmpList[i].Needtime.ToString());
                readyView.Items.Add(tmp);
            }
            tmpList = result.blockedPool;
            for (int i = 0; i < tmpList.Count(); i++)
            {
                ListViewItem tmp = new ListViewItem(tmpList[i].Name, 0);
                tmp.SubItems.Add(runningType == 1 ? "-" : tmpList[i].Priority.ToString());
                tmp.SubItems.Add(tmpList[i].Createtime.ToString());
                tmp.SubItems.Add((tmpList[i].Cputime - tmpList[i].Needtime).ToString());
                tmp.SubItems.Add(tmpList[i].Needtime.ToString());
                blockView.Items.Add(tmp);
            }
            tmpList = result.finishedPool;
            for (int i = 0; i < tmpList.Count(); i++)
            {
                ListViewItem tmp = new ListViewItem(tmpList[i].Name, 0);
                tmp.SubItems.Add(runningType == 1 ? "-" : tmpList[i].Priority.ToString());
                tmp.SubItems.Add(tmpList[i].Createtime.ToString());
                tmp.SubItems.Add((tmpList[i].Cputime - tmpList[i].Needtime).ToString());
                finishView.Items.Add(tmp);
            }
            #endregion
            #region 下拉框
            tmpList = result.runningPool;
            runningBox.Items.Clear();
            runningBox.Items.AddRange(tmpList.Select(u => u.Name).ToArray());

            tmpList = result.blockedPool;
            blockBox.Items.Clear();
            blockBox.Items.AddRange(tmpList.Select(u => u.Name).ToArray());
            #endregion
        }

        private void ProcessControl_Load(object sender, EventArgs e)
        {

        }
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            ReturnButtonClicked?.Invoke();
            runningView.Items.Clear();
            readyView.Items.Clear();
            blockView.Items.Clear();
            finishView.Items.Clear();
            runningStatus = 0;
        }

        private void StatusButton_Click(object sender, EventArgs e)
        {
            switch (runningStatus)
            {
                case 1:
                    ProcessController.Pause();
                    runningStatus = 2;
                    statusButton.Text = "继续";
                    break;
                case 0:
                    ProcessController.ToForm += showList;
                    ProcessController.Pause();
                    runningStatus = 1;
                    statusButton.Text = "暂停";
                    break;
                case 2:
                    ProcessController.Pause();
                    runningStatus = 1;
                    statusButton.Text = "暂停";
                    break;
                default:
                    break;

            }
        }

        private void StepButton_Click(object sender, EventArgs e)
        {
            ProcessController.OneTick();
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            ProcessController.Block(runningBox.Text);
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            ProcessController.Ready(blockBox.Text);
        }

        private void RateNumeric_ValueChanged(object sender, EventArgs e)
        {
            ProcessController.Speed((int)rateNumeric.Value);
        }
    }
}
