using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessOn
{
    public partial class VirtualProcessController : Form
    {
        public VirtualProcessController()
        {
            InitializeComponent();
            this.UserControl1.StartButtonClicked += ShowProcessPanel;
            this.ProcessControl.ReturnButtonClicked += ShowMainPanel;
        }

        private void ShowProcessPanel()
        {
            this.panel1.Hide();
            this.ProcessPanel.Show();
            this.ProcessControl.RunningType = this.UserControl1.runningType;
            this.ProcessControl.ProcessPool = this.UserControl1.ProcessData;
        }
        private void ShowMainPanel()
        {
            this.panel1.Show();
            this.ProcessPanel.Hide();
            ProcessController.Shut();
            this.ProcessControl.restartList();
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
