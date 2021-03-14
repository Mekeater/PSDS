namespace GlobeCode
{
    partial class RunCalculationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunCalculationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.p_Transient = new System.Windows.Forms.Panel();
            this.p_AdaptiveTimeStepSet = new System.Windows.Forms.Panel();
            this.tb_TimeStepFixedNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.tb_MaxTimeStepChangeFactor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_MinTimeStepChangeFactor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.tb_MaxTimeStep = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_MinTimeStep = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.tb_EndTime = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.tb_ErrorTolerance = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.tb_MaxIterations_TimeStep = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.tb_TimeStepingNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.tb_TimeStepingSize = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cb_TimeStepingMethod = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.p_Steady = new System.Windows.Forms.Panel();
            this.tb_NumberOfIterations = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_help = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.p_Transient.SuspendLayout();
            this.p_AdaptiveTimeStepSet.SuspendLayout();
            this.p_Steady.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 438);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.p_Transient);
            this.panel3.Controls.Add(this.p_Steady);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 328);
            this.panel3.TabIndex = 0;
            // 
            // p_Transient
            // 
            this.p_Transient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_Transient.Controls.Add(this.p_AdaptiveTimeStepSet);
            this.p_Transient.Controls.Add(this.tb_MaxIterations_TimeStep);
            this.p_Transient.Controls.Add(this.labelX5);
            this.p_Transient.Controls.Add(this.tb_TimeStepingNumber);
            this.p_Transient.Controls.Add(this.labelX4);
            this.p_Transient.Controls.Add(this.tb_TimeStepingSize);
            this.p_Transient.Controls.Add(this.labelX3);
            this.p_Transient.Controls.Add(this.cb_TimeStepingMethod);
            this.p_Transient.Controls.Add(this.labelX2);
            this.p_Transient.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Transient.Location = new System.Drawing.Point(0, 68);
            this.p_Transient.Name = "p_Transient";
            this.p_Transient.Size = new System.Drawing.Size(720, 257);
            this.p_Transient.TabIndex = 1;
            // 
            // p_AdaptiveTimeStepSet
            // 
            this.p_AdaptiveTimeStepSet.Controls.Add(this.tb_TimeStepFixedNum);
            this.p_AdaptiveTimeStepSet.Controls.Add(this.labelX12);
            this.p_AdaptiveTimeStepSet.Controls.Add(this.tb_MaxTimeStepChangeFactor);
            this.p_AdaptiveTimeStepSet.Controls.Add(this.tb_MinTimeStepChangeFactor);
            this.p_AdaptiveTimeStepSet.Controls.Add(this.labelX11);
            this.p_AdaptiveTimeStepSet.Controls.Add(this.labelX10);
            this.p_AdaptiveTimeStepSet.Controls.Add(this.tb_MaxTimeStep);
            this.p_AdaptiveTimeStepSet.Controls.Add(this.tb_MinTimeStep);
            this.p_AdaptiveTimeStepSet.Controls.Add(this.labelX9);
            this.p_AdaptiveTimeStepSet.Controls.Add(this.labelX8);
            this.p_AdaptiveTimeStepSet.Controls.Add(this.tb_EndTime);
            this.p_AdaptiveTimeStepSet.Controls.Add(this.labelX7);
            this.p_AdaptiveTimeStepSet.Controls.Add(this.tb_ErrorTolerance);
            this.p_AdaptiveTimeStepSet.Controls.Add(this.labelX6);
            this.p_AdaptiveTimeStepSet.Location = new System.Drawing.Point(5, 136);
            this.p_AdaptiveTimeStepSet.Name = "p_AdaptiveTimeStepSet";
            this.p_AdaptiveTimeStepSet.Size = new System.Drawing.Size(692, 103);
            this.p_AdaptiveTimeStepSet.TabIndex = 8;
            // 
            // tb_TimeStepFixedNum
            // 
            // 
            // 
            // 
            this.tb_TimeStepFixedNum.Border.Class = "TextBoxBorder";
            this.tb_TimeStepFixedNum.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_TimeStepFixedNum.Location = new System.Drawing.Point(104, 77);
            this.tb_TimeStepFixedNum.Name = "tb_TimeStepFixedNum";
            this.tb_TimeStepFixedNum.PreventEnterBeep = true;
            this.tb_TimeStepFixedNum.Size = new System.Drawing.Size(100, 21);
            this.tb_TimeStepFixedNum.TabIndex = 23;
            this.tb_TimeStepFixedNum.Text = "1";
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(3, 77);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(118, 23);
            this.labelX12.TabIndex = 22;
            this.labelX12.Text = "固定时间步数量：";
            // 
            // tb_MaxTimeStepChangeFactor
            // 
            // 
            // 
            // 
            this.tb_MaxTimeStepChangeFactor.Border.Class = "TextBoxBorder";
            this.tb_MaxTimeStepChangeFactor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_MaxTimeStepChangeFactor.Location = new System.Drawing.Point(519, 41);
            this.tb_MaxTimeStepChangeFactor.Name = "tb_MaxTimeStepChangeFactor";
            this.tb_MaxTimeStepChangeFactor.PreventEnterBeep = true;
            this.tb_MaxTimeStepChangeFactor.Size = new System.Drawing.Size(100, 21);
            this.tb_MaxTimeStepChangeFactor.TabIndex = 21;
            this.tb_MaxTimeStepChangeFactor.Text = "5";
            // 
            // tb_MinTimeStepChangeFactor
            // 
            // 
            // 
            // 
            this.tb_MinTimeStepChangeFactor.Border.Class = "TextBoxBorder";
            this.tb_MinTimeStepChangeFactor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_MinTimeStepChangeFactor.Location = new System.Drawing.Point(519, 14);
            this.tb_MinTimeStepChangeFactor.Name = "tb_MinTimeStepChangeFactor";
            this.tb_MinTimeStepChangeFactor.PreventEnterBeep = true;
            this.tb_MinTimeStepChangeFactor.Size = new System.Drawing.Size(100, 21);
            this.tb_MinTimeStepChangeFactor.TabIndex = 20;
            this.tb_MinTimeStepChangeFactor.Text = "0.5";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(405, 41);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(118, 23);
            this.labelX11.TabIndex = 19;
            this.labelX11.Text = "最大步长改变因子：";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(405, 14);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(118, 23);
            this.labelX10.TabIndex = 18;
            this.labelX10.Text = "最小步长改变因子：";
            // 
            // tb_MaxTimeStep
            // 
            // 
            // 
            // 
            this.tb_MaxTimeStep.Border.Class = "TextBoxBorder";
            this.tb_MaxTimeStep.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_MaxTimeStep.Location = new System.Drawing.Point(299, 45);
            this.tb_MaxTimeStep.Name = "tb_MaxTimeStep";
            this.tb_MaxTimeStep.PreventEnterBeep = true;
            this.tb_MaxTimeStep.Size = new System.Drawing.Size(100, 21);
            this.tb_MaxTimeStep.TabIndex = 17;
            this.tb_MaxTimeStep.Text = "10";
            // 
            // tb_MinTimeStep
            // 
            // 
            // 
            // 
            this.tb_MinTimeStep.Border.Class = "TextBoxBorder";
            this.tb_MinTimeStep.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_MinTimeStep.Location = new System.Drawing.Point(104, 45);
            this.tb_MinTimeStep.Name = "tb_MinTimeStep";
            this.tb_MinTimeStep.PreventEnterBeep = true;
            this.tb_MinTimeStep.Size = new System.Drawing.Size(100, 21);
            this.tb_MinTimeStep.TabIndex = 16;
            this.tb_MinTimeStep.Text = "1e-05";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(210, 41);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(83, 23);
            this.labelX9.TabIndex = 15;
            this.labelX9.Text = "最大时间步：";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(3, 43);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(95, 23);
            this.labelX8.TabIndex = 13;
            this.labelX8.Text = "最小时间步：";
            // 
            // tb_EndTime
            // 
            // 
            // 
            // 
            this.tb_EndTime.Border.Class = "TextBoxBorder";
            this.tb_EndTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_EndTime.Location = new System.Drawing.Point(299, 14);
            this.tb_EndTime.Name = "tb_EndTime";
            this.tb_EndTime.PreventEnterBeep = true;
            this.tb_EndTime.Size = new System.Drawing.Size(100, 21);
            this.tb_EndTime.TabIndex = 12;
            this.tb_EndTime.Text = "1000";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(210, 14);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(83, 23);
            this.labelX7.TabIndex = 11;
            this.labelX7.Text = "结束时间：";
            // 
            // tb_ErrorTolerance
            // 
            // 
            // 
            // 
            this.tb_ErrorTolerance.Border.Class = "TextBoxBorder";
            this.tb_ErrorTolerance.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_ErrorTolerance.Location = new System.Drawing.Point(104, 14);
            this.tb_ErrorTolerance.Name = "tb_ErrorTolerance";
            this.tb_ErrorTolerance.PreventEnterBeep = true;
            this.tb_ErrorTolerance.Size = new System.Drawing.Size(100, 21);
            this.tb_ErrorTolerance.TabIndex = 10;
            this.tb_ErrorTolerance.Text = "0.01";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(3, 14);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(95, 23);
            this.labelX6.TabIndex = 9;
            this.labelX6.Text = "截断误差容限：";
            // 
            // tb_MaxIterations_TimeStep
            // 
            this.tb_MaxIterations_TimeStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_MaxIterations_TimeStep.Border.Class = "TextBoxBorder";
            this.tb_MaxIterations_TimeStep.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_MaxIterations_TimeStep.Location = new System.Drawing.Point(151, 105);
            this.tb_MaxIterations_TimeStep.Name = "tb_MaxIterations_TimeStep";
            this.tb_MaxIterations_TimeStep.PreventEnterBeep = true;
            this.tb_MaxIterations_TimeStep.Size = new System.Drawing.Size(546, 21);
            this.tb_MaxIterations_TimeStep.TabIndex = 7;
            this.tb_MaxIterations_TimeStep.Text = "20";
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(5, 105);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(154, 23);
            this.labelX5.TabIndex = 6;
            this.labelX5.Text = "每个时间步最大迭代次数：";
            // 
            // tb_TimeStepingNumber
            // 
            this.tb_TimeStepingNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_TimeStepingNumber.Border.Class = "TextBoxBorder";
            this.tb_TimeStepingNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_TimeStepingNumber.Location = new System.Drawing.Point(86, 76);
            this.tb_TimeStepingNumber.Name = "tb_TimeStepingNumber";
            this.tb_TimeStepingNumber.PreventEnterBeep = true;
            this.tb_TimeStepingNumber.Size = new System.Drawing.Size(611, 21);
            this.tb_TimeStepingNumber.TabIndex = 5;
            this.tb_TimeStepingNumber.Text = "0";
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(5, 76);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(82, 23);
            this.labelX4.TabIndex = 4;
            this.labelX4.Text = "时间步个数：";
            // 
            // tb_TimeStepingSize
            // 
            this.tb_TimeStepingSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_TimeStepingSize.Border.Class = "TextBoxBorder";
            this.tb_TimeStepingSize.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_TimeStepingSize.Location = new System.Drawing.Point(109, 49);
            this.tb_TimeStepingSize.Name = "tb_TimeStepingSize";
            this.tb_TimeStepingSize.PreventEnterBeep = true;
            this.tb_TimeStepingSize.Size = new System.Drawing.Size(588, 21);
            this.tb_TimeStepingSize.TabIndex = 3;
            this.tb_TimeStepingSize.Text = "1";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(5, 51);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(98, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "时间步大小(s)：";
            // 
            // cb_TimeStepingMethod
            // 
            this.cb_TimeStepingMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_TimeStepingMethod.DisplayMember = "Text";
            this.cb_TimeStepingMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_TimeStepingMethod.FormattingEnabled = true;
            this.cb_TimeStepingMethod.ItemHeight = 15;
            this.cb_TimeStepingMethod.Location = new System.Drawing.Point(86, 22);
            this.cb_TimeStepingMethod.Name = "cb_TimeStepingMethod";
            this.cb_TimeStepingMethod.Size = new System.Drawing.Size(611, 21);
            this.cb_TimeStepingMethod.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_TimeStepingMethod.TabIndex = 1;
            this.cb_TimeStepingMethod.SelectedIndexChanged += new System.EventHandler(this.cb_TimeStepingMethod_SelectedIndexChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(5, 22);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(82, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "时间步方法：";
            // 
            // p_Steady
            // 
            this.p_Steady.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_Steady.Controls.Add(this.tb_NumberOfIterations);
            this.p_Steady.Controls.Add(this.labelX1);
            this.p_Steady.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Steady.Location = new System.Drawing.Point(0, 0);
            this.p_Steady.Name = "p_Steady";
            this.p_Steady.Size = new System.Drawing.Size(720, 68);
            this.p_Steady.TabIndex = 0;
            // 
            // tb_NumberOfIterations
            // 
            this.tb_NumberOfIterations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_NumberOfIterations.Border.Class = "TextBoxBorder";
            this.tb_NumberOfIterations.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_NumberOfIterations.Location = new System.Drawing.Point(86, 19);
            this.tb_NumberOfIterations.Name = "tb_NumberOfIterations";
            this.tb_NumberOfIterations.PreventEnterBeep = true;
            this.tb_NumberOfIterations.Size = new System.Drawing.Size(611, 21);
            this.tb_NumberOfIterations.TabIndex = 1;
            this.tb_NumberOfIterations.Text = "0";
            this.tb_NumberOfIterations.TextChanged += new System.EventHandler(this.tb_NumberOfIterations_TextChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(5, 17);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "迭代次数：";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lb_help);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 104);
            this.panel2.TabIndex = 1;
            // 
            // lb_help
            // 
            this.lb_help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_help.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_help.ForeColor = System.Drawing.Color.Green;
            this.lb_help.Location = new System.Drawing.Point(0, 0);
            this.lb_help.Name = "lb_help";
            this.lb_help.Size = new System.Drawing.Size(726, 100);
            this.lb_help.TabIndex = 3;
            this.lb_help.Text = "帮助：";
            // 
            // RunCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RunCalculationForm";
            this.Text = "RunCalculationForm";
            this.Load += new System.EventHandler(this.RunCalculationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.p_Transient.ResumeLayout(false);
            this.p_AdaptiveTimeStepSet.ResumeLayout(false);
            this.p_Steady.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_help;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel p_Transient;
        private System.Windows.Forms.Panel p_Steady;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_NumberOfIterations;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_TimeStepingMethod;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_TimeStepingSize;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_TimeStepingNumber;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_MaxIterations_TimeStep;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.Panel p_AdaptiveTimeStepSet;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_EndTime;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_ErrorTolerance;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_MaxTimeStep;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_MinTimeStep;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_MaxTimeStepChangeFactor;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_MinTimeStepChangeFactor;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_TimeStepFixedNum;
        private DevComponents.DotNetBar.LabelX labelX12;
    }
}