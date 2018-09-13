namespace Agents
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nudSimulationTime = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudQueueCapacity = new System.Windows.Forms.NumericUpDown();
            this.nudServicers = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudServiceTo = new System.Windows.Forms.NumericUpDown();
            this.nudServiceFrom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudArrivalFrom = new System.Windows.Forms.NumericUpDown();
            this.nudArrivalTo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.bSimulate = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSimulationTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQueueCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServicers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArrivalFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArrivalTo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.AutoScrollMinSize = new System.Drawing.Size(240, 0);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.log);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 321;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.Controls.Add(this.nudSimulationTime, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.nudQueueCapacity, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.nudServicers, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nudServiceTo, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.nudServiceFrom, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudArrivalFrom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudArrivalTo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bSimulate, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nudSimulationTime
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.nudSimulationTime, 3);
            this.nudSimulationTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudSimulationTime.Location = new System.Drawing.Point(6, 199);
            this.nudSimulationTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSimulationTime.Name = "nudSimulationTime";
            this.nudSimulationTime.Size = new System.Drawing.Size(309, 20);
            this.nudSimulationTime.TabIndex = 14;
            this.nudSimulationTime.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label8, 3);
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(6, 180);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(309, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "The simulation time";
            // 
            // nudQueueCapacity
            // 
            this.nudQueueCapacity.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudQueueCapacity.Location = new System.Drawing.Point(171, 141);
            this.nudQueueCapacity.Name = "nudQueueCapacity";
            this.nudQueueCapacity.Size = new System.Drawing.Size(144, 20);
            this.nudQueueCapacity.TabIndex = 10;
            this.nudQueueCapacity.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // nudServicers
            // 
            this.nudServicers.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudServicers.Location = new System.Drawing.Point(6, 141);
            this.nudServicers.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudServicers.Name = "nudServicers";
            this.nudServicers.Size = new System.Drawing.Size(143, 20);
            this.nudServicers.TabIndex = 9;
            this.nudServicers.UseWaitCursor = true;
            this.nudServicers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(171, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Queue capacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "The number of servicers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(155, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(10, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudServiceTo
            // 
            this.nudServiceTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudServiceTo.Location = new System.Drawing.Point(171, 83);
            this.nudServiceTo.Name = "nudServiceTo";
            this.nudServiceTo.Size = new System.Drawing.Size(144, 20);
            this.nudServiceTo.TabIndex = 5;
            this.nudServiceTo.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // nudServiceFrom
            // 
            this.nudServiceFrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudServiceFrom.Location = new System.Drawing.Point(6, 83);
            this.nudServiceFrom.Name = "nudServiceFrom";
            this.nudServiceFrom.Size = new System.Drawing.Size(143, 20);
            this.nudServiceFrom.TabIndex = 4;
            this.nudServiceFrom.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 3);
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Duration of customer service";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer arrival interval";
            // 
            // nudArrivalFrom
            // 
            this.nudArrivalFrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudArrivalFrom.Location = new System.Drawing.Point(6, 25);
            this.nudArrivalFrom.Name = "nudArrivalFrom";
            this.nudArrivalFrom.Size = new System.Drawing.Size(143, 20);
            this.nudArrivalFrom.TabIndex = 1;
            this.nudArrivalFrom.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudArrivalTo
            // 
            this.nudArrivalTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudArrivalTo.Location = new System.Drawing.Point(171, 25);
            this.nudArrivalTo.Name = "nudArrivalTo";
            this.nudArrivalTo.Size = new System.Drawing.Size(144, 20);
            this.nudArrivalTo.TabIndex = 1;
            this.nudArrivalTo.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(155, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(10, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bSimulate
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.bSimulate, 3);
            this.bSimulate.Dock = System.Windows.Forms.DockStyle.Top;
            this.bSimulate.Location = new System.Drawing.Point(6, 238);
            this.bSimulate.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.bSimulate.Name = "bSimulate";
            this.bSimulate.Size = new System.Drawing.Size(309, 23);
            this.bSimulate.TabIndex = 15;
            this.bSimulate.Text = "Run simulation";
            this.bSimulate.UseVisualStyleBackColor = true;
            this.bSimulate.Click += new System.EventHandler(this.BSimulate_Click);
            // 
            // log
            // 
            this.log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log.FormattingEnabled = true;
            this.log.Location = new System.Drawing.Point(0, 0);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(475, 450);
            this.log.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Queuing system";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSimulationTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQueueCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServicers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArrivalFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArrivalTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox log;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudArrivalFrom;
        private System.Windows.Forms.NumericUpDown nudArrivalTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQueueCapacity;
        private System.Windows.Forms.NumericUpDown nudServicers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudServiceTo;
        private System.Windows.Forms.NumericUpDown nudServiceFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSimulationTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bSimulate;
    }
}

