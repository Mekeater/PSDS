namespace GlobeCode
{
    partial class MassFlowInletMomentumTabForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_Turbulence = new System.Windows.Forms.Panel();
            this.tb_TurbulenceP2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_TurbulenceP1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.lb_TurbulenceP2 = new DevComponents.DotNetBar.LabelX();
            this.lb_TurbulenceP1 = new DevComponents.DotNetBar.LabelX();
            this.cb_TurbulenceMethod = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.p_AverageMassFlux = new System.Windows.Forms.Panel();
            this.tb_averageFlux = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.p_MassFlux = new System.Windows.Forms.Panel();
            this.tb_massFlowFlux = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.p_MassFlowRate = new System.Windows.Forms.Panel();
            this.tb_massFlowRate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.p_Direction = new System.Windows.Forms.Panel();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.tb_FlowDirection_Z = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_FlowDirection_Y = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_FlowDirection_X = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.p_Basic = new System.Windows.Forms.Panel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cb_MsssFlowMethod = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tb_InitialGaugePressure = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cb_Direction = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cb_ReferenceFrame = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel1.SuspendLayout();
            this.p_Turbulence.SuspendLayout();
            this.p_AverageMassFlux.SuspendLayout();
            this.p_MassFlux.SuspendLayout();
            this.p_MassFlowRate.SuspendLayout();
            this.p_Direction.SuspendLayout();
            this.p_Basic.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.p_Turbulence);
            this.panel1.Controls.Add(this.p_AverageMassFlux);
            this.panel1.Controls.Add(this.p_MassFlux);
            this.panel1.Controls.Add(this.p_MassFlowRate);
            this.panel1.Controls.Add(this.p_Direction);
            this.panel1.Controls.Add(this.p_Basic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 483);
            this.panel1.TabIndex = 0;
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
            this.p_Turbulence.Location = new System.Drawing.Point(0, 332);
            this.p_Turbulence.Name = "p_Turbulence";
            this.p_Turbulence.Size = new System.Drawing.Size(988, 125);
            this.p_Turbulence.TabIndex = 20;
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
            this.tb_TurbulenceP2.Size = new System.Drawing.Size(822, 21);
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
            this.tb_TurbulenceP1.Size = new System.Drawing.Size(822, 21);
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
            this.cb_TurbulenceMethod.Size = new System.Drawing.Size(822, 21);
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
            // p_AverageMassFlux
            // 
            this.p_AverageMassFlux.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_AverageMassFlux.Controls.Add(this.tb_averageFlux);
            this.p_AverageMassFlux.Controls.Add(this.labelX7);
            this.p_AverageMassFlux.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_AverageMassFlux.Location = new System.Drawing.Point(0, 297);
            this.p_AverageMassFlux.Name = "p_AverageMassFlux";
            this.p_AverageMassFlux.Size = new System.Drawing.Size(988, 35);
            this.p_AverageMassFlux.TabIndex = 19;
            this.p_AverageMassFlux.Visible = false;
            // 
            // tb_averageFlux
            // 
            this.tb_averageFlux.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_averageFlux.Border.Class = "TextBoxBorder";
            this.tb_averageFlux.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_averageFlux.Location = new System.Drawing.Point(174, 6);
            this.tb_averageFlux.Name = "tb_averageFlux";
            this.tb_averageFlux.PreventEnterBeep = true;
            this.tb_averageFlux.Size = new System.Drawing.Size(794, 21);
            this.tb_averageFlux.TabIndex = 26;
            this.tb_averageFlux.Text = "1";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(10, 6);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(158, 23);
            this.labelX7.TabIndex = 25;
            this.labelX7.Text = "平均质量通量(kg/m2-s)：";
            // 
            // p_MassFlux
            // 
            this.p_MassFlux.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_MassFlux.Controls.Add(this.tb_massFlowFlux);
            this.p_MassFlux.Controls.Add(this.labelX6);
            this.p_MassFlux.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_MassFlux.Location = new System.Drawing.Point(0, 258);
            this.p_MassFlux.Name = "p_MassFlux";
            this.p_MassFlux.Size = new System.Drawing.Size(988, 39);
            this.p_MassFlux.TabIndex = 18;
            this.p_MassFlux.Visible = false;
            // 
            // tb_massFlowFlux
            // 
            this.tb_massFlowFlux.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_massFlowFlux.Border.Class = "TextBoxBorder";
            this.tb_massFlowFlux.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_massFlowFlux.Location = new System.Drawing.Point(152, 6);
            this.tb_massFlowFlux.Name = "tb_massFlowFlux";
            this.tb_massFlowFlux.PreventEnterBeep = true;
            this.tb_massFlowFlux.Size = new System.Drawing.Size(816, 21);
            this.tb_massFlowFlux.TabIndex = 24;
            this.tb_massFlowFlux.Text = "1";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(10, 8);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(136, 23);
            this.labelX6.TabIndex = 23;
            this.labelX6.Text = "质量通量(kg/m2-s)：";
            // 
            // p_MassFlowRate
            // 
            this.p_MassFlowRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_MassFlowRate.Controls.Add(this.tb_massFlowRate);
            this.p_MassFlowRate.Controls.Add(this.labelX5);
            this.p_MassFlowRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_MassFlowRate.Location = new System.Drawing.Point(0, 222);
            this.p_MassFlowRate.Name = "p_MassFlowRate";
            this.p_MassFlowRate.Size = new System.Drawing.Size(988, 36);
            this.p_MassFlowRate.TabIndex = 14;
            // 
            // tb_massFlowRate
            // 
            this.tb_massFlowRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_massFlowRate.Border.Class = "TextBoxBorder";
            this.tb_massFlowRate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_massFlowRate.Location = new System.Drawing.Point(152, 4);
            this.tb_massFlowRate.Name = "tb_massFlowRate";
            this.tb_massFlowRate.PreventEnterBeep = true;
            this.tb_massFlowRate.Size = new System.Drawing.Size(818, 21);
            this.tb_massFlowRate.TabIndex = 22;
            this.tb_massFlowRate.Text = "1";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(10, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(106, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "质量流率(kg/s)：";
            // 
            // p_Direction
            // 
            this.p_Direction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_Direction.Controls.Add(this.labelX9);
            this.p_Direction.Controls.Add(this.labelX10);
            this.p_Direction.Controls.Add(this.labelX11);
            this.p_Direction.Controls.Add(this.tb_FlowDirection_Z);
            this.p_Direction.Controls.Add(this.tb_FlowDirection_Y);
            this.p_Direction.Controls.Add(this.tb_FlowDirection_X);
            this.p_Direction.Controls.Add(this.labelX12);
            this.p_Direction.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Direction.Location = new System.Drawing.Point(0, 134);
            this.p_Direction.Name = "p_Direction";
            this.p_Direction.Size = new System.Drawing.Size(988, 88);
            this.p_Direction.TabIndex = 13;
            this.p_Direction.Visible = false;
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
            this.tb_FlowDirection_Z.Location = new System.Drawing.Point(152, 60);
            this.tb_FlowDirection_Z.Name = "tb_FlowDirection_Z";
            this.tb_FlowDirection_Z.PreventEnterBeep = true;
            this.tb_FlowDirection_Z.Size = new System.Drawing.Size(820, 21);
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
            this.tb_FlowDirection_Y.Location = new System.Drawing.Point(152, 33);
            this.tb_FlowDirection_Y.Name = "tb_FlowDirection_Y";
            this.tb_FlowDirection_Y.PreventEnterBeep = true;
            this.tb_FlowDirection_Y.Size = new System.Drawing.Size(820, 21);
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
            this.tb_FlowDirection_X.Location = new System.Drawing.Point(152, 6);
            this.tb_FlowDirection_X.Name = "tb_FlowDirection_X";
            this.tb_FlowDirection_X.PreventEnterBeep = true;
            this.tb_FlowDirection_X.Size = new System.Drawing.Size(820, 21);
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
            this.p_Basic.Controls.Add(this.labelX2);
            this.p_Basic.Controls.Add(this.cb_MsssFlowMethod);
            this.p_Basic.Controls.Add(this.tb_InitialGaugePressure);
            this.p_Basic.Controls.Add(this.labelX4);
            this.p_Basic.Controls.Add(this.cb_Direction);
            this.p_Basic.Controls.Add(this.labelX3);
            this.p_Basic.Controls.Add(this.cb_ReferenceFrame);
            this.p_Basic.Controls.Add(this.labelX1);
            this.p_Basic.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Basic.Location = new System.Drawing.Point(0, 0);
            this.p_Basic.Name = "p_Basic";
            this.p_Basic.Size = new System.Drawing.Size(988, 134);
            this.p_Basic.TabIndex = 12;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(10, 99);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(106, 23);
            this.labelX2.TabIndex = 15;
            this.labelX2.Text = "指定质量流方法：";
            // 
            // cb_MsssFlowMethod
            // 
            this.cb_MsssFlowMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_MsssFlowMethod.DisplayMember = "Text";
            this.cb_MsssFlowMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_MsssFlowMethod.FormattingEnabled = true;
            this.cb_MsssFlowMethod.ItemHeight = 15;
            this.cb_MsssFlowMethod.Location = new System.Drawing.Point(150, 101);
            this.cb_MsssFlowMethod.Name = "cb_MsssFlowMethod";
            this.cb_MsssFlowMethod.Size = new System.Drawing.Size(820, 21);
            this.cb_MsssFlowMethod.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_MsssFlowMethod.TabIndex = 14;
            this.cb_MsssFlowMethod.Text = " ";
            this.cb_MsssFlowMethod.SelectedIndexChanged += new System.EventHandler(this.cb_MsssFlowMethod_SelectedIndexChanged);
            // 
            // tb_InitialGaugePressure
            // 
            this.tb_InitialGaugePressure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_InitialGaugePressure.Border.Class = "TextBoxBorder";
            this.tb_InitialGaugePressure.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_InitialGaugePressure.Location = new System.Drawing.Point(150, 43);
            this.tb_InitialGaugePressure.Name = "tb_InitialGaugePressure";
            this.tb_InitialGaugePressure.PreventEnterBeep = true;
            this.tb_InitialGaugePressure.Size = new System.Drawing.Size(820, 21);
            this.tb_InitialGaugePressure.TabIndex = 13;
            this.tb_InitialGaugePressure.Text = "0";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(10, 70);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(106, 23);
            this.labelX4.TabIndex = 12;
            this.labelX4.Text = "指定方向：";
            // 
            // cb_Direction
            // 
            this.cb_Direction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Direction.DisplayMember = "Text";
            this.cb_Direction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Direction.FormattingEnabled = true;
            this.cb_Direction.ItemHeight = 15;
            this.cb_Direction.Location = new System.Drawing.Point(150, 72);
            this.cb_Direction.Name = "cb_Direction";
            this.cb_Direction.Size = new System.Drawing.Size(820, 21);
            this.cb_Direction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_Direction.TabIndex = 7;
            this.cb_Direction.Text = " ";
            this.cb_Direction.SelectedIndexChanged += new System.EventHandler(this.cb_Direction_SelectedIndexChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(10, 41);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(139, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "超音速/初始表压(帕)：";
            // 
            // cb_ReferenceFrame
            // 
            this.cb_ReferenceFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ReferenceFrame.DisplayMember = "Text";
            this.cb_ReferenceFrame.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_ReferenceFrame.FormattingEnabled = true;
            this.cb_ReferenceFrame.ItemHeight = 15;
            this.cb_ReferenceFrame.Location = new System.Drawing.Point(152, 14);
            this.cb_ReferenceFrame.Name = "cb_ReferenceFrame";
            this.cb_ReferenceFrame.Size = new System.Drawing.Size(820, 21);
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
            // MassFlowInletMomentumTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 483);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MassFlowInletMomentumTabForm";
            this.Text = "MassFlowInletMomentumTabForm";
            this.Load += new System.EventHandler(this.MassFlowInletMomentumTabForm_Load);
            this.panel1.ResumeLayout(false);
            this.p_Turbulence.ResumeLayout(false);
            this.p_AverageMassFlux.ResumeLayout(false);
            this.p_MassFlux.ResumeLayout(false);
            this.p_MassFlowRate.ResumeLayout(false);
            this.p_Direction.ResumeLayout(false);
            this.p_Basic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel p_Basic;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_InitialGaugePressure;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_Direction;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_ReferenceFrame;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_MsssFlowMethod;
        private System.Windows.Forms.Panel p_Direction;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_FlowDirection_Z;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_FlowDirection_Y;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_FlowDirection_X;
        private DevComponents.DotNetBar.LabelX labelX12;
        private System.Windows.Forms.Panel p_MassFlowRate;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_averageFlux;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_massFlowFlux;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_massFlowRate;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.Panel p_AverageMassFlux;
        private System.Windows.Forms.Panel p_MassFlux;
        private System.Windows.Forms.Panel p_Turbulence;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_TurbulenceP2;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_TurbulenceP1;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX lb_TurbulenceP2;
        private DevComponents.DotNetBar.LabelX lb_TurbulenceP1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_TurbulenceMethod;
        private DevComponents.DotNetBar.LabelX labelX16;
    }
}