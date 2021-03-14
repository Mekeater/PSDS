namespace GlobeCode
{
    partial class PressureOutletMomentumTabForm
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
            this.p_ContainPanel = new System.Windows.Forms.Panel();
            this.p_Turbulence = new System.Windows.Forms.Panel();
            this.tb_TurbulenceP2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_TurbulenceP1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.lb_TurbulenceP2 = new DevComponents.DotNetBar.LabelX();
            this.lb_TurbulenceP1 = new DevComponents.DotNetBar.LabelX();
            this.cb_TurbulenceMethod = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.p_MassFlowRate = new System.Windows.Forms.Panel();
            this.tb_TargetMassFlow = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_LowPressure = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.tb_UpPressure = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.p_Checkbox = new System.Windows.Forms.Panel();
            this.ckb_TargetMassFlow = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ckb_AverageP = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ckb_RadialEP = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.p_BackflowDirection = new System.Windows.Forms.Panel();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.tb_FlowDirection_Z = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_FlowDirection_Y = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_FlowDirection_X = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.p_Basic = new System.Windows.Forms.Panel();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.tb_GaugePressure = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cb_BackflowDirection = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cb_BackflowPressure = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cb_ReferenceFrame = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.p_ContainPanel.SuspendLayout();
            this.p_Turbulence.SuspendLayout();
            this.p_MassFlowRate.SuspendLayout();
            this.p_Checkbox.SuspendLayout();
            this.p_BackflowDirection.SuspendLayout();
            this.p_Basic.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_ContainPanel
            // 
            this.p_ContainPanel.AutoScroll = true;
            this.p_ContainPanel.Controls.Add(this.p_Turbulence);
            this.p_ContainPanel.Controls.Add(this.p_MassFlowRate);
            this.p_ContainPanel.Controls.Add(this.p_Checkbox);
            this.p_ContainPanel.Controls.Add(this.p_BackflowDirection);
            this.p_ContainPanel.Controls.Add(this.p_Basic);
            this.p_ContainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_ContainPanel.Location = new System.Drawing.Point(0, 0);
            this.p_ContainPanel.Name = "p_ContainPanel";
            this.p_ContainPanel.Size = new System.Drawing.Size(804, 567);
            this.p_ContainPanel.TabIndex = 9;
            // 
            // p_Turbulence
            // 
            this.p_Turbulence.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_Turbulence.Controls.Add(this.tb_TurbulenceP2);
            this.p_Turbulence.Controls.Add(this.tb_TurbulenceP1);
            this.p_Turbulence.Controls.Add(this.labelX17);
            this.p_Turbulence.Controls.Add(this.lb_TurbulenceP2);
            this.p_Turbulence.Controls.Add(this.lb_TurbulenceP1);
            this.p_Turbulence.Controls.Add(this.cb_TurbulenceMethod);
            this.p_Turbulence.Controls.Add(this.labelX16);
            this.p_Turbulence.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Turbulence.Location = new System.Drawing.Point(0, 428);
            this.p_Turbulence.Name = "p_Turbulence";
            this.p_Turbulence.Size = new System.Drawing.Size(804, 125);
            this.p_Turbulence.TabIndex = 15;
            // 
            // tb_TurbulenceP2
            // 
            this.tb_TurbulenceP2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_TurbulenceP2.Border.Class = "TextBoxBorder";
            this.tb_TurbulenceP2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_TurbulenceP2.Location = new System.Drawing.Point(152, 94);
            this.tb_TurbulenceP2.Name = "tb_TurbulenceP2";
            this.tb_TurbulenceP2.PreventEnterBeep = true;
            this.tb_TurbulenceP2.Size = new System.Drawing.Size(638, 21);
            this.tb_TurbulenceP2.TabIndex = 11;
            this.tb_TurbulenceP2.Text = " ";
            this.tb_TurbulenceP2.TextChanged += new System.EventHandler(this.tb_TurbulenceP2_TextChanged);
            // 
            // tb_TurbulenceP1
            // 
            this.tb_TurbulenceP1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_TurbulenceP1.Border.Class = "TextBoxBorder";
            this.tb_TurbulenceP1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_TurbulenceP1.Location = new System.Drawing.Point(152, 61);
            this.tb_TurbulenceP1.Name = "tb_TurbulenceP1";
            this.tb_TurbulenceP1.PreventEnterBeep = true;
            this.tb_TurbulenceP1.Size = new System.Drawing.Size(638, 21);
            this.tb_TurbulenceP1.TabIndex = 10;
            this.tb_TurbulenceP1.TextChanged += new System.EventHandler(this.tb_TurbulenceP1_TextChanged);
            // 
            // labelX17
            // 
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Location = new System.Drawing.Point(10, 5);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(96, 23);
            this.labelX17.TabIndex = 6;
            this.labelX17.Text = "湍流设置";
            // 
            // lb_TurbulenceP2
            // 
            // 
            // 
            // 
            this.lb_TurbulenceP2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_TurbulenceP2.Location = new System.Drawing.Point(10, 90);
            this.lb_TurbulenceP2.Name = "lb_TurbulenceP2";
            this.lb_TurbulenceP2.Size = new System.Drawing.Size(136, 23);
            this.lb_TurbulenceP2.TabIndex = 4;
            this.lb_TurbulenceP2.Text = "湍流粘度比：";
            // 
            // lb_TurbulenceP1
            // 
            // 
            // 
            // 
            this.lb_TurbulenceP1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_TurbulenceP1.Location = new System.Drawing.Point(10, 61);
            this.lb_TurbulenceP1.Name = "lb_TurbulenceP1";
            this.lb_TurbulenceP1.Size = new System.Drawing.Size(136, 23);
            this.lb_TurbulenceP1.TabIndex = 2;
            this.lb_TurbulenceP1.Text = "湍流强度(%)：";
            // 
            // cb_TurbulenceMethod
            // 
            this.cb_TurbulenceMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_TurbulenceMethod.DisplayMember = "Text";
            this.cb_TurbulenceMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_TurbulenceMethod.FormattingEnabled = true;
            this.cb_TurbulenceMethod.ItemHeight = 15;
            this.cb_TurbulenceMethod.Location = new System.Drawing.Point(152, 34);
            this.cb_TurbulenceMethod.Name = "cb_TurbulenceMethod";
            this.cb_TurbulenceMethod.Size = new System.Drawing.Size(638, 21);
            this.cb_TurbulenceMethod.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_TurbulenceMethod.TabIndex = 1;
            this.cb_TurbulenceMethod.SelectedIndexChanged += new System.EventHandler(this.cb_TurbulenceMethod_SelectedIndexChanged);
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(10, 32);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(136, 23);
            this.labelX16.TabIndex = 0;
            this.labelX16.Text = "指定方法：";
            // 
            // p_MassFlowRate
            // 
            this.p_MassFlowRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_MassFlowRate.Controls.Add(this.tb_TargetMassFlow);
            this.p_MassFlowRate.Controls.Add(this.tb_LowPressure);
            this.p_MassFlowRate.Controls.Add(this.labelX7);
            this.p_MassFlowRate.Controls.Add(this.tb_UpPressure);
            this.p_MassFlowRate.Controls.Add(this.labelX6);
            this.p_MassFlowRate.Controls.Add(this.labelX5);
            this.p_MassFlowRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_MassFlowRate.Location = new System.Drawing.Point(0, 321);
            this.p_MassFlowRate.Name = "p_MassFlowRate";
            this.p_MassFlowRate.Size = new System.Drawing.Size(804, 107);
            this.p_MassFlowRate.TabIndex = 14;
            this.p_MassFlowRate.Visible = false;
            // 
            // tb_TargetMassFlow
            // 
            this.tb_TargetMassFlow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_TargetMassFlow.Border.Class = "TextBoxBorder";
            this.tb_TargetMassFlow.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_TargetMassFlow.Location = new System.Drawing.Point(134, 7);
            this.tb_TargetMassFlow.Name = "tb_TargetMassFlow";
            this.tb_TargetMassFlow.PreventEnterBeep = true;
            this.tb_TargetMassFlow.Size = new System.Drawing.Size(656, 21);
            this.tb_TargetMassFlow.TabIndex = 28;
            this.tb_TargetMassFlow.Text = "1";
            // 
            // tb_LowPressure
            // 
            this.tb_LowPressure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_LowPressure.Border.Class = "TextBoxBorder";
            this.tb_LowPressure.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_LowPressure.Location = new System.Drawing.Point(134, 65);
            this.tb_LowPressure.Name = "tb_LowPressure";
            this.tb_LowPressure.PreventEnterBeep = true;
            this.tb_LowPressure.Size = new System.Drawing.Size(654, 21);
            this.tb_LowPressure.TabIndex = 27;
            this.tb_LowPressure.Text = "1";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(14, 65);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(119, 23);
            this.labelX7.TabIndex = 26;
            this.labelX7.Text = "絶対圧下限(帕)：";
            // 
            // tb_UpPressure
            // 
            this.tb_UpPressure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_UpPressure.Border.Class = "TextBoxBorder";
            this.tb_UpPressure.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_UpPressure.Location = new System.Drawing.Point(134, 34);
            this.tb_UpPressure.Name = "tb_UpPressure";
            this.tb_UpPressure.PreventEnterBeep = true;
            this.tb_UpPressure.Size = new System.Drawing.Size(656, 21);
            this.tb_UpPressure.TabIndex = 25;
            this.tb_UpPressure.Text = "5000000";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(14, 36);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(110, 23);
            this.labelX6.TabIndex = 24;
            this.labelX6.Text = "絶対圧上限(帕)：";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(12, 7);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(119, 23);
            this.labelX5.TabIndex = 22;
            this.labelX5.Text = "目标质量流(kg/s)：";
            // 
            // p_Checkbox
            // 
            this.p_Checkbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_Checkbox.Controls.Add(this.ckb_TargetMassFlow);
            this.p_Checkbox.Controls.Add(this.ckb_AverageP);
            this.p_Checkbox.Controls.Add(this.ckb_RadialEP);
            this.p_Checkbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Checkbox.Location = new System.Drawing.Point(0, 222);
            this.p_Checkbox.Name = "p_Checkbox";
            this.p_Checkbox.Size = new System.Drawing.Size(804, 99);
            this.p_Checkbox.TabIndex = 12;
            // 
            // ckb_TargetMassFlow
            // 
            // 
            // 
            // 
            this.ckb_TargetMassFlow.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ckb_TargetMassFlow.Location = new System.Drawing.Point(12, 64);
            this.ckb_TargetMassFlow.Name = "ckb_TargetMassFlow";
            this.ckb_TargetMassFlow.Size = new System.Drawing.Size(124, 23);
            this.ckb_TargetMassFlow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ckb_TargetMassFlow.TabIndex = 2;
            this.ckb_TargetMassFlow.Text = "目标质量流量";
            this.ckb_TargetMassFlow.CheckedChanged += new System.EventHandler(this.ckb_TargetMassFlow_CheckedChanged);
            // 
            // ckb_AverageP
            // 
            // 
            // 
            // 
            this.ckb_AverageP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ckb_AverageP.Location = new System.Drawing.Point(12, 35);
            this.ckb_AverageP.Name = "ckb_AverageP";
            this.ckb_AverageP.Size = new System.Drawing.Size(124, 23);
            this.ckb_AverageP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ckb_AverageP.TabIndex = 1;
            this.ckb_AverageP.Text = "指定平均压力";
            // 
            // ckb_RadialEP
            // 
            // 
            // 
            // 
            this.ckb_RadialEP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ckb_RadialEP.Location = new System.Drawing.Point(12, 6);
            this.ckb_RadialEP.Name = "ckb_RadialEP";
            this.ckb_RadialEP.Size = new System.Drawing.Size(124, 23);
            this.ckb_RadialEP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ckb_RadialEP.TabIndex = 0;
            this.ckb_RadialEP.Text = "径向平衡压力分布";
            // 
            // p_BackflowDirection
            // 
            this.p_BackflowDirection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_BackflowDirection.Controls.Add(this.labelX9);
            this.p_BackflowDirection.Controls.Add(this.labelX10);
            this.p_BackflowDirection.Controls.Add(this.labelX11);
            this.p_BackflowDirection.Controls.Add(this.tb_FlowDirection_Z);
            this.p_BackflowDirection.Controls.Add(this.tb_FlowDirection_Y);
            this.p_BackflowDirection.Controls.Add(this.tb_FlowDirection_X);
            this.p_BackflowDirection.Controls.Add(this.labelX12);
            this.p_BackflowDirection.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_BackflowDirection.Location = new System.Drawing.Point(0, 134);
            this.p_BackflowDirection.Name = "p_BackflowDirection";
            this.p_BackflowDirection.Size = new System.Drawing.Size(804, 88);
            this.p_BackflowDirection.TabIndex = 11;
            this.p_BackflowDirection.Visible = false;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(66, 6);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(38, 23);
            this.labelX9.TabIndex = 21;
            this.labelX9.Text = "X：";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(66, 60);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(38, 23);
            this.labelX10.TabIndex = 20;
            this.labelX10.Text = "Z：";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(66, 33);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(38, 23);
            this.labelX11.TabIndex = 19;
            this.labelX11.Text = "Y：";
            // 
            // tb_FlowDirection_Z
            // 
            this.tb_FlowDirection_Z.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_FlowDirection_Z.Border.Class = "TextBoxBorder";
            this.tb_FlowDirection_Z.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_FlowDirection_Z.Location = new System.Drawing.Point(134, 60);
            this.tb_FlowDirection_Z.Name = "tb_FlowDirection_Z";
            this.tb_FlowDirection_Z.PreventEnterBeep = true;
            this.tb_FlowDirection_Z.Size = new System.Drawing.Size(654, 21);
            this.tb_FlowDirection_Z.TabIndex = 18;
            this.tb_FlowDirection_Z.Text = "0";
            // 
            // tb_FlowDirection_Y
            // 
            this.tb_FlowDirection_Y.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_FlowDirection_Y.Border.Class = "TextBoxBorder";
            this.tb_FlowDirection_Y.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_FlowDirection_Y.Location = new System.Drawing.Point(134, 33);
            this.tb_FlowDirection_Y.Name = "tb_FlowDirection_Y";
            this.tb_FlowDirection_Y.PreventEnterBeep = true;
            this.tb_FlowDirection_Y.Size = new System.Drawing.Size(654, 21);
            this.tb_FlowDirection_Y.TabIndex = 17;
            this.tb_FlowDirection_Y.Text = "0";
            // 
            // tb_FlowDirection_X
            // 
            this.tb_FlowDirection_X.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_FlowDirection_X.Border.Class = "TextBoxBorder";
            this.tb_FlowDirection_X.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_FlowDirection_X.Location = new System.Drawing.Point(134, 6);
            this.tb_FlowDirection_X.Name = "tb_FlowDirection_X";
            this.tb_FlowDirection_X.PreventEnterBeep = true;
            this.tb_FlowDirection_X.Size = new System.Drawing.Size(654, 21);
            this.tb_FlowDirection_X.TabIndex = 16;
            this.tb_FlowDirection_X.Text = "1";
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(12, 6);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(66, 23);
            this.labelX12.TabIndex = 15;
            this.labelX12.Text = "方向分量";
            // 
            // p_Basic
            // 
            this.p_Basic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_Basic.Controls.Add(this.labelX4);
            this.p_Basic.Controls.Add(this.tb_GaugePressure);
            this.p_Basic.Controls.Add(this.cb_BackflowDirection);
            this.p_Basic.Controls.Add(this.cb_BackflowPressure);
            this.p_Basic.Controls.Add(this.labelX3);
            this.p_Basic.Controls.Add(this.labelX2);
            this.p_Basic.Controls.Add(this.cb_ReferenceFrame);
            this.p_Basic.Controls.Add(this.labelX1);
            this.p_Basic.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Basic.Location = new System.Drawing.Point(0, 0);
            this.p_Basic.Name = "p_Basic";
            this.p_Basic.Size = new System.Drawing.Size(804, 134);
            this.p_Basic.TabIndex = 10;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(12, 99);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(106, 23);
            this.labelX4.TabIndex = 12;
            this.labelX4.Text = "指定回流方向：";
            // 
            // tb_GaugePressure
            // 
            this.tb_GaugePressure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_GaugePressure.Border.Class = "TextBoxBorder";
            this.tb_GaugePressure.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_GaugePressure.Location = new System.Drawing.Point(134, 45);
            this.tb_GaugePressure.Name = "tb_GaugePressure";
            this.tb_GaugePressure.PreventEnterBeep = true;
            this.tb_GaugePressure.Size = new System.Drawing.Size(654, 21);
            this.tb_GaugePressure.TabIndex = 11;
            this.tb_GaugePressure.Text = "0";
            // 
            // cb_BackflowDirection
            // 
            this.cb_BackflowDirection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_BackflowDirection.DisplayMember = "Text";
            this.cb_BackflowDirection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_BackflowDirection.FormattingEnabled = true;
            this.cb_BackflowDirection.ItemHeight = 15;
            this.cb_BackflowDirection.Location = new System.Drawing.Point(134, 101);
            this.cb_BackflowDirection.Name = "cb_BackflowDirection";
            this.cb_BackflowDirection.Size = new System.Drawing.Size(654, 21);
            this.cb_BackflowDirection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_BackflowDirection.TabIndex = 7;
            this.cb_BackflowDirection.Text = " ";
            this.cb_BackflowDirection.SelectedIndexChanged += new System.EventHandler(this.cb_BackflowDirection_SelectedIndexChanged);
            // 
            // cb_BackflowPressure
            // 
            this.cb_BackflowPressure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_BackflowPressure.DisplayMember = "Text";
            this.cb_BackflowPressure.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_BackflowPressure.FormattingEnabled = true;
            this.cb_BackflowPressure.ItemHeight = 15;
            this.cb_BackflowPressure.Location = new System.Drawing.Point(134, 72);
            this.cb_BackflowPressure.Name = "cb_BackflowPressure";
            this.cb_BackflowPressure.Size = new System.Drawing.Size(654, 21);
            this.cb_BackflowPressure.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_BackflowPressure.TabIndex = 5;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 70);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(92, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "指定回流压力：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 41);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(92, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "表压(帕)：";
            // 
            // cb_ReferenceFrame
            // 
            this.cb_ReferenceFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ReferenceFrame.DisplayMember = "Text";
            this.cb_ReferenceFrame.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_ReferenceFrame.FormattingEnabled = true;
            this.cb_ReferenceFrame.ItemHeight = 15;
            this.cb_ReferenceFrame.Location = new System.Drawing.Point(134, 14);
            this.cb_ReferenceFrame.Name = "cb_ReferenceFrame";
            this.cb_ReferenceFrame.Size = new System.Drawing.Size(654, 21);
            this.cb_ReferenceFrame.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_ReferenceFrame.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(92, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "回流参考框架：";
            // 
            // PressureOutletMomentumTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 567);
            this.Controls.Add(this.p_ContainPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PressureOutletMomentumTabForm";
            this.Text = "MassFlowOutletMomentumTabForm";
            this.Load += new System.EventHandler(this.PressureOutletMomentumTabForm_Load);
            this.p_ContainPanel.ResumeLayout(false);
            this.p_Turbulence.ResumeLayout(false);
            this.p_MassFlowRate.ResumeLayout(false);
            this.p_Checkbox.ResumeLayout(false);
            this.p_BackflowDirection.ResumeLayout(false);
            this.p_Basic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_ContainPanel;
        private System.Windows.Forms.Panel p_Basic;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_GaugePressure;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_BackflowDirection;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_BackflowPressure;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_ReferenceFrame;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel p_BackflowDirection;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_FlowDirection_Z;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_FlowDirection_Y;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_FlowDirection_X;
        private DevComponents.DotNetBar.LabelX labelX12;
        private System.Windows.Forms.Panel p_Checkbox;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckb_TargetMassFlow;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckb_AverageP;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckb_RadialEP;
        private System.Windows.Forms.Panel p_MassFlowRate;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_TargetMassFlow;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_LowPressure;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_UpPressure;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.Panel p_Turbulence;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_TurbulenceP2;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_TurbulenceP1;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX lb_TurbulenceP2;
        private DevComponents.DotNetBar.LabelX lb_TurbulenceP1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_TurbulenceMethod;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}