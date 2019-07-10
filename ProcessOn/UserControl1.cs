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
    public partial class randomControl : UserControl
    {
        public List<Process> ProcessData;
        public int runningType;
        public event Action StartButtonClicked;
        public randomControl()
        {
            InitializeComponent();
            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            ProcessListView.Columns.Add("进程编号", 100, HorizontalAlignment.Left);
            ProcessListView.Columns.Add("到达时间", 100, HorizontalAlignment.Left);
            ProcessListView.Columns.Add("运行时间", 100, HorizontalAlignment.Left);
            ProcessListView.Columns.Add("初始优先数", 100, HorizontalAlignment.Left);
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            int timeLength = this.RadioButton1.Checked ? -1 : (int)(this.TimeSizeNumeric.Value);
            this.ProcessData = ProcessController.CreateRandomProcesses(
                (int)this.ProcessNumNumeric.Value,
                timeLength,
                (int)this.MiniumArrivalNumeric.Value,
                (int)this.MaxiumArrivalNumeric.Value,
                (int)this.MiniumRunNumeric.Value,
                (int)this.MaxiumrunNumeric.Value,
                (int)this.MiniumPriorityNumeric.Value,
                (int)this.MaxiumPriorityNumeric.Value
                );
            // Set the view to show details.
            ProcessListView.View = View.Details;
            // Allow the user to edit item text.
            ProcessListView.LabelEdit = true;
            // Allow the user to rearrange columns.
            ProcessListView.AllowColumnReorder = true;
            // Display grid lines.
            ProcessListView.GridLines = true;

            //Add the items to the ListView.
            ProcessListView.Items.Clear();
            for(int i=0;i<ProcessData.Count();i++)
            {
                ListViewItem tmp = new ListViewItem(ProcessData[i].Name, 0);
                tmp.SubItems.Add(ProcessData[i].Createtime.ToString());
                tmp.SubItems.Add(ProcessData[i].Cputime.ToString());
                tmp.SubItems.Add(runningType==3 ? ProcessData[i].Priority.ToString() : "-");
                ProcessListView.Items.Add(tmp);
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.MaxiumPriorityNumeric.Enabled = true;
            this.MiniumPriorityNumeric.Enabled = true;
            this.TimeSizeNumeric.Enabled = true;
            this.runningType = 3;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.MaxiumPriorityNumeric.Enabled = false;
            this.MiniumPriorityNumeric.Enabled = false;
            this.TimeSizeNumeric.Enabled = true;
            this.runningType = 2;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.MaxiumPriorityNumeric.Enabled = false;
            this.MiniumPriorityNumeric.Enabled = false;
            this.TimeSizeNumeric.Enabled = false;
            this.runningType = 1;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButtonClicked?.Invoke();
            List<Process> CopyProcessData = new List<Process>();
            ProcessData.ForEach((u) =>
            {
                CopyProcessData.Add(new Process(u));
            });
            ProcessController.CreateProcessSimulation(runningType==3, CopyProcessData, 1, (int)CoreNumeric.Value);
        }

        private void ProcessListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CoreNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RandomControl_Load(object sender, EventArgs e)
        {

        }
    }
}
