using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProcessOn
{
    public partial class randomControl : UserControl
    {
        private List<Process> ProcessData;
        public randomControl()
        {
            InitializeComponent();
            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            processListView.Columns.Add("进程编号", 100, HorizontalAlignment.Left);
            processListView.Columns.Add("到达时间", 100, HorizontalAlignment.Left);
            processListView.Columns.Add("运行时间", 100, HorizontalAlignment.Left);
            processListView.Columns.Add("初始优先数", 100, HorizontalAlignment.Left);
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            int timeLength = this.radioButton1.Checked ? -1 : (int)(this.timeSizeNumeric.Value);
            this.ProcessData = ProcessController.CreateRandomProcesses(
                (int)this.processNumNumeric.Value,
                (int)this.timeSizeNumeric.Value,
                (int)this.miniumArrivalNumeric.Value,
                (int)this.maxiumArrivalNumeric.Value,
                (int)this.miniumRunNumeric.Value,
                (int)this.maxiumrunNumeric.Value,
                (int)this.miniumPriorityNumeric.Value,
                (int)this.maxiumPriorityNumeric.Value
                );
            // Set the view to show details.
            processListView.View = View.Details;
            // Allow the user to edit item text.
            processListView.LabelEdit = true;
            // Allow the user to rearrange columns.
            processListView.AllowColumnReorder = true;
            // Display check boxes.
            //listView1.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            //listView1.FullRowSelect = true;
            // Display grid lines.
            processListView.GridLines = true;
            // Sort the items in the list in ascending order.
            // processListView.Sorting = SortOrder.Ascending;

            //Add the items to the ListView.
            processListView.Items.Clear();
            for (int i = 0; i < ProcessData.Count(); i++)
            {
                ListViewItem tmp = new ListViewItem(ProcessData[i].Name, 0);
                tmp.SubItems.Add(ProcessData[i].Createtime.ToString());
                tmp.SubItems.Add(ProcessData[i].Cputime.ToString());
                tmp.SubItems.Add(radioButton2.Checked ? ProcessData[i].Priority.ToString() : "-");
                processListView.Items.Add(tmp);
            }
            //processListView.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            // Create two ImageList objects.
            //ImageList imageListSmall = new ImageList();
            //ImageList imageListLarge = new ImageList();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.maxiumPriorityNumeric.Enabled = true;
            this.miniumPriorityNumeric.Enabled = true;
            this.timeSizeNumeric.Enabled = true;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.maxiumPriorityNumeric.Enabled = false;
            this.miniumPriorityNumeric.Enabled = false;
            this.timeSizeNumeric.Enabled = true;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.maxiumPriorityNumeric.Enabled = false;
            this.miniumPriorityNumeric.Enabled = false;
            this.timeSizeNumeric.Enabled = false;
        }
    }
}
