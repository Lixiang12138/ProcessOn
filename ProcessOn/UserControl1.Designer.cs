using System;

namespace ProcessOn
{
    partial class randomControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ProcessListView = new System.Windows.Forms.ListView();
            this.StartButton = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.ProcessNumNumeric = new System.Windows.Forms.NumericUpDown();
            this.ProcessNumLabel = new System.Windows.Forms.Label();
            this.TimeSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.TimeSizeLabel = new System.Windows.Forms.Label();
            this.ProcessSettingLabel = new System.Windows.Forms.Label();
            this.MaxiumPriorityNumeric = new System.Windows.Forms.NumericUpDown();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.MiniumPriorityNumeric = new System.Windows.Forms.NumericUpDown();
            this.Dash_3 = new System.Windows.Forms.Label();
            this.RandomPriorityLabel = new System.Windows.Forms.Label();
            this.MaxiumrunNumeric = new System.Windows.Forms.NumericUpDown();
            this.MiniumRunNumeric = new System.Windows.Forms.NumericUpDown();
            this.Dash_2 = new System.Windows.Forms.Label();
            this.RamdomRunLabel = new System.Windows.Forms.Label();
            this.MaxiumArrivalNumeric = new System.Windows.Forms.NumericUpDown();
            this.MiniumArrivalNumeric = new System.Windows.Forms.NumericUpDown();
            this.Dash_1 = new System.Windows.Forms.Label();
            this.RamdomArrivalLabel = new System.Windows.Forms.Label();
            this.RandomLabel = new System.Windows.Forms.Label();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.AlgorithmLabel = new System.Windows.Forms.Label();
            this.CoreNumeric = new System.Windows.Forms.NumericUpDown();
            this.CoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessNumNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxiumPriorityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniumPriorityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxiumrunNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniumRunNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxiumArrivalNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniumArrivalNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoreNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // processListView
            // 
            this.ProcessListView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProcessListView.HideSelection = false;
            this.ProcessListView.Location = new System.Drawing.Point(633, 212);
            this.ProcessListView.Margin = new System.Windows.Forms.Padding(4);
            this.ProcessListView.Name = "processListView";
            this.ProcessListView.Size = new System.Drawing.Size(563, 540);
            this.ProcessListView.TabIndex = 60;
            this.ProcessListView.UseCompatibleStateImageBehavior = false;
            this.ProcessListView.SelectedIndexChanged += new System.EventHandler(this.ProcessListView_SelectedIndexChanged);
            // 
            // startButton
            // 
            this.StartButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartButton.Location = new System.Drawing.Point(956, 74);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "startButton";
            this.StartButton.Size = new System.Drawing.Size(240, 85);
            this.StartButton.TabIndex = 59;
            this.StartButton.Text = "开始运行";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // randomButton
            // 
            this.RandomButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RandomButton.Location = new System.Drawing.Point(633, 74);
            this.RandomButton.Margin = new System.Windows.Forms.Padding(4);
            this.RandomButton.Name = "randomButton";
            this.RandomButton.Size = new System.Drawing.Size(240, 85);
            this.RandomButton.TabIndex = 58;
            this.RandomButton.Text = "生成进程数据";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // processNumNumeric
            // 
            this.ProcessNumNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProcessNumNumeric.Location = new System.Drawing.Point(300, 684);
            this.ProcessNumNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.ProcessNumNumeric.Name = "processNumNumeric";
            this.ProcessNumNumeric.Size = new System.Drawing.Size(160, 28);
            this.ProcessNumNumeric.TabIndex = 57;
            this.ProcessNumNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // processNumLabel
            // 
            this.ProcessNumLabel.AutoSize = true;
            this.ProcessNumLabel.Location = new System.Drawing.Point(296, 652);
            this.ProcessNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProcessNumLabel.Name = "processNumLabel";
            this.ProcessNumLabel.Size = new System.Drawing.Size(67, 15);
            this.ProcessNumLabel.TabIndex = 56;
            this.ProcessNumLabel.Text = "进程个数";
            // 
            // timeSizeNumeric
            // 
            this.TimeSizeNumeric.Enabled = false;
            this.TimeSizeNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeSizeNumeric.Location = new System.Drawing.Point(69, 684);
            this.TimeSizeNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.TimeSizeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimeSizeNumeric.Name = "timeSizeNumeric";
            this.TimeSizeNumeric.Size = new System.Drawing.Size(160, 28);
            this.TimeSizeNumeric.TabIndex = 53;
            this.TimeSizeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timeSizeLabel
            // 
            this.TimeSizeLabel.AutoSize = true;
            this.TimeSizeLabel.Location = new System.Drawing.Point(65, 652);
            this.TimeSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeSizeLabel.Name = "timeSizeLabel";
            this.TimeSizeLabel.Size = new System.Drawing.Size(82, 15);
            this.TimeSizeLabel.TabIndex = 52;
            this.TimeSizeLabel.Text = "时间片长度";
            // 
            // processSettingLabel
            // 
            this.ProcessSettingLabel.AutoSize = true;
            this.ProcessSettingLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.ProcessSettingLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProcessSettingLabel.Location = new System.Drawing.Point(61, 595);
            this.ProcessSettingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProcessSettingLabel.Name = "processSettingLabel";
            this.ProcessSettingLabel.Size = new System.Drawing.Size(158, 31);
            this.ProcessSettingLabel.TabIndex = 51;
            this.ProcessSettingLabel.Text = "基本进程设置";
            // 
            // MaxiumPriorityNumeric
            // 
            this.MaxiumPriorityNumeric.Enabled = this.RadioButton3.Checked;
            this.MaxiumPriorityNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaxiumPriorityNumeric.Location = new System.Drawing.Point(300, 525);
            this.MaxiumPriorityNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.MaxiumPriorityNumeric.Name = "MaxiumPriorityNumeric";
            this.MaxiumPriorityNumeric.Size = new System.Drawing.Size(160, 28);
            this.MaxiumPriorityNumeric.TabIndex = 50;
            this.MaxiumPriorityNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // radioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioButton3.Location = new System.Drawing.Point(69, 144);
            this.RadioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton3.Name = "radioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(248, 31);
            this.RadioButton3.TabIndex = 37;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "先来先服务+时间片轮转";
            this.RadioButton3.UseVisualStyleBackColor = true;
            this.RadioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // miniumPriorityNumeric
            // 
            this.MiniumPriorityNumeric.Enabled = this.RadioButton3.Checked;
            this.MiniumPriorityNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MiniumPriorityNumeric.Location = new System.Drawing.Point(69, 525);
            this.MiniumPriorityNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.MiniumPriorityNumeric.Name = "miniumPriorityNumeric";
            this.MiniumPriorityNumeric.Size = new System.Drawing.Size(160, 28);
            this.MiniumPriorityNumeric.TabIndex = 49;
            // 
            // dash_3
            // 
            this.Dash_3.AutoSize = true;
            this.Dash_3.Location = new System.Drawing.Point(252, 531);
            this.Dash_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dash_3.Name = "dash_3";
            this.Dash_3.Size = new System.Drawing.Size(15, 15);
            this.Dash_3.TabIndex = 48;
            this.Dash_3.Text = "-";
            // 
            // randomPriorityLabel
            // 
            this.RandomPriorityLabel.AutoSize = true;
            this.RandomPriorityLabel.Location = new System.Drawing.Point(65, 489);
            this.RandomPriorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RandomPriorityLabel.Name = "randomPriorityLabel";
            this.RandomPriorityLabel.Size = new System.Drawing.Size(52, 15);
            this.RandomPriorityLabel.TabIndex = 47;
            this.RandomPriorityLabel.Text = "优先数";
            // 
            // maxiumrunNumeric
            // 
            this.MaxiumrunNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaxiumrunNumeric.Location = new System.Drawing.Point(300, 432);
            this.MaxiumrunNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.MaxiumrunNumeric.Name = "maxiumrunNumeric";
            this.MaxiumrunNumeric.Size = new System.Drawing.Size(160, 28);
            this.MaxiumrunNumeric.TabIndex = 46;
            this.MaxiumrunNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // miniumRunNumeric
            // 
            this.MiniumRunNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MiniumRunNumeric.Location = new System.Drawing.Point(69, 432);
            this.MiniumRunNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.MiniumRunNumeric.Name = "miniumRunNumeric";
            this.MiniumRunNumeric.Size = new System.Drawing.Size(160, 28);
            this.MiniumRunNumeric.TabIndex = 45;
            this.MiniumRunNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dash_2
            // 
            this.Dash_2.AutoSize = true;
            this.Dash_2.Location = new System.Drawing.Point(252, 438);
            this.Dash_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dash_2.Name = "dash_2";
            this.Dash_2.Size = new System.Drawing.Size(15, 15);
            this.Dash_2.TabIndex = 44;
            this.Dash_2.Text = "-";
            // 
            // ramdomRunLabel
            // 
            this.RamdomRunLabel.AutoSize = true;
            this.RamdomRunLabel.Location = new System.Drawing.Point(65, 398);
            this.RamdomRunLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RamdomRunLabel.Name = "ramdomRunLabel";
            this.RamdomRunLabel.Size = new System.Drawing.Size(112, 15);
            this.RamdomRunLabel.TabIndex = 43;
            this.RamdomRunLabel.Text = "运行时钟周期数";
            // 
            // maxiumArrivalNumeric
            // 
            this.MaxiumArrivalNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaxiumArrivalNumeric.Location = new System.Drawing.Point(300, 339);
            this.MaxiumArrivalNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.MaxiumArrivalNumeric.Name = "maxiumArrivalNumeric";
            this.MaxiumArrivalNumeric.Size = new System.Drawing.Size(160, 28);
            this.MaxiumArrivalNumeric.TabIndex = 42;
            this.MaxiumArrivalNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // miniumArrivalNumeric
            // 
            this.MiniumArrivalNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MiniumArrivalNumeric.Location = new System.Drawing.Point(69, 339);
            this.MiniumArrivalNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.MiniumArrivalNumeric.Name = "miniumArrivalNumeric";
            this.MiniumArrivalNumeric.Size = new System.Drawing.Size(160, 28);
            this.MiniumArrivalNumeric.TabIndex = 41;
            // 
            // dash_1
            // 
            this.Dash_1.AutoSize = true;
            this.Dash_1.Location = new System.Drawing.Point(252, 344);
            this.Dash_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dash_1.Name = "dash_1";
            this.Dash_1.Size = new System.Drawing.Size(15, 15);
            this.Dash_1.TabIndex = 40;
            this.Dash_1.Text = "-";
            // 
            // ramdomArrivalLabel
            // 
            this.RamdomArrivalLabel.AutoSize = true;
            this.RamdomArrivalLabel.Location = new System.Drawing.Point(65, 302);
            this.RamdomArrivalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RamdomArrivalLabel.Name = "ramdomArrivalLabel";
            this.RamdomArrivalLabel.Size = new System.Drawing.Size(67, 15);
            this.RamdomArrivalLabel.TabIndex = 39;
            this.RamdomArrivalLabel.Text = "到达时间";
            // 
            // randomLabel
            // 
            this.RandomLabel.AutoSize = true;
            this.RandomLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.RandomLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RandomLabel.Location = new System.Drawing.Point(61, 245);
            this.RandomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RandomLabel.Name = "randomLabel";
            this.RandomLabel.Size = new System.Drawing.Size(254, 31);
            this.RandomLabel.TabIndex = 38;
            this.RandomLabel.Text = "设置随机进程参数范围";
            // 
            // radioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioButton2.Location = new System.Drawing.Point(69, 191);
            this.RadioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton2.Name = "radioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(328, 31);
            this.RadioButton2.TabIndex = 36;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "最高优先度优先调度+时间片轮转";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Checked = true;
            this.RadioButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioButton1.Location = new System.Drawing.Point(69, 98);
            this.RadioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton1.Name = "radioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(133, 31);
            this.RadioButton1.TabIndex = 35;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "先来先服务";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // algorithmLabel
            // 
            this.AlgorithmLabel.AutoSize = true;
            this.AlgorithmLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.AlgorithmLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AlgorithmLabel.Location = new System.Drawing.Point(61, 39);
            this.AlgorithmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlgorithmLabel.Name = "algorithmLabel";
            this.AlgorithmLabel.Size = new System.Drawing.Size(230, 31);
            this.AlgorithmLabel.TabIndex = 34;
            this.AlgorithmLabel.Text = "选择使用的调度算法";
            // 
            // coreNumeric
            // 
            this.CoreNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CoreNumeric.Location = new System.Drawing.Point(67, 769);
            this.CoreNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.CoreNumeric.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.CoreNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CoreNumeric.Name = "coreNumeric";
            this.CoreNumeric.Size = new System.Drawing.Size(160, 28);
            this.CoreNumeric.TabIndex = 62;
            this.CoreNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CoreNumeric.ValueChanged += new System.EventHandler(this.CoreNumeric_ValueChanged);
            // 
            // coreLabel
            // 
            this.CoreLabel.AutoSize = true;
            this.CoreLabel.Location = new System.Drawing.Point(63, 737);
            this.CoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CoreLabel.Name = "coreLabel";
            this.CoreLabel.Size = new System.Drawing.Size(67, 15);
            this.CoreLabel.TabIndex = 61;
            this.CoreLabel.Text = "核心个数";
            // 
            // randomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CoreNumeric);
            this.Controls.Add(this.CoreLabel);
            this.Controls.Add(this.ProcessListView);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.ProcessNumNumeric);
            this.Controls.Add(this.ProcessNumLabel);
            this.Controls.Add(this.TimeSizeNumeric);
            this.Controls.Add(this.TimeSizeLabel);
            this.Controls.Add(this.ProcessSettingLabel);
            this.Controls.Add(this.MaxiumPriorityNumeric);
            this.Controls.Add(this.MiniumPriorityNumeric);
            this.Controls.Add(this.Dash_3);
            this.Controls.Add(this.RandomPriorityLabel);
            this.Controls.Add(this.MaxiumrunNumeric);
            this.Controls.Add(this.MiniumRunNumeric);
            this.Controls.Add(this.Dash_2);
            this.Controls.Add(this.RamdomRunLabel);
            this.Controls.Add(this.MaxiumArrivalNumeric);
            this.Controls.Add(this.MiniumArrivalNumeric);
            this.Controls.Add(this.Dash_1);
            this.Controls.Add(this.RamdomArrivalLabel);
            this.Controls.Add(this.RandomLabel);
            this.Controls.Add(this.RadioButton3);
            this.Controls.Add(this.RadioButton2);
            this.Controls.Add(this.RadioButton1);
            this.Controls.Add(this.AlgorithmLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "randomControl";
            this.Size = new System.Drawing.Size(1259, 976);
            this.Load += new System.EventHandler(this.RandomControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessNumNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxiumPriorityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniumPriorityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxiumrunNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniumRunNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxiumArrivalNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniumArrivalNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoreNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ProcessListView;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.NumericUpDown ProcessNumNumeric;
        private System.Windows.Forms.Label ProcessNumLabel;
        private System.Windows.Forms.NumericUpDown TimeSizeNumeric;
        private System.Windows.Forms.Label TimeSizeLabel;
        private System.Windows.Forms.Label ProcessSettingLabel;
        private System.Windows.Forms.NumericUpDown MaxiumPriorityNumeric;
        private System.Windows.Forms.NumericUpDown MiniumPriorityNumeric;
        private System.Windows.Forms.Label Dash_3;
        private System.Windows.Forms.Label RandomPriorityLabel;
        private System.Windows.Forms.NumericUpDown MaxiumrunNumeric;
        private System.Windows.Forms.NumericUpDown MiniumRunNumeric;
        private System.Windows.Forms.Label Dash_2;
        private System.Windows.Forms.Label RamdomRunLabel;
        private System.Windows.Forms.NumericUpDown MaxiumArrivalNumeric;
        private System.Windows.Forms.NumericUpDown MiniumArrivalNumeric;
        private System.Windows.Forms.Label Dash_1;
        private System.Windows.Forms.Label RamdomArrivalLabel;
        private System.Windows.Forms.Label RandomLabel;
        private System.Windows.Forms.RadioButton RadioButton3;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.Label AlgorithmLabel;
        private System.Windows.Forms.NumericUpDown CoreNumeric;
        private System.Windows.Forms.Label CoreLabel;
    }
}
