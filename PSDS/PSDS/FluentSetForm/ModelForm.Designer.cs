namespace GlobeCode
{
    partial class ModelForm
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
            this.cb_Species = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cb_Radiation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cb_Viscous = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cb_Energy = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_help = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cb_Species);
            this.panel1.Controls.Add(this.cb_Radiation);
            this.panel1.Controls.Add(this.cb_Viscous);
            this.panel1.Controls.Add(this.cb_Energy);
            this.panel1.Controls.Add(this.labelX4);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 438);
            this.panel1.TabIndex = 0;
            // 
            // cb_Species
            // 
            this.cb_Species.DisplayMember = "Text";
            this.cb_Species.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Species.FormattingEnabled = true;
            this.cb_Species.ItemHeight = 15;
            this.cb_Species.Location = new System.Drawing.Point(134, 167);
            this.cb_Species.Name = "cb_Species";
            this.cb_Species.Size = new System.Drawing.Size(584, 21);
            this.cb_Species.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_Species.TabIndex = 7;
            this.cb_Species.SelectedIndexChanged += new System.EventHandler(this.cb_Species_SelectedIndexChanged);
            // 
            // cb_Radiation
            // 
            this.cb_Radiation.DisplayMember = "Text";
            this.cb_Radiation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Radiation.FormattingEnabled = true;
            this.cb_Radiation.ItemHeight = 15;
            this.cb_Radiation.Location = new System.Drawing.Point(78, 124);
            this.cb_Radiation.Name = "cb_Radiation";
            this.cb_Radiation.Size = new System.Drawing.Size(640, 21);
            this.cb_Radiation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_Radiation.TabIndex = 6;
            this.cb_Radiation.SelectedIndexChanged += new System.EventHandler(this.cb_Radiation_SelectedIndexChanged);
            // 
            // cb_Viscous
            // 
            this.cb_Viscous.DisplayMember = "Text";
            this.cb_Viscous.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Viscous.FormattingEnabled = true;
            this.cb_Viscous.ItemHeight = 15;
            this.cb_Viscous.Location = new System.Drawing.Point(78, 81);
            this.cb_Viscous.Name = "cb_Viscous";
            this.cb_Viscous.Size = new System.Drawing.Size(640, 21);
            this.cb_Viscous.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_Viscous.TabIndex = 5;
            this.cb_Viscous.SelectedIndexChanged += new System.EventHandler(this.cb_Viscous_SelectedIndexChanged);
            // 
            // cb_Energy
            // 
            this.cb_Energy.DisplayMember = "Text";
            this.cb_Energy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Energy.FormattingEnabled = true;
            this.cb_Energy.ItemHeight = 15;
            this.cb_Energy.Location = new System.Drawing.Point(78, 28);
            this.cb_Energy.Name = "cb_Energy";
            this.cb_Energy.Size = new System.Drawing.Size(640, 21);
            this.cb_Energy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_Energy.TabIndex = 4;
            this.cb_Energy.SelectedIndexChanged += new System.EventHandler(this.cb_Energy_SelectedIndexChanged);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelX4.Location = new System.Drawing.Point(10, 167);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(136, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "组分运输和反应模型：";
            this.labelX4.Click += new System.EventHandler(this.labelX4_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelX3.Location = new System.Drawing.Point(10, 124);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "辐射模型：";
            this.labelX3.Click += new System.EventHandler(this.labelX3_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelX2.Location = new System.Drawing.Point(10, 79);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "湍流模型：";
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(10, 30);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "能量方程：";
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
            this.lb_help.TabIndex = 2;
            this.lb_help.Text = "帮助：";
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModelForm";
            this.Text = "ModelForm";
            this.Load += new System.EventHandler(this.ModelForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_help;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_Species;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_Radiation;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_Viscous;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_Energy;
    }
}