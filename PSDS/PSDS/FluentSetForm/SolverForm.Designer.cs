namespace GlobeCode
{
    partial class SolverForm
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
            this.tb_MeshFile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_browse = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_help = new System.Windows.Forms.Label();
            this.cb_SolverType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cb_VelocityFormulation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cb_TimeType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ckB_Gravity = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cb_GravityDirection = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.tb_GravitySize = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.tb_MeshFile.Location = new System.Drawing.Point(93, 35);
            this.tb_MeshFile.Name = "tb_MeshFile";
            this.tb_MeshFile.PreventEnterBeep = true;
            this.tb_MeshFile.Size = new System.Drawing.Size(534, 21);
            this.tb_MeshFile.TabIndex = 4;
            // 
            // btn_browse
            // 
            this.btn_browse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_browse.Location = new System.Drawing.Point(633, 35);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_browse.TabIndex = 5;
            this.btn_browse.Text = "浏览...";
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(5, 35);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "Mesh文件：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lb_help);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 108);
            this.panel1.TabIndex = 10;
            // 
            // lb_help
            // 
            this.lb_help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_help.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_help.ForeColor = System.Drawing.Color.Green;
            this.lb_help.Location = new System.Drawing.Point(0, 0);
            this.lb_help.Name = "lb_help";
            this.lb_help.Size = new System.Drawing.Size(726, 104);
            this.lb_help.TabIndex = 1;
            this.lb_help.Text = "帮助：";
            // 
            // cb_SolverType
            // 
            this.cb_SolverType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_SolverType.DisplayMember = "Text";
            this.cb_SolverType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_SolverType.FormattingEnabled = true;
            this.cb_SolverType.ItemHeight = 15;
            this.cb_SolverType.Location = new System.Drawing.Point(93, 95);
            this.cb_SolverType.Name = "cb_SolverType";
            this.cb_SolverType.Size = new System.Drawing.Size(615, 21);
            this.cb_SolverType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_SolverType.TabIndex = 11;
            this.cb_SolverType.SelectedIndexChanged += new System.EventHandler(this.cb_SolverType_SelectedIndexChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(5, 95);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(83, 21);
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "求解器类型：";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(5, 151);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(83, 21);
            this.labelX4.TabIndex = 14;
            this.labelX4.Text = "速度方程：";
            // 
            // cb_VelocityFormulation
            // 
            this.cb_VelocityFormulation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_VelocityFormulation.DisplayMember = "Text";
            this.cb_VelocityFormulation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_VelocityFormulation.FormattingEnabled = true;
            this.cb_VelocityFormulation.ItemHeight = 15;
            this.cb_VelocityFormulation.Location = new System.Drawing.Point(93, 151);
            this.cb_VelocityFormulation.Name = "cb_VelocityFormulation";
            this.cb_VelocityFormulation.Size = new System.Drawing.Size(615, 21);
            this.cb_VelocityFormulation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_VelocityFormulation.TabIndex = 13;
            this.cb_VelocityFormulation.SelectedIndexChanged += new System.EventHandler(this.cb_VelocityFormulation_SelectedIndexChanged);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(5, 204);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(83, 21);
            this.labelX5.TabIndex = 16;
            this.labelX5.Text = "时间类型：";
            // 
            // cb_TimeType
            // 
            this.cb_TimeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_TimeType.DisplayMember = "Text";
            this.cb_TimeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_TimeType.FormattingEnabled = true;
            this.cb_TimeType.ItemHeight = 15;
            this.cb_TimeType.Location = new System.Drawing.Point(93, 204);
            this.cb_TimeType.Name = "cb_TimeType";
            this.cb_TimeType.Size = new System.Drawing.Size(615, 21);
            this.cb_TimeType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_TimeType.TabIndex = 15;
            this.cb_TimeType.SelectedIndexChanged += new System.EventHandler(this.cb_TimeType_SelectedIndexChanged);
            // 
            // ckB_Gravity
            // 
            // 
            // 
            // 
            this.ckB_Gravity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ckB_Gravity.Location = new System.Drawing.Point(93, 254);
            this.ckB_Gravity.Name = "ckB_Gravity";
            this.ckB_Gravity.Size = new System.Drawing.Size(88, 23);
            this.ckB_Gravity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ckB_Gravity.TabIndex = 17;
            this.ckB_Gravity.Text = "考虑重力";
            this.ckB_Gravity.CheckedChanged += new System.EventHandler(this.ckB_Gravity_CheckedChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(179, 254);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 18;
            this.labelX2.Text = "重力方向：";
            // 
            // cb_GravityDirection
            // 
            this.cb_GravityDirection.DisplayMember = "Text";
            this.cb_GravityDirection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_GravityDirection.Enabled = false;
            this.cb_GravityDirection.FormattingEnabled = true;
            this.cb_GravityDirection.ItemHeight = 15;
            this.cb_GravityDirection.Location = new System.Drawing.Point(247, 254);
            this.cb_GravityDirection.Name = "cb_GravityDirection";
            this.cb_GravityDirection.Size = new System.Drawing.Size(110, 21);
            this.cb_GravityDirection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_GravityDirection.TabIndex = 19;
            this.cb_GravityDirection.SelectedIndexChanged += new System.EventHandler(this.cb_GravityDirection_SelectedIndexChanged);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(381, 254);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(106, 23);
            this.labelX6.TabIndex = 18;
            this.labelX6.Text = "重力大小(m/s2)：";
            // 
            // tb_GravitySize
            // 
            // 
            // 
            // 
            this.tb_GravitySize.Border.Class = "TextBoxBorder";
            this.tb_GravitySize.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_GravitySize.Enabled = false;
            this.tb_GravitySize.Location = new System.Drawing.Point(493, 254);
            this.tb_GravitySize.Name = "tb_GravitySize";
            this.tb_GravitySize.PreventEnterBeep = true;
            this.tb_GravitySize.Size = new System.Drawing.Size(101, 21);
            this.tb_GravitySize.TabIndex = 20;
            this.tb_GravitySize.Text = "-9.81";
            this.tb_GravitySize.TextChanged += new System.EventHandler(this.tb_GravitySize_TextChanged);
            // 
            // SolverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 438);
            this.Controls.Add(this.tb_GravitySize);
            this.Controls.Add(this.cb_GravityDirection);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.ckB_Gravity);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.cb_TimeType);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.cb_VelocityFormulation);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.cb_SolverType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.tb_MeshFile);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SolverForm";
            this.Text = "MeshFlieForm";
            this.Load += new System.EventHandler(this.MeshFlieForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.TextBoxX tb_MeshFile;
        private DevComponents.DotNetBar.ButtonX btn_browse;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_SolverType;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_VelocityFormulation;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_TimeType;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckB_Gravity;
        private System.Windows.Forms.Label lb_help;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_GravityDirection;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_GravitySize;
    }
}