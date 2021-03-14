namespace GlobeCode
{
    partial class ProfileSimulationParametersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileSimulationParametersForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_projectName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.btn_Sure = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_pollutionMatrial = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btn_SaveMassFlowInlet = new DevComponents.DotNetBar.ButtonX();
            this.btn_SaveSpeedInlet = new DevComponents.DotNetBar.ButtonX();
            this.tb_airSpeed = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btn_Solve = new DevComponents.DotNetBar.ButtonX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.tb_pollutionLoad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cb_pollutionZone = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cb_airInletZone = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.ckb_TimeType = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btn_browse = new DevComponents.DotNetBar.ButtonX();
            this.tb_MeshFile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.tb_projectName);
            this.panel3.Controls.Add(this.labelX1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(566, 47);
            this.panel3.TabIndex = 3;
            // 
            // tb_projectName
            // 
            this.tb_projectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_projectName.Border.Class = "TextBoxBorder";
            this.tb_projectName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_projectName.Location = new System.Drawing.Point(109, 10);
            this.tb_projectName.Name = "tb_projectName";
            this.tb_projectName.PreventEnterBeep = true;
            this.tb_projectName.Size = new System.Drawing.Size(450, 21);
            this.tb_projectName.TabIndex = 1;
            this.tb_projectName.TextChanged += new System.EventHandler(this.tb_projectName_TextChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(10, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(93, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "模拟项目名称：";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Controls.Add(this.btn_Sure);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 421);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 62);
            this.panel2.TabIndex = 4;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(477, 19);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "关闭";
            // 
            // btn_Sure
            // 
            this.btn_Sure.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Sure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sure.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Sure.Location = new System.Drawing.Point(368, 19);
            this.btn_Sure.Name = "btn_Sure";
            this.btn_Sure.Size = new System.Drawing.Size(75, 23);
            this.btn_Sure.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Sure.TabIndex = 0;
            this.btn_Sure.Text = "确定";
            this.btn_Sure.Click += new System.EventHandler(this.btn_Sure_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cb_pollutionMatrial);
            this.panel1.Controls.Add(this.labelX7);
            this.panel1.Controls.Add(this.btn_SaveMassFlowInlet);
            this.panel1.Controls.Add(this.btn_SaveSpeedInlet);
            this.panel1.Controls.Add(this.tb_airSpeed);
            this.panel1.Controls.Add(this.buttonX1);
            this.panel1.Controls.Add(this.btn_Solve);
            this.panel1.Controls.Add(this.labelX6);
            this.panel1.Controls.Add(this.tb_pollutionLoad);
            this.panel1.Controls.Add(this.cb_pollutionZone);
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.labelX4);
            this.panel1.Controls.Add(this.cb_airInletZone);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.ckb_TimeType);
            this.panel1.Controls.Add(this.btn_browse);
            this.panel1.Controls.Add(this.tb_MeshFile);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 374);
            this.panel1.TabIndex = 5;
            // 
            // cb_pollutionMatrial
            // 
            this.cb_pollutionMatrial.DisplayMember = "Text";
            this.cb_pollutionMatrial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_pollutionMatrial.FormattingEnabled = true;
            this.cb_pollutionMatrial.ItemHeight = 15;
            this.cb_pollutionMatrial.Location = new System.Drawing.Point(109, 100);
            this.cb_pollutionMatrial.Name = "cb_pollutionMatrial";
            this.cb_pollutionMatrial.Size = new System.Drawing.Size(121, 21);
            this.cb_pollutionMatrial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_pollutionMatrial.TabIndex = 35;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(10, 98);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(80, 23);
            this.labelX7.TabIndex = 34;
            this.labelX7.Text = "污染源材料：";
            // 
            // btn_SaveMassFlowInlet
            // 
            this.btn_SaveMassFlowInlet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SaveMassFlowInlet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SaveMassFlowInlet.Location = new System.Drawing.Point(480, 183);
            this.btn_SaveMassFlowInlet.Name = "btn_SaveMassFlowInlet";
            this.btn_SaveMassFlowInlet.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveMassFlowInlet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SaveMassFlowInlet.TabIndex = 33;
            this.btn_SaveMassFlowInlet.Text = "保存";
            this.btn_SaveMassFlowInlet.Click += new System.EventHandler(this.btn_SaveMassFlowInlet_Click);
            // 
            // btn_SaveSpeedInlet
            // 
            this.btn_SaveSpeedInlet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SaveSpeedInlet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SaveSpeedInlet.Location = new System.Drawing.Point(480, 142);
            this.btn_SaveSpeedInlet.Name = "btn_SaveSpeedInlet";
            this.btn_SaveSpeedInlet.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveSpeedInlet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SaveSpeedInlet.TabIndex = 32;
            this.btn_SaveSpeedInlet.Text = "保存";
            this.btn_SaveSpeedInlet.Click += new System.EventHandler(this.btn_SaveSpeedInlet_Click);
            // 
            // tb_airSpeed
            // 
            // 
            // 
            // 
            this.tb_airSpeed.Border.Class = "TextBoxBorder";
            this.tb_airSpeed.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_airSpeed.Location = new System.Drawing.Point(371, 144);
            this.tb_airSpeed.Name = "tb_airSpeed";
            this.tb_airSpeed.PreventEnterBeep = true;
            this.tb_airSpeed.Size = new System.Drawing.Size(96, 21);
            this.tb_airSpeed.TabIndex = 31;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(10, 277);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(100, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 30;
            this.buttonX1.Text = "计算结果导出...";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btn_Solve
            // 
            this.btn_Solve.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Solve.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Solve.Location = new System.Drawing.Point(10, 229);
            this.btn_Solve.Name = "btn_Solve";
            this.btn_Solve.Size = new System.Drawing.Size(93, 23);
            this.btn_Solve.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Solve.TabIndex = 29;
            this.btn_Solve.Text = "迭代求解...";
            this.btn_Solve.Click += new System.EventHandler(this.btn_Solve_Click);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(236, 183);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(130, 23);
            this.labelX6.TabIndex = 28;
            this.labelX6.Text = "污染物量(kg/m2-s)：";
            // 
            // tb_pollutionLoad
            // 
            // 
            // 
            // 
            this.tb_pollutionLoad.Border.Class = "TextBoxBorder";
            this.tb_pollutionLoad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_pollutionLoad.Location = new System.Drawing.Point(371, 183);
            this.tb_pollutionLoad.Name = "tb_pollutionLoad";
            this.tb_pollutionLoad.PreventEnterBeep = true;
            this.tb_pollutionLoad.Size = new System.Drawing.Size(96, 21);
            this.tb_pollutionLoad.TabIndex = 27;
            this.tb_pollutionLoad.TextChanged += new System.EventHandler(this.tb_pollutionLoad_TextChanged);
            // 
            // cb_pollutionZone
            // 
            this.cb_pollutionZone.DisplayMember = "Text";
            this.cb_pollutionZone.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_pollutionZone.FormattingEnabled = true;
            this.cb_pollutionZone.ItemHeight = 15;
            this.cb_pollutionZone.Location = new System.Drawing.Point(109, 183);
            this.cb_pollutionZone.Name = "cb_pollutionZone";
            this.cb_pollutionZone.Size = new System.Drawing.Size(121, 21);
            this.cb_pollutionZone.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_pollutionZone.TabIndex = 26;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(10, 183);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(93, 23);
            this.labelX5.TabIndex = 25;
            this.labelX5.Text = "污染源区域：";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(236, 144);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(102, 23);
            this.labelX4.TabIndex = 23;
            this.labelX4.Text = "风速大小(m/s)：";
            // 
            // cb_airInletZone
            // 
            this.cb_airInletZone.DisplayMember = "Text";
            this.cb_airInletZone.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_airInletZone.FormattingEnabled = true;
            this.cb_airInletZone.ItemHeight = 15;
            this.cb_airInletZone.Location = new System.Drawing.Point(109, 144);
            this.cb_airInletZone.Name = "cb_airInletZone";
            this.cb_airInletZone.Size = new System.Drawing.Size(121, 21);
            this.cb_airInletZone.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_airInletZone.TabIndex = 22;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(10, 144);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(93, 23);
            this.labelX3.TabIndex = 21;
            this.labelX3.Text = "风速入口边界：";
            // 
            // ckb_TimeType
            // 
            // 
            // 
            // 
            this.ckb_TimeType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ckb_TimeType.Location = new System.Drawing.Point(10, 58);
            this.ckb_TimeType.Name = "ckb_TimeType";
            this.ckb_TimeType.Size = new System.Drawing.Size(136, 23);
            this.ckb_TimeType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ckb_TimeType.TabIndex = 18;
            this.ckb_TimeType.Text = "扩散是否随时间变化";
            this.ckb_TimeType.CheckedChanged += new System.EventHandler(this.ckb_TimeType_CheckedChanged);
            // 
            // btn_browse
            // 
            this.btn_browse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_browse.Location = new System.Drawing.Point(477, 17);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_browse.TabIndex = 7;
            this.btn_browse.Text = "浏览...";
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // tb_MeshFile
            // 
            this.tb_MeshFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_MeshFile.Border.Class = "TextBoxBorder";
            this.tb_MeshFile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_MeshFile.Location = new System.Drawing.Point(109, 17);
            this.tb_MeshFile.Name = "tb_MeshFile";
            this.tb_MeshFile.PreventEnterBeep = true;
            this.tb_MeshFile.Size = new System.Drawing.Size(362, 21);
            this.tb_MeshFile.TabIndex = 6;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(10, 17);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(93, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "网格文件路径：";
            // 
            // ProfileSimulationParametersForm
            // 
            this.AcceptButton = this.btn_Sure;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(566, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProfileSimulationParametersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "模拟参数设置【简要模式】";
            this.Load += new System.EventHandler(this.ProfileSimulationParametersForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_projectName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX btn_Cancel;
        private DevComponents.DotNetBar.ButtonX btn_Sure;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btn_browse;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_MeshFile;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckb_TimeType;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_pollutionLoad;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_pollutionZone;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_airInletZone;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btn_Solve;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_airSpeed;
        private DevComponents.DotNetBar.ButtonX btn_SaveMassFlowInlet;
        private DevComponents.DotNetBar.ButtonX btn_SaveSpeedInlet;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_pollutionMatrial;
    }
}