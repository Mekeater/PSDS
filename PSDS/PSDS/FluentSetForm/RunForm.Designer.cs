namespace GlobeCode
{
    partial class RunForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunForm));
            this.tb_FluentPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radiobt_double = new System.Windows.Forms.RadioButton();
            this.radiobt_single = new System.Windows.Forms.RadioButton();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_Processes = new System.Windows.Forms.Label();
            this.tb_Processes = new System.Windows.Forms.TextBox();
            this.radiobt_parallel = new System.Windows.Forms.RadioButton();
            this.radiobt_serial = new System.Windows.Forms.RadioButton();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radiobt_3D = new System.Windows.Forms.RadioButton();
            this.radiobt_2D = new System.Windows.Forms.RadioButton();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.btn_Sure = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_FluentPath
            // 
            this.tb_FluentPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_FluentPath.Border.Class = "TextBoxBorder";
            this.tb_FluentPath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_FluentPath.Location = new System.Drawing.Point(93, 22);
            this.tb_FluentPath.Name = "tb_FluentPath";
            this.tb_FluentPath.PreventEnterBeep = true;
            this.tb_FluentPath.Size = new System.Drawing.Size(447, 21);
            this.tb_FluentPath.TabIndex = 0;
            this.tb_FluentPath.DoubleClick += new System.EventHandler(this.tb_FluentPath_DoubleClick);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(6, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(81, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Fluent路径：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.labelX4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.tb_FluentPath);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 287);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radiobt_double);
            this.panel4.Controls.Add(this.radiobt_single);
            this.panel4.Location = new System.Drawing.Point(93, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(447, 47);
            this.panel4.TabIndex = 5;
            // 
            // radiobt_double
            // 
            this.radiobt_double.AutoSize = true;
            this.radiobt_double.Location = new System.Drawing.Point(62, 16);
            this.radiobt_double.Name = "radiobt_double";
            this.radiobt_double.Size = new System.Drawing.Size(59, 16);
            this.radiobt_double.TabIndex = 1;
            this.radiobt_double.Text = "双精度";
            this.radiobt_double.UseVisualStyleBackColor = true;
            // 
            // radiobt_single
            // 
            this.radiobt_single.AutoSize = true;
            this.radiobt_single.Checked = true;
            this.radiobt_single.Location = new System.Drawing.Point(3, 16);
            this.radiobt_single.Name = "radiobt_single";
            this.radiobt_single.Size = new System.Drawing.Size(59, 16);
            this.radiobt_single.TabIndex = 0;
            this.radiobt_single.TabStop = true;
            this.radiobt_single.Text = "单精度";
            this.radiobt_single.UseVisualStyleBackColor = true;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(6, 115);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(81, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "计算精度：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label_Processes);
            this.panel3.Controls.Add(this.tb_Processes);
            this.panel3.Controls.Add(this.radiobt_parallel);
            this.panel3.Controls.Add(this.radiobt_serial);
            this.panel3.Location = new System.Drawing.Point(93, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 47);
            this.panel3.TabIndex = 4;
            // 
            // label_Processes
            // 
            this.label_Processes.AutoSize = true;
            this.label_Processes.Location = new System.Drawing.Point(133, 18);
            this.label_Processes.Name = "label_Processes";
            this.label_Processes.Size = new System.Drawing.Size(41, 12);
            this.label_Processes.TabIndex = 3;
            this.label_Processes.Text = "核数：";
            // 
            // tb_Processes
            // 
            this.tb_Processes.Location = new System.Drawing.Point(180, 14);
            this.tb_Processes.Name = "tb_Processes";
            this.tb_Processes.Size = new System.Drawing.Size(82, 21);
            this.tb_Processes.TabIndex = 2;
            this.tb_Processes.Text = "4";
            this.tb_Processes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Processes_KeyPress);
            // 
            // radiobt_parallel
            // 
            this.radiobt_parallel.AutoSize = true;
            this.radiobt_parallel.Checked = true;
            this.radiobt_parallel.Location = new System.Drawing.Point(62, 16);
            this.radiobt_parallel.Name = "radiobt_parallel";
            this.radiobt_parallel.Size = new System.Drawing.Size(47, 16);
            this.radiobt_parallel.TabIndex = 1;
            this.radiobt_parallel.TabStop = true;
            this.radiobt_parallel.Text = "并行";
            this.radiobt_parallel.UseVisualStyleBackColor = true;
            this.radiobt_parallel.Click += new System.EventHandler(this.radiobt_parallel_Click);
            // 
            // radiobt_serial
            // 
            this.radiobt_serial.AutoSize = true;
            this.radiobt_serial.Location = new System.Drawing.Point(3, 16);
            this.radiobt_serial.Name = "radiobt_serial";
            this.radiobt_serial.Size = new System.Drawing.Size(47, 16);
            this.radiobt_serial.TabIndex = 0;
            this.radiobt_serial.Text = "串行";
            this.radiobt_serial.UseVisualStyleBackColor = true;
            this.radiobt_serial.Click += new System.EventHandler(this.radiobt_serial_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(6, 171);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(81, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "计算方式：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radiobt_3D);
            this.panel2.Controls.Add(this.radiobt_2D);
            this.panel2.Location = new System.Drawing.Point(93, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 47);
            this.panel2.TabIndex = 3;
            // 
            // radiobt_3D
            // 
            this.radiobt_3D.AutoSize = true;
            this.radiobt_3D.Checked = true;
            this.radiobt_3D.Location = new System.Drawing.Point(62, 16);
            this.radiobt_3D.Name = "radiobt_3D";
            this.radiobt_3D.Size = new System.Drawing.Size(35, 16);
            this.radiobt_3D.TabIndex = 1;
            this.radiobt_3D.TabStop = true;
            this.radiobt_3D.Text = "3D";
            this.radiobt_3D.UseVisualStyleBackColor = true;
            // 
            // radiobt_2D
            // 
            this.radiobt_2D.AutoSize = true;
            this.radiobt_2D.Enabled = false;
            this.radiobt_2D.Location = new System.Drawing.Point(3, 16);
            this.radiobt_2D.Name = "radiobt_2D";
            this.radiobt_2D.Size = new System.Drawing.Size(35, 16);
            this.radiobt_2D.TabIndex = 0;
            this.radiobt_2D.Text = "2D";
            this.radiobt_2D.UseVisualStyleBackColor = true;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(6, 65);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(81, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "计算维度：";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btn_Cancel);
            this.panel5.Controls.Add(this.btn_Sure);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 236);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(554, 51);
            this.panel5.TabIndex = 7;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(465, 13);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Sure
            // 
            this.btn_Sure.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Sure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sure.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Sure.Location = new System.Drawing.Point(356, 13);
            this.btn_Sure.Name = "btn_Sure";
            this.btn_Sure.Size = new System.Drawing.Size(75, 23);
            this.btn_Sure.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Sure.TabIndex = 0;
            this.btn_Sure.Text = "确定";
            this.btn_Sure.Click += new System.EventHandler(this.btn_Sure_Click);
            // 
            // RunForm
            // 
            this.AcceptButton = this.btn_Sure;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(554, 287);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RunForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "执行计算";
            this.Load += new System.EventHandler(this.RunForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tb_FluentPath;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radiobt_3D;
        private System.Windows.Forms.RadioButton radiobt_2D;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radiobt_parallel;
        private System.Windows.Forms.RadioButton radiobt_serial;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radiobt_double;
        private System.Windows.Forms.RadioButton radiobt_single;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.Label label_Processes;
        private System.Windows.Forms.TextBox tb_Processes;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.ButtonX btn_Sure;
        private DevComponents.DotNetBar.ButtonX btn_Cancel;
    }
}