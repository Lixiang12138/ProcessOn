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
            this.algorithmLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.randomLabel = new System.Windows.Forms.Label();
            this.ramdomArrivalLabel = new System.Windows.Forms.Label();
            this.miniumArrivalNumeric = new System.Windows.Forms.NumericUpDown();
            this.dash_1 = new System.Windows.Forms.Label();
            this.maxiumArrivalNumeric = new System.Windows.Forms.NumericUpDown();
            this.maxiumrunNumeric = new System.Windows.Forms.NumericUpDown();
            this.miniumRunNumeric = new System.Windows.Forms.NumericUpDown();
            this.dash_2 = new System.Windows.Forms.Label();
            this.ramdomRunLabel = new System.Windows.Forms.Label();
            this.maxiumPriorityNumeric = new System.Windows.Forms.NumericUpDown();
            this.miniumPriorityNumeric = new System.Windows.Forms.NumericUpDown();
            this.dash_3 = new System.Windows.Forms.Label();
            this.randomPriorityLabel = new System.Windows.Forms.Label();
            this.processSettingLabel = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.timeSizeLabel = new System.Windows.Forms.Label();
            this.timeSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.rateNumeric = new System.Windows.Forms.NumericUpDown();
            this.rateLabel = new System.Windows.Forms.Label();
            this.processNumNumeric = new System.Windows.Forms.NumericUpDown();
            this.processNumLabel = new System.Windows.Forms.Label();
            this.randomButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.processListView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.miniumArrivalNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxiumArrivalNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxiumrunNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniumRunNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxiumPriorityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniumPriorityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processNumNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // algorithmLabel
            // 
            this.algorithmLabel.AutoSize = true;
            this.algorithmLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.algorithmLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.algorithmLabel.Location = new System.Drawing.Point(37, 29);
            this.algorithmLabel.Name = "algorithmLabel";
            this.algorithmLabel.Size = new System.Drawing.Size(230, 31);
            this.algorithmLabel.TabIndex = 1;
            this.algorithmLabel.Text = "选择使用的调度算法";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1.Location = new System.Drawing.Point(43, 76);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(133, 31);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "先来先服务";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton2.Location = new System.Drawing.Point(43, 150);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(328, 31);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "最高优先度优先调度+时间片轮转";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton3.Location = new System.Drawing.Point(43, 113);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(248, 31);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "先来先服务+时间片轮转";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // randomLabel
            // 
            this.randomLabel.AutoSize = true;
            this.randomLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.randomLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.randomLabel.Location = new System.Drawing.Point(37, 218);
            this.randomLabel.Name = "randomLabel";
            this.randomLabel.Size = new System.Drawing.Size(254, 31);
            this.randomLabel.TabIndex = 7;
            this.randomLabel.Text = "设置随机进程参数范围";
            // 
            // ramdomArrivalLabel
            // 
            this.ramdomArrivalLabel.AutoSize = true;
            this.ramdomArrivalLabel.Location = new System.Drawing.Point(40, 264);
            this.ramdomArrivalLabel.Name = "ramdomArrivalLabel";
            this.ramdomArrivalLabel.Size = new System.Drawing.Size(67, 15);
            this.ramdomArrivalLabel.TabIndex = 8;
            this.ramdomArrivalLabel.Text = "到达时间";
            // 
            // miniumArrivalNumeric
            // 
            this.miniumArrivalNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miniumArrivalNumeric.Location = new System.Drawing.Point(43, 293);
            this.miniumArrivalNumeric.Name = "miniumArrivalNumeric";
            this.miniumArrivalNumeric.Size = new System.Drawing.Size(120, 28);
            this.miniumArrivalNumeric.TabIndex = 14;
            // 
            // dash_1
            // 
            this.dash_1.AutoSize = true;
            this.dash_1.Location = new System.Drawing.Point(180, 297);
            this.dash_1.Name = "dash_1";
            this.dash_1.Size = new System.Drawing.Size(15, 15);
            this.dash_1.TabIndex = 12;
            this.dash_1.Text = "-";
            // 
            // maxiumArrivalNumeric
            // 
            this.maxiumArrivalNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxiumArrivalNumeric.Location = new System.Drawing.Point(216, 293);
            this.maxiumArrivalNumeric.Name = "maxiumArrivalNumeric";
            this.maxiumArrivalNumeric.Size = new System.Drawing.Size(120, 28);
            this.maxiumArrivalNumeric.TabIndex = 15;
            this.maxiumArrivalNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // maxiumrunNumeric
            // 
            this.maxiumrunNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxiumrunNumeric.Location = new System.Drawing.Point(216, 368);
            this.maxiumrunNumeric.Name = "maxiumrunNumeric";
            this.maxiumrunNumeric.Size = new System.Drawing.Size(120, 28);
            this.maxiumrunNumeric.TabIndex = 19;
            this.maxiumrunNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // miniumRunNumeric
            // 
            this.miniumRunNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miniumRunNumeric.Location = new System.Drawing.Point(43, 368);
            this.miniumRunNumeric.Name = "miniumRunNumeric";
            this.miniumRunNumeric.Size = new System.Drawing.Size(120, 28);
            this.miniumRunNumeric.TabIndex = 18;
            // 
            // dash_2
            // 
            this.dash_2.AutoSize = true;
            this.dash_2.Location = new System.Drawing.Point(180, 372);
            this.dash_2.Name = "dash_2";
            this.dash_2.Size = new System.Drawing.Size(15, 15);
            this.dash_2.TabIndex = 17;
            this.dash_2.Text = "-";
            // 
            // ramdomRunLabel
            // 
            this.ramdomRunLabel.AutoSize = true;
            this.ramdomRunLabel.Location = new System.Drawing.Point(40, 339);
            this.ramdomRunLabel.Name = "ramdomRunLabel";
            this.ramdomRunLabel.Size = new System.Drawing.Size(112, 15);
            this.ramdomRunLabel.TabIndex = 16;
            this.ramdomRunLabel.Text = "运行时钟周期数";
            // 
            // maxiumPriorityNumeric
            // 
            this.maxiumPriorityNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxiumPriorityNumeric.Location = new System.Drawing.Point(216, 442);
            this.maxiumPriorityNumeric.Name = "maxiumPriorityNumeric";
            this.maxiumPriorityNumeric.Size = new System.Drawing.Size(120, 28);
            this.maxiumPriorityNumeric.TabIndex = 23;
            this.maxiumPriorityNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // miniumPriorityNumeric
            // 
            this.miniumPriorityNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miniumPriorityNumeric.Location = new System.Drawing.Point(43, 442);
            this.miniumPriorityNumeric.Name = "miniumPriorityNumeric";
            this.miniumPriorityNumeric.Size = new System.Drawing.Size(120, 28);
            this.miniumPriorityNumeric.TabIndex = 22;
            // 
            // dash_3
            // 
            this.dash_3.AutoSize = true;
            this.dash_3.Location = new System.Drawing.Point(180, 446);
            this.dash_3.Name = "dash_3";
            this.dash_3.Size = new System.Drawing.Size(15, 15);
            this.dash_3.TabIndex = 21;
            this.dash_3.Text = "-";
            // 
            // randomPriorityLabel
            // 
            this.randomPriorityLabel.AutoSize = true;
            this.randomPriorityLabel.Location = new System.Drawing.Point(40, 413);
            this.randomPriorityLabel.Name = "randomPriorityLabel";
            this.randomPriorityLabel.Size = new System.Drawing.Size(52, 15);
            this.randomPriorityLabel.TabIndex = 20;
            this.randomPriorityLabel.Text = "优先数";
            // 
            // processSettingLabel
            // 
            this.processSettingLabel.AutoSize = true;
            this.processSettingLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.processSettingLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.processSettingLabel.Location = new System.Drawing.Point(37, 508);
            this.processSettingLabel.Name = "processSettingLabel";
            this.processSettingLabel.Size = new System.Drawing.Size(158, 31);
            this.processSettingLabel.TabIndex = 24;
            this.processSettingLabel.Text = "基本进程设置";
            // 
            // timeSizeLabel
            // 
            this.timeSizeLabel.AutoSize = true;
            this.timeSizeLabel.Location = new System.Drawing.Point(40, 554);
            this.timeSizeLabel.Name = "timeSizeLabel";
            this.timeSizeLabel.Size = new System.Drawing.Size(82, 15);
            this.timeSizeLabel.TabIndex = 25;
            this.timeSizeLabel.Text = "时间片长度";
            // 
            // timeSizeNumeric
            // 
            this.timeSizeNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeSizeNumeric.Location = new System.Drawing.Point(43, 579);
            this.timeSizeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeSizeNumeric.Name = "timeSizeNumeric";
            this.timeSizeNumeric.Size = new System.Drawing.Size(120, 28);
            this.timeSizeNumeric.TabIndex = 26;
            this.timeSizeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rateNumeric
            // 
            this.rateNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rateNumeric.Location = new System.Drawing.Point(43, 659);
            this.rateNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rateNumeric.Name = "rateNumeric";
            this.rateNumeric.Size = new System.Drawing.Size(120, 28);
            this.rateNumeric.TabIndex = 28;
            this.rateNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(40, 634);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(97, 15);
            this.rateLabel.TabIndex = 27;
            this.rateLabel.Text = "运行速度倍率";
            // 
            // processNumNumeric
            // 
            this.processNumNumeric.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.processNumNumeric.Location = new System.Drawing.Point(216, 579);
            this.processNumNumeric.Name = "processNumNumeric";
            this.processNumNumeric.Size = new System.Drawing.Size(120, 28);
            this.processNumNumeric.TabIndex = 30;
            this.processNumNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // processNumLabel
            // 
            this.processNumLabel.AutoSize = true;
            this.processNumLabel.Location = new System.Drawing.Point(213, 554);
            this.processNumLabel.Name = "processNumLabel";
            this.processNumLabel.Size = new System.Drawing.Size(67, 15);
            this.processNumLabel.TabIndex = 29;
            this.processNumLabel.Text = "进程个数";
            // 
            // randomButton
            // 
            this.randomButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.randomButton.Location = new System.Drawing.Point(466, 57);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(180, 68);
            this.randomButton.TabIndex = 31;
            this.randomButton.Text = "生成进程数据";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startButton.Location = new System.Drawing.Point(712, 57);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(180, 68);
            this.startButton.TabIndex = 32;
            this.startButton.Text = "开始运行";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // processListView
            // 
            this.processListView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.processListView.Location = new System.Drawing.Point(466, 168);
            this.processListView.Name = "processListView";
            this.processListView.Size = new System.Drawing.Size(540, 400);
            this.processListView.TabIndex = 33;
            this.processListView.UseCompatibleStateImageBehavior = false;
            // 
            // VirtualProcessController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 763);
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
            this.Name = "VirtualProcessController";
            this.Text = "Process Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.miniumArrivalNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxiumArrivalNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxiumrunNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniumRunNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxiumPriorityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniumPriorityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processNumNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label algorithmLabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label randomLabel;
        private System.Windows.Forms.Label ramdomArrivalLabel;
        private System.Windows.Forms.NumericUpDown miniumArrivalNumeric;
        private System.Windows.Forms.Label dash_1;
        private System.Windows.Forms.NumericUpDown maxiumArrivalNumeric;
        private System.Windows.Forms.NumericUpDown maxiumrunNumeric;
        private System.Windows.Forms.NumericUpDown miniumRunNumeric;
        private System.Windows.Forms.Label dash_2;
        private System.Windows.Forms.Label ramdomRunLabel;
        private System.Windows.Forms.NumericUpDown maxiumPriorityNumeric;
        private System.Windows.Forms.NumericUpDown miniumPriorityNumeric;
        private System.Windows.Forms.Label dash_3;
        private System.Windows.Forms.Label randomPriorityLabel;
        private System.Windows.Forms.Label processSettingLabel;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label timeSizeLabel;
        private System.Windows.Forms.NumericUpDown timeSizeNumeric;
        private System.Windows.Forms.NumericUpDown rateNumeric;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.NumericUpDown processNumNumeric;
        private System.Windows.Forms.Label processNumLabel;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListView processListView;
    }
}

