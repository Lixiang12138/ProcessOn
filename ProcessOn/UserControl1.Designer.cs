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
            this.processListView = new System.Windows.Forms.ListView();
            this.startButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.processNumNumeric = new System.Windows.Forms.NumericUpDown();
            this.processNumLabel = new System.Windows.Forms.Label();
            this.timeSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.timeSizeLabel = new System.Windows.Forms.Label();
            this.processSettingLabel = new System.Windows.Forms.Label();
            this.maxiumPriorityNumeric = new System.Windows.Forms.NumericUpDown();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.miniumPriorityNumeric = new System.Windows.Forms.NumericUpDown();
            this.dash_3 = new System.Windows.Forms.Label();
            this.randomPriorityLabel = new System.Windows.Forms.Label();
            this.maxiumrunNumeric = new System.Windows.Forms.NumericUpDown();
            this.miniumRunNumeric = new System.Windows.Forms.NumericUpDown();
            this.dash_2 = new System.Windows.Forms.Label();
            this.ramdomRunLabel = new System.Windows.Forms.Label();
            this.maxiumArrivalNumeric = new System.Windows.Forms.NumericUpDown();
            this.miniumArrivalNumeric = new System.Windows.Forms.NumericUpDown();
            this.dash_1 = new System.Windows.Forms.Label();
            this.ramdomArrivalLabel = new System.Windows.Forms.Label();
            this.randomLabel = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.algorithmLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.rateNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.processNumNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxiumPriorityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniumPriorityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxiumrunNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniumRunNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxiumArrivalNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniumArrivalNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // processListView
            // 
            this.processListView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.processListView.HideSelection = false;
            this.processListView.Location = new System.Drawing.Point(633, 212);
            this.processListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.processListView.Name = "processListView";
            this.processListView.Size = new System.Drawing.Size(563, 540);
            this.processListView.TabIndex = 60;
            this.processListView.UseCompatibleStateImageBehavior = false;
            this.processListView.SelectedIndexChanged += new System.EventHandler(this.ProcessListView_SelectedIndexChanged);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startButton.Location = new System.Drawing.Point(956, 74);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(240, 85);
            this.startButton.TabIndex = 59;
            this.startButton.Text = "开始运行";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.randomButton.Location = new System.Drawing.Point(633, 74);
            this.randomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(240, 85);
            this.randomButton.TabIndex = 58;
            this.randomButton.Text = "生成进程数据";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // processNumNumeric
            // 
            this.processNumNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.processNumNumeric.Location = new System.Drawing.Point(300, 684);
            this.processNumNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.processNumNumeric.Name = "processNumNumeric";
            this.processNumNumeric.Size = new System.Drawing.Size(160, 28);
            this.processNumNumeric.TabIndex = 57;
            this.processNumNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // processNumLabel
            // 
            this.processNumLabel.AutoSize = true;
            this.processNumLabel.Location = new System.Drawing.Point(296, 652);
            this.processNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.processNumLabel.Name = "processNumLabel";
            this.processNumLabel.Size = new System.Drawing.Size(67, 15);
            this.processNumLabel.TabIndex = 56;
            this.processNumLabel.Text = "进程个数";
            // 
            // timeSizeNumeric
            // 
            this.timeSizeNumeric.Enabled = false;
            this.timeSizeNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeSizeNumeric.Location = new System.Drawing.Point(69, 684);
            this.timeSizeNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeSizeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeSizeNumeric.Name = "timeSizeNumeric";
            this.timeSizeNumeric.Size = new System.Drawing.Size(160, 28);
            this.timeSizeNumeric.TabIndex = 53;
            this.timeSizeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timeSizeLabel
            // 
            this.timeSizeLabel.AutoSize = true;
            this.timeSizeLabel.Location = new System.Drawing.Point(65, 652);
            this.timeSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeSizeLabel.Name = "timeSizeLabel";
            this.timeSizeLabel.Size = new System.Drawing.Size(82, 15);
            this.timeSizeLabel.TabIndex = 52;
            this.timeSizeLabel.Text = "时间片长度";
            // 
            // processSettingLabel
            // 
            this.processSettingLabel.AutoSize = true;
            this.processSettingLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.processSettingLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.processSettingLabel.Location = new System.Drawing.Point(61, 595);
            this.processSettingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.processSettingLabel.Name = "processSettingLabel";
            this.processSettingLabel.Size = new System.Drawing.Size(158, 31);
            this.processSettingLabel.TabIndex = 51;
            this.processSettingLabel.Text = "基本进程设置";
            // 
            // maxiumPriorityNumeric
            // 
            this.maxiumPriorityNumeric.Enabled = this.radioButton3.Checked;
            this.maxiumPriorityNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxiumPriorityNumeric.Location = new System.Drawing.Point(300, 525);
            this.maxiumPriorityNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxiumPriorityNumeric.Name = "maxiumPriorityNumeric";
            this.maxiumPriorityNumeric.Size = new System.Drawing.Size(160, 28);
            this.maxiumPriorityNumeric.TabIndex = 50;
            this.maxiumPriorityNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton3.Location = new System.Drawing.Point(69, 144);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(248, 31);
            this.radioButton3.TabIndex = 37;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "先来先服务+时间片轮转";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // miniumPriorityNumeric
            // 
            this.miniumPriorityNumeric.Enabled = this.radioButton3.Checked;
            this.miniumPriorityNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miniumPriorityNumeric.Location = new System.Drawing.Point(69, 525);
            this.miniumPriorityNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.miniumPriorityNumeric.Name = "miniumPriorityNumeric";
            this.miniumPriorityNumeric.Size = new System.Drawing.Size(160, 28);
            this.miniumPriorityNumeric.TabIndex = 49;
            // 
            // dash_3
            // 
            this.dash_3.AutoSize = true;
            this.dash_3.Location = new System.Drawing.Point(252, 531);
            this.dash_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dash_3.Name = "dash_3";
            this.dash_3.Size = new System.Drawing.Size(15, 15);
            this.dash_3.TabIndex = 48;
            this.dash_3.Text = "-";
            // 
            // randomPriorityLabel
            // 
            this.randomPriorityLabel.AutoSize = true;
            this.randomPriorityLabel.Location = new System.Drawing.Point(65, 489);
            this.randomPriorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.randomPriorityLabel.Name = "randomPriorityLabel";
            this.randomPriorityLabel.Size = new System.Drawing.Size(52, 15);
            this.randomPriorityLabel.TabIndex = 47;
            this.randomPriorityLabel.Text = "优先数";
            // 
            // maxiumrunNumeric
            // 
            this.maxiumrunNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxiumrunNumeric.Location = new System.Drawing.Point(300, 432);
            this.maxiumrunNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxiumrunNumeric.Name = "maxiumrunNumeric";
            this.maxiumrunNumeric.Size = new System.Drawing.Size(160, 28);
            this.maxiumrunNumeric.TabIndex = 46;
            this.maxiumrunNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // miniumRunNumeric
            // 
            this.miniumRunNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miniumRunNumeric.Location = new System.Drawing.Point(69, 432);
            this.miniumRunNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.miniumRunNumeric.Name = "miniumRunNumeric";
            this.miniumRunNumeric.Size = new System.Drawing.Size(160, 28);
            this.miniumRunNumeric.TabIndex = 45;
            // 
            // dash_2
            // 
            this.dash_2.AutoSize = true;
            this.dash_2.Location = new System.Drawing.Point(252, 438);
            this.dash_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dash_2.Name = "dash_2";
            this.dash_2.Size = new System.Drawing.Size(15, 15);
            this.dash_2.TabIndex = 44;
            this.dash_2.Text = "-";
            // 
            // ramdomRunLabel
            // 
            this.ramdomRunLabel.AutoSize = true;
            this.ramdomRunLabel.Location = new System.Drawing.Point(65, 398);
            this.ramdomRunLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ramdomRunLabel.Name = "ramdomRunLabel";
            this.ramdomRunLabel.Size = new System.Drawing.Size(112, 15);
            this.ramdomRunLabel.TabIndex = 43;
            this.ramdomRunLabel.Text = "运行时钟周期数";
            // 
            // maxiumArrivalNumeric
            // 
            this.maxiumArrivalNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxiumArrivalNumeric.Location = new System.Drawing.Point(300, 339);
            this.maxiumArrivalNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxiumArrivalNumeric.Name = "maxiumArrivalNumeric";
            this.maxiumArrivalNumeric.Size = new System.Drawing.Size(160, 28);
            this.maxiumArrivalNumeric.TabIndex = 42;
            this.maxiumArrivalNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // miniumArrivalNumeric
            // 
            this.miniumArrivalNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miniumArrivalNumeric.Location = new System.Drawing.Point(69, 339);
            this.miniumArrivalNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.miniumArrivalNumeric.Name = "miniumArrivalNumeric";
            this.miniumArrivalNumeric.Size = new System.Drawing.Size(160, 28);
            this.miniumArrivalNumeric.TabIndex = 41;
            // 
            // dash_1
            // 
            this.dash_1.AutoSize = true;
            this.dash_1.Location = new System.Drawing.Point(252, 344);
            this.dash_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dash_1.Name = "dash_1";
            this.dash_1.Size = new System.Drawing.Size(15, 15);
            this.dash_1.TabIndex = 40;
            this.dash_1.Text = "-";
            // 
            // ramdomArrivalLabel
            // 
            this.ramdomArrivalLabel.AutoSize = true;
            this.ramdomArrivalLabel.Location = new System.Drawing.Point(65, 302);
            this.ramdomArrivalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ramdomArrivalLabel.Name = "ramdomArrivalLabel";
            this.ramdomArrivalLabel.Size = new System.Drawing.Size(67, 15);
            this.ramdomArrivalLabel.TabIndex = 39;
            this.ramdomArrivalLabel.Text = "到达时间";
            // 
            // randomLabel
            // 
            this.randomLabel.AutoSize = true;
            this.randomLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.randomLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.randomLabel.Location = new System.Drawing.Point(61, 245);
            this.randomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.randomLabel.Name = "randomLabel";
            this.randomLabel.Size = new System.Drawing.Size(254, 31);
            this.randomLabel.TabIndex = 38;
            this.randomLabel.Text = "设置随机进程参数范围";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton2.Location = new System.Drawing.Point(69, 191);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(328, 31);
            this.radioButton2.TabIndex = 36;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "最高优先度优先调度+时间片轮转";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1.Location = new System.Drawing.Point(69, 98);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(133, 31);
            this.radioButton1.TabIndex = 35;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "先来先服务";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // algorithmLabel
            // 
            this.algorithmLabel.AutoSize = true;
            this.algorithmLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.algorithmLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.algorithmLabel.Location = new System.Drawing.Point(61, 39);
            this.algorithmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.algorithmLabel.Name = "algorithmLabel";
            this.algorithmLabel.Size = new System.Drawing.Size(230, 31);
            this.algorithmLabel.TabIndex = 34;
            this.algorithmLabel.Text = "选择使用的调度算法";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(64, 739);
            this.rateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(97, 15);
            this.rateLabel.TabIndex = 54;
            this.rateLabel.Text = "运行速度倍率";
            // 
            // rateNumeric
            // 
            this.rateNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rateNumeric.Location = new System.Drawing.Point(68, 771);
            this.rateNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.rateNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rateNumeric.Name = "rateNumeric";
            this.rateNumeric.Size = new System.Drawing.Size(160, 28);
            this.rateNumeric.TabIndex = 55;
            this.rateNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // randomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.processListView);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.processNumNumeric);
            this.Controls.Add(this.processNumLabel);
            this.Controls.Add(this.rateNumeric);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.timeSizeNumeric);
            this.Controls.Add(this.timeSizeLabel);
            this.Controls.Add(this.processSettingLabel);
            this.Controls.Add(this.maxiumPriorityNumeric);
            this.Controls.Add(this.miniumPriorityNumeric);
            this.Controls.Add(this.dash_3);
            this.Controls.Add(this.randomPriorityLabel);
            this.Controls.Add(this.maxiumrunNumeric);
            this.Controls.Add(this.miniumRunNumeric);
            this.Controls.Add(this.dash_2);
            this.Controls.Add(this.ramdomRunLabel);
            this.Controls.Add(this.maxiumArrivalNumeric);
            this.Controls.Add(this.miniumArrivalNumeric);
            this.Controls.Add(this.dash_1);
            this.Controls.Add(this.ramdomArrivalLabel);
            this.Controls.Add(this.randomLabel);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.algorithmLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "randomControl";
            this.Size = new System.Drawing.Size(1259, 976);
            ((System.ComponentModel.ISupportInitialize)(this.processNumNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxiumPriorityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniumPriorityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxiumrunNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniumRunNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxiumArrivalNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniumArrivalNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView processListView;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.NumericUpDown processNumNumeric;
        private System.Windows.Forms.Label processNumLabel;
        private System.Windows.Forms.NumericUpDown timeSizeNumeric;
        private System.Windows.Forms.Label timeSizeLabel;
        private System.Windows.Forms.Label processSettingLabel;
        private System.Windows.Forms.NumericUpDown maxiumPriorityNumeric;
        private System.Windows.Forms.NumericUpDown miniumPriorityNumeric;
        private System.Windows.Forms.Label dash_3;
        private System.Windows.Forms.Label randomPriorityLabel;
        private System.Windows.Forms.NumericUpDown maxiumrunNumeric;
        private System.Windows.Forms.NumericUpDown miniumRunNumeric;
        private System.Windows.Forms.Label dash_2;
        private System.Windows.Forms.Label ramdomRunLabel;
        private System.Windows.Forms.NumericUpDown maxiumArrivalNumeric;
        private System.Windows.Forms.NumericUpDown miniumArrivalNumeric;
        private System.Windows.Forms.Label dash_1;
        private System.Windows.Forms.Label ramdomArrivalLabel;
        private System.Windows.Forms.Label randomLabel;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label algorithmLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.NumericUpDown rateNumeric;
    }
}
