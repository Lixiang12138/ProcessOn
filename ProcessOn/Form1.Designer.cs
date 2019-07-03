using System;
using System.Windows.Forms;

namespace ProcessOn
{
    partial class VirtualProcessController
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserControl1 = new ProcessOn.randomControl();
            this.ProcessPanel = new System.Windows.Forms.Panel();
            this.ProcessControl = new ProcessOn.ProcessControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UserControl1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 976);
            this.panel1.TabIndex = 0;
            // 
            // UserControl1
            // 
            this.UserControl1.Location = new System.Drawing.Point(0, 0);
            this.UserControl1.Name = "UserControl1";
            this.UserControl1.Size = new System.Drawing.Size(1259, 976);
            this.UserControl1.TabIndex = 0;
            this.UserControl1.Load += new System.EventHandler(this.UserControl1_Load);
            this.UserControl1.StartButtonClicked += ShowProcessPanel;
            // 
            // ProcessPanel
            // 
            this.ProcessPanel.Controls.Add(this.ProcessControl);
            this.ProcessPanel.Location = new System.Drawing.Point(1, 0);
            this.ProcessPanel.Name = "ProcessPanel";
            this.ProcessPanel.Size = new System.Drawing.Size(1259, 976);
            this.ProcessPanel.TabIndex = 1;
            this.ProcessControl.ReturnButtonClicked += ShowMainPanel;
            // 
            // VirtualProcessController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProcessPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VirtualProcessController";
            this.Text = "Process Controller";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private void ShowProcessPanel()
        {
            this.panel1.Hide();
            this.ProcessPanel.Show();
            this.ProcessControl.runningType = this.UserControl1.runningType;
            this.ProcessControl.ProcessPool = this.UserControl1.ProcessData;
        }
        private void ShowMainPanel()
        {
            this.panel1.Show();
            this.ProcessPanel.Hide();
        }
        #endregion
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Panel panel1;
        private randomControl UserControl1;
        private Panel ProcessPanel;
        private ProcessControl ProcessControl;
    }
}

