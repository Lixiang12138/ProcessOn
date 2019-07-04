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
            this.statusButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.runningLabel = new System.Windows.Forms.Label();
            this.readyLabel = new System.Windows.Forms.Label();
            this.blockLabel = new System.Windows.Forms.Label();
            this.finishLabel = new System.Windows.Forms.Label();
            this.stepButton = new System.Windows.Forms.Button();
            this.rateNumeric = new System.Windows.Forms.NumericUpDown();
            this.rateLabel = new System.Windows.Forms.Label();
            this.blockButton = new System.Windows.Forms.Button();
            this.readyButton = new System.Windows.Forms.Button();
            this.runningView = new System.Windows.Forms.ListView();
            this.readyView = new System.Windows.Forms.ListView();
            this.blockView = new System.Windows.Forms.ListView();
            this.finishView = new System.Windows.Forms.ListView();
            this.blockBox = new System.Windows.Forms.ComboBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.efficiencyLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.runningBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.rateNumeric)).BeginInit();
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
            this.statusButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusButton.Location = new System.Drawing.Point(1040, 170);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(125, 50);
            this.statusButton.TabIndex = 36;
            this.statusButton.Text = "开始";
            this.statusButton.UseVisualStyleBackColor = true;
            this.statusButton.Click += new System.EventHandler(this.StatusButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.returnButton.ForeColor = System.Drawing.Color.Red;
            this.returnButton.Location = new System.Drawing.Point(1040, 762);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(125, 49);
            this.returnButton.TabIndex = 40;
            this.returnButton.Text = "终止";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // runningLabel
            // 
            this.runningLabel.AutoSize = true;
            this.runningLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.runningLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.runningLabel.Location = new System.Drawing.Point(39, 37);
            this.runningLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.runningLabel.Name = "runningLabel";
            this.runningLabel.Size = new System.Drawing.Size(110, 31);
            this.runningLabel.TabIndex = 41;
            this.runningLabel.Text = "正在运行";
            // 
            // readyLabel
            // 
            this.readyLabel.AutoSize = true;
            this.readyLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.readyLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.readyLabel.Location = new System.Drawing.Point(39, 257);
            this.readyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readyLabel.Name = "readyLabel";
            this.readyLabel.Size = new System.Drawing.Size(86, 31);
            this.readyLabel.TabIndex = 42;
            this.readyLabel.Text = "已就绪";
            // 
            // blockLabel
            // 
            this.blockLabel.AutoSize = true;
            this.blockLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.blockLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blockLabel.Location = new System.Drawing.Point(39, 477);
            this.blockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blockLabel.Name = "blockLabel";
            this.blockLabel.Size = new System.Drawing.Size(86, 31);
            this.blockLabel.TabIndex = 43;
            this.blockLabel.Text = "阻塞中";
            // 
            // finishLabel
            // 
            this.finishLabel.AutoSize = true;
            this.finishLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.finishLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.finishLabel.Location = new System.Drawing.Point(39, 597);
            this.finishLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.finishLabel.Name = "finishLabel";
            this.finishLabel.Size = new System.Drawing.Size(86, 31);
            this.finishLabel.TabIndex = 44;
            this.finishLabel.Text = "已完成";
            // 
            // stepButton
            // 
            this.stepButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stepButton.Location = new System.Drawing.Point(1041, 270);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(125, 50);
            this.stepButton.TabIndex = 45;
            this.stepButton.Text = "单步运行";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.StepButton_Click);
            // 
            // rateNumeric
            // 
            this.rateNumeric.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rateNumeric.Location = new System.Drawing.Point(1041, 687);
            this.rateNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.rateNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rateNumeric.Name = "rateNumeric";
            this.rateNumeric.Size = new System.Drawing.Size(160, 30);
            this.rateNumeric.TabIndex = 57;
            this.rateNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rateNumeric.ValueChanged += new System.EventHandler(this.RateNumeric_ValueChanged);
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rateLabel.Location = new System.Drawing.Point(1035, 638);
            this.rateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(92, 27);
            this.rateLabel.TabIndex = 56;
            this.rateLabel.Text = "运行速度";
            // 
            // blockButton
            // 
            this.blockButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blockButton.Location = new System.Drawing.Point(1041, 403);
            this.blockButton.Name = "blockButton";
            this.blockButton.Size = new System.Drawing.Size(160, 50);
            this.blockButton.TabIndex = 58;
            this.blockButton.Text = "阻塞当前进程";
            this.blockButton.UseVisualStyleBackColor = true;
            this.blockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // readyButton
            // 
            this.readyButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.readyButton.Location = new System.Drawing.Point(1041, 541);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(160, 50);
            this.readyButton.TabIndex = 59;
            this.readyButton.Text = "就绪选中进程";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Click += new System.EventHandler(this.ReadyButton_Click);
            // 
            // runningView
            // 
            this.runningView.Location = new System.Drawing.Point(45, 71);
            this.runningView.Name = "runningView";
            this.runningView.Size = new System.Drawing.Size(924, 180);
            this.runningView.TabIndex = 60;
            this.runningView.UseCompatibleStateImageBehavior = false;
            // 
            // readyView
            // 
            this.readyView.Location = new System.Drawing.Point(45, 291);
            this.readyView.Name = "readyView";
            this.readyView.Size = new System.Drawing.Size(924, 180);
            this.readyView.TabIndex = 61;
            this.readyView.UseCompatibleStateImageBehavior = false;
            // 
            // blockView
            // 
            this.blockView.Location = new System.Drawing.Point(45, 511);
            this.blockView.Name = "blockView";
            this.blockView.Size = new System.Drawing.Size(924, 80);
            this.blockView.TabIndex = 62;
            this.blockView.UseCompatibleStateImageBehavior = false;
            // 
            // finishView
            // 
            this.finishView.Location = new System.Drawing.Point(45, 631);
            this.finishView.Name = "finishView";
            this.finishView.Size = new System.Drawing.Size(924, 180);
            this.finishView.TabIndex = 63;
            this.finishView.UseCompatibleStateImageBehavior = false;
            // 
            // blockBox
            // 
            this.blockBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blockBox.FormattingEnabled = true;
            this.blockBox.Location = new System.Drawing.Point(1041, 500);
            this.blockBox.Name = "blockBox";
            this.blockBox.Size = new System.Drawing.Size(160, 35);
            this.blockBox.TabIndex = 64;
            this.blockBox.Text = "请选择进程";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.timeLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.Location = new System.Drawing.Point(998, 30);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(135, 31);
            this.timeLabel.TabIndex = 65;
            this.timeLabel.Text = "CPU时间：";
            // 
            // efficiencyLabel
            // 
            this.efficiencyLabel.AutoSize = true;
            this.efficiencyLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.efficiencyLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.efficiencyLabel.Location = new System.Drawing.Point(998, 70);
            this.efficiencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.efficiencyLabel.Name = "efficiencyLabel";
            this.efficiencyLabel.Size = new System.Drawing.Size(159, 31);
            this.efficiencyLabel.TabIndex = 66;
            this.efficiencyLabel.Text = "CPU利用率：";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.sizeLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sizeLabel.Location = new System.Drawing.Point(998, 110);
            this.sizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(158, 31);
            this.sizeLabel.TabIndex = 67;
            this.sizeLabel.Text = "时间片长度：";
            // 
            // runningBox
            // 
            this.runningBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.runningBox.FormattingEnabled = true;
            this.runningBox.Location = new System.Drawing.Point(1041, 362);
            this.runningBox.Name = "runningBox";
            this.runningBox.Size = new System.Drawing.Size(160, 35);
            this.runningBox.TabIndex = 68;
            this.runningBox.Text = "请选择进程";
            // 
            // ProcessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.runningBox);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.efficiencyLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.blockBox);
            this.Controls.Add(this.finishView);
            this.Controls.Add(this.blockView);
            this.Controls.Add(this.readyView);
            this.Controls.Add(this.runningView);
            this.Controls.Add(this.readyButton);
            this.Controls.Add(this.blockButton);
            this.Controls.Add(this.rateNumeric);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.finishLabel);
            this.Controls.Add(this.blockLabel);
            this.Controls.Add(this.readyLabel);
            this.Controls.Add(this.runningLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.ProcessLabel);
            this.Name = "ProcessControl";
            this.Size = new System.Drawing.Size(1259, 966);
            this.Load += new System.EventHandler(this.ProcessControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rateNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProcessLabel;
        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label runningLabel;
        private System.Windows.Forms.Label readyLabel;
        private System.Windows.Forms.Label blockLabel;
        private System.Windows.Forms.Label finishLabel;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.NumericUpDown rateNumeric;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Button blockButton;
        private System.Windows.Forms.Button readyButton;
        private System.Windows.Forms.ListView runningView;
        private System.Windows.Forms.ListView readyView;
        private System.Windows.Forms.ListView blockView;
        private System.Windows.Forms.ListView finishView;
        private System.Windows.Forms.ComboBox blockBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label efficiencyLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.ComboBox runningBox;
    }
}
