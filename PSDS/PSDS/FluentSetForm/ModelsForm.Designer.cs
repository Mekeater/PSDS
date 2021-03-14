namespace GlobeCode
{
    partial class ModelsForm
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
            this.cb_Energy = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cb_Species = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cb_Radiation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cb_Viscous = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_help = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Energy
            // 
            this.cb_Energy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Energy.DisplayMember = "Text";
            this.cb_Energy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Energy.FormattingEnabled = true;
            this.cb_Energy.ItemHeight = 15;
            this.cb_Energy.Location = new System.Drawing.Point(83, 28);
            this.cb_Energy.Name = "cb_Energy";
            this.cb_Energy.Size = new System.Drawing.Size(631, 21);
            this.cb_Energy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_Energy.TabIndex = 25;
            // 
            // cb_Species
            // 
            this.cb_Species.DisplayMember = "Text";
            this.cb_Species.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Species.FormattingEnabled = true;
            this.cb_Species.ItemHeight = 15;
            this.cb_Species.Location = new System.Drawing.Point(126, 163);
            this.cb_Species.Name = "cb_Species";
            this.cb_Species.Size = new System.Drawing.Size(582, 21);
            this.cb_Species.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_Species.TabIndex = 24;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelX2.Location = new System.Drawing.Point(2, 75);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 19;
            this.labelX2.Text = "湍流模型：";
            // 
            // cb_Radiation
            // 
            this.cb_Radiation.DisplayMember = "Text";
            this.cb_Radiation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Radiation.FormattingEnabled = true;
            this.cb_Radiation.ItemHeight = 15;
            this.cb_Radiation.Location = new System.Drawing.Point(83, 120);
            this.cb_Radiation.Name = "cb_Radiation";
            this.cb_Radiation.Size = new System.Drawing.Size(625, 21);
            this.cb_Radiation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_Radiation.TabIndex = 23;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(2, 26);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 18;
            this.labelX1.Text = "能量方程：";
            // 
            // cb_Viscous
            // 
            this.cb_Viscous.DisplayMember = "Text";
            this.cb_Viscous.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Viscous.FormattingEnabled = true;
            this.cb_Viscous.ItemHeight = 15;
            this.cb_Viscous.Location = new System.Drawing.Point(83, 75);
            this.cb_Viscous.Name = "cb_Viscous";
            this.cb_Viscous.Size = new System.Drawing.Size(625, 21);
            this.cb_Viscous.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_Viscous.TabIndex = 22;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(2, 120);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 20;
            this.labelX3.Text = "辐射模型：";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(2, 163);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(136, 23);
            this.labelX4.TabIndex = 21;
            this.labelX4.Text = "组分运输和反应模型：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lb_help);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 104);
            this.panel1.TabIndex = 26;
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
            // ModelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_Energy);
            this.Controls.Add(this.cb_Species);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cb_Radiation);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cb_Viscous);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModelsForm";
            this.Text = "ModelsForm";
            this.Load += new System.EventHandler(this.ModelsForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_Energy;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_Species;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_Radiation;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_Viscous;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_help;
    }
}