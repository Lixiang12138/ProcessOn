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
        public int runningStatus;

        public ProcessControl()
        {
            InitializeComponent();
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
            finishView.Columns.Add("所需时间", 100, HorizontalAlignment.Left);
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
                case 0:
                    runningStatus = 1;
                    statusButton.Text = "暂停";
                    break;
                case 1:
                    runningStatus = 2;
                    statusButton.Text = "继续";
                    break;
                case 2:
                    runningStatus = 1;
                    statusButton.Text = "暂停";
                    break;
                default:
                    break;

            }
        }
    }
}
