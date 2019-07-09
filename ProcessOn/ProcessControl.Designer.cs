namespace ProcessOn
{
    partial class ProcessControl
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
            this.ProcessLabel = new System.Windows.Forms.Label();
            this.StatusButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.RunningLabel = new System.Windows.Forms.Label();
            this.ReadyLabel = new System.Windows.Forms.Label();
            this.BlockLabel = new System.Windows.Forms.Label();
            this.FinishLabel = new System.Windows.Forms.Label();
            this.StepButton = new System.Windows.Forms.Button();
            this.RateNumeric = new System.Windows.Forms.NumericUpDown();
            this.RateLabel = new System.Windows.Forms.Label();
            this.BlockButton = new System.Windows.Forms.Button();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.RunningView = new System.Windows.Forms.ListView();
            this.ReadyView = new System.Windows.Forms.ListView();
            this.BlockView = new System.Windows.Forms.ListView();
            this.FinishView = new System.Windows.Forms.ListView();
            this.BlockBox = new System.Windows.Forms.ComboBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.EfficiencyLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.RunningBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.RateNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessLabel
            // 
            this.ProcessLabel.AutoSize = true;
            this.ProcessLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.ProcessLabel.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProcessLabel.Location = new System.Drawing.Point(522, 18);
            this.ProcessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProcessLabel.Name = "ProcessLabel";
            this.ProcessLabel.Size = new System.Drawing.Size(239, 36);
            this.ProcessLabel.TabIndex = 35;
            this.ProcessLabel.Text = "系统进程运行状态";
            // 
            // statusButton
            // 
            this.StatusButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StatusButton.Location = new System.Drawing.Point(1040, 170);
            this.StatusButton.Name = "statusButton";
            this.StatusButton.Size = new System.Drawing.Size(125, 50);
            this.StatusButton.TabIndex = 36;
            this.StatusButton.Text = "开始";
            this.StatusButton.UseVisualStyleBackColor = true;
            this.StatusButton.Click += new System.EventHandler(this.StatusButton_Click);
            // 
            // returnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnButton.ForeColor = System.Drawing.Color.Red;
            this.ReturnButton.Location = new System.Drawing.Point(1040, 762);
            this.ReturnButton.Name = "returnButton";
            this.ReturnButton.Size = new System.Drawing.Size(125, 49);
            this.ReturnButton.TabIndex = 40;
            this.ReturnButton.Text = "终止";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // runningLabel
            // 
            this.RunningLabel.AutoSize = true;
            this.RunningLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.RunningLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RunningLabel.Location = new System.Drawing.Point(39, 37);
            this.RunningLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RunningLabel.Name = "runningLabel";
            this.RunningLabel.Size = new System.Drawing.Size(110, 31);
            this.RunningLabel.TabIndex = 41;
            this.RunningLabel.Text = "正在运行";
            // 
            // readyLabel
            // 
            this.ReadyLabel.AutoSize = true;
            this.ReadyLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.ReadyLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReadyLabel.Location = new System.Drawing.Point(39, 257);
            this.ReadyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReadyLabel.Name = "readyLabel";
            this.ReadyLabel.Size = new System.Drawing.Size(86, 31);
            this.ReadyLabel.TabIndex = 42;
            this.ReadyLabel.Text = "已就绪";
            // 
            // blockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.BlockLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BlockLabel.Location = new System.Drawing.Point(39, 477);
            this.BlockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BlockLabel.Name = "blockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(86, 31);
            this.BlockLabel.TabIndex = 43;
            this.BlockLabel.Text = "阻塞中";
            // 
            // finishLabel
            // 
            this.FinishLabel.AutoSize = true;
            this.FinishLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.FinishLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FinishLabel.Location = new System.Drawing.Point(39, 597);
            this.FinishLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FinishLabel.Name = "finishLabel";
            this.FinishLabel.Size = new System.Drawing.Size(86, 31);
            this.FinishLabel.TabIndex = 44;
            this.FinishLabel.Text = "已完成";
            // 
            // stepButton
            // 
            this.StepButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StepButton.Location = new System.Drawing.Point(1041, 270);
            this.StepButton.Name = "stepButton";
            this.StepButton.Size = new System.Drawing.Size(125, 50);
            this.StepButton.TabIndex = 45;
            this.StepButton.Text = "单步运行";
            this.StepButton.UseVisualStyleBackColor = true;
            this.StepButton.Click += new System.EventHandler(this.StepButton_Click);
            // 
            // rateNumeric
            // 
            this.RateNumeric.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RateNumeric.Location = new System.Drawing.Point(1041, 687);
            this.RateNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.RateNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RateNumeric.Name = "rateNumeric";
            this.RateNumeric.Size = new System.Drawing.Size(160, 30);
            this.RateNumeric.TabIndex = 57;
            this.RateNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RateNumeric.ValueChanged += new System.EventHandler(this.RateNumeric_ValueChanged);
            // 
            // rateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RateLabel.Location = new System.Drawing.Point(1035, 638);
            this.RateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RateLabel.Name = "rateLabel";
            this.RateLabel.Size = new System.Drawing.Size(92, 27);
            this.RateLabel.TabIndex = 56;
            this.RateLabel.Text = "运行速度";
            // 
            // blockButton
            // 
            this.BlockButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BlockButton.Location = new System.Drawing.Point(1041, 403);
            this.BlockButton.Name = "blockButton";
            this.BlockButton.Size = new System.Drawing.Size(160, 50);
            this.BlockButton.TabIndex = 58;
            this.BlockButton.Text = "阻塞当前进程";
            this.BlockButton.UseVisualStyleBackColor = true;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // readyButton
            // 
            this.ReadyButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReadyButton.Location = new System.Drawing.Point(1041, 541);
            this.ReadyButton.Name = "readyButton";
            this.ReadyButton.Size = new System.Drawing.Size(160, 50);
            this.ReadyButton.TabIndex = 59;
            this.ReadyButton.Text = "就绪选中进程";
            this.ReadyButton.UseVisualStyleBackColor = true;
            this.ReadyButton.Click += new System.EventHandler(this.ReadyButton_Click);
            // 
            // runningView
            // 
            this.RunningView.Location = new System.Drawing.Point(45, 71);
            this.RunningView.Name = "runningView";
            this.RunningView.Size = new System.Drawing.Size(924, 180);
            this.RunningView.TabIndex = 60;
            this.RunningView.UseCompatibleStateImageBehavior = false;
            // 
            // ReadyView
            // 
            this.ReadyView.Location = new System.Drawing.Point(45, 291);
            this.ReadyView.Name = "ReadyView";
            this.ReadyView.Size = new System.Drawing.Size(924, 180);
            this.ReadyView.TabIndex = 61;
            this.ReadyView.UseCompatibleStateImageBehavior = false;
            // 
            // blockView
            // 
            this.BlockView.Location = new System.Drawing.Point(45, 511);
            this.BlockView.Name = "blockView";
            this.BlockView.Size = new System.Drawing.Size(924, 80);
            this.BlockView.TabIndex = 62;
            this.BlockView.UseCompatibleStateImageBehavior = false;
            // 
            // finishView
            // 
            this.FinishView.Location = new System.Drawing.Point(45, 631);
            this.FinishView.Name = "finishView";
            this.FinishView.Size = new System.Drawing.Size(924, 180);
            this.FinishView.TabIndex = 63;
            this.FinishView.UseCompatibleStateImageBehavior = false;
            // 
            // blockBox
            // 
            this.BlockBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BlockBox.FormattingEnabled = true;
            this.BlockBox.Location = new System.Drawing.Point(1041, 500);
            this.BlockBox.Name = "blockBox";
            this.BlockBox.Size = new System.Drawing.Size(160, 35);
            this.BlockBox.TabIndex = 64;
            this.BlockBox.Text = "请选择进程";
            // 
            // timeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.TimeLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeLabel.Location = new System.Drawing.Point(998, 30);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "timeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(135, 31);
            this.TimeLabel.TabIndex = 65;
            this.TimeLabel.Text = "CPU时间：";
            // 
            // efficiencyLabel
            // 
            this.EfficiencyLabel.AutoSize = true;
            this.EfficiencyLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.EfficiencyLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EfficiencyLabel.Location = new System.Drawing.Point(998, 70);
            this.EfficiencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EfficiencyLabel.Name = "efficiencyLabel";
            this.EfficiencyLabel.Size = new System.Drawing.Size(159, 31);
            this.EfficiencyLabel.TabIndex = 66;
            this.EfficiencyLabel.Text = "CPU利用率：";
            // 
            // sizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.SizeLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SizeLabel.Location = new System.Drawing.Point(998, 110);
            this.SizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SizeLabel.Name = "sizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(158, 31);
            this.SizeLabel.TabIndex = 67;
            this.SizeLabel.Text = "时间片长度：";
            // 
            // runningBox
            // 
            this.RunningBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RunningBox.FormattingEnabled = true;
            this.RunningBox.Location = new System.Drawing.Point(1041, 362);
            this.RunningBox.Name = "runningBox";
            this.RunningBox.Size = new System.Drawing.Size(160, 35);
            this.RunningBox.TabIndex = 68;
            this.RunningBox.Text = "请选择进程";
            // 
            // ProcessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RunningBox);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.EfficiencyLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.BlockBox);
            this.Controls.Add(this.FinishView);
            this.Controls.Add(this.BlockView);
            this.Controls.Add(this.ReadyView);
            this.Controls.Add(this.RunningView);
            this.Controls.Add(this.ReadyButton);
            this.Controls.Add(this.BlockButton);
            this.Controls.Add(this.RateNumeric);
            this.Controls.Add(this.RateLabel);
            this.Controls.Add(this.StepButton);
            this.Controls.Add(this.FinishLabel);
            this.Controls.Add(this.BlockLabel);
            this.Controls.Add(this.ReadyLabel);
            this.Controls.Add(this.RunningLabel);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.StatusButton);
            this.Controls.Add(this.ProcessLabel);
            this.Name = "ProcessControl";
            this.Size = new System.Drawing.Size(1259, 966);
            this.Load += new System.EventHandler(this.ProcessControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RateNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProcessLabel;
        private System.Windows.Forms.Button StatusButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label RunningLabel;
        private System.Windows.Forms.Label ReadyLabel;
        private System.Windows.Forms.Label BlockLabel;
        private System.Windows.Forms.Label FinishLabel;
        private System.Windows.Forms.Button StepButton;
        private System.Windows.Forms.NumericUpDown RateNumeric;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.Button BlockButton;
        private System.Windows.Forms.Button ReadyButton;
        private System.Windows.Forms.ListView RunningView;
        private System.Windows.Forms.ListView ReadyView;
        private System.Windows.Forms.ListView BlockView;
        private System.Windows.Forms.ListView FinishView;
        private System.Windows.Forms.ComboBox BlockBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label EfficiencyLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.ComboBox RunningBox;
    }
}
