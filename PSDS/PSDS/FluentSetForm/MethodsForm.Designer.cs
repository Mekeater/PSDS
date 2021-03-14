namespace GlobeCode
{
    partial class MethodsForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_help = new System.Windows.Forms.Label();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cb_Pressure_VelocityCoupling = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cb_Pressure_VelocityCoupling);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 438);
            this.panel1.TabIndex = 0;
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
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(10, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(121, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "压强速度关联算法：";
            // 
            // cb_Pressure_VelocityCoupling
            // 
            this.cb_Pressure_VelocityCoupling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Pressure_VelocityCoupling.DisplayMember = "Text";
            this.cb_Pressure_VelocityCoupling.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Pressure_VelocityCoupling.FormattingEnabled = true;
            this.cb_Pressure_VelocityCoupling.ItemHeight = 15;
            this.cb_Pressure_VelocityCoupling.Location = new System.Drawing.Point(137, 22);
            this.cb_Pressure_VelocityCoupling.Name = "cb_Pressure_VelocityCoupling";
            this.cb_Pressure_VelocityCoupling.Size = new System.Drawing.Size(579, 21);
            this.cb_Pressure_VelocityCoupling.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_Pressure_VelocityCoupling.TabIndex = 1;
            this.cb_Pressure_VelocityCoupling.SelectedIndexChanged += new System.EventHandler(this.cb_Pressure_VelocityCoupling_SelectedIndexChanged);
            // 
            // MethodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MethodsForm";
            this.Text = "MethodsForm";
            this.Load += new System.EventHandler(this.MethodsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_help;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_Pressure_VelocityCoupling;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}