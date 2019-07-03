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
        private void showList(ProcessSimulation result)
        {
            runningView.Items.Clear();
            readyView.Items.Clear();
            blockView.Items.Clear();
            finishView.Items.Clear();
            timeLabel.Text = result.Time.ToString();
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
                    ProcessController.CreateProcessSimulation(false,ProcessPool,100,1);
                    ProcessController.ToForm += showList;
                    runningStatus = 2;
                    statusButton.Text = "继续";
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

        }

        private void BlockButton_Click(object sender, EventArgs e)
        {

        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {

        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
