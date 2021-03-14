namespace GlobeCode
{
    partial class ThermalTabForm
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
            this.lb_Temperature = new DevComponents.DotNetBar.LabelX();
            this.tb_Temperature = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // lb_Temperature
            // 
            // 
            // 
            // 
            this.lb_Temperature.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_Temperature.Location = new System.Drawing.Point(11, 26);
            this.lb_Temperature.Name = "lb_Temperature";
            this.lb_Temperature.Size = new System.Drawing.Size(70, 23);
            this.lb_Temperature.TabIndex = 0;
            this.lb_Temperature.Text = "温度(K)：";
            // 
            // tb_Temperature
            // 
            this.tb_Temperature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_Temperature.Border.Class = "TextBoxBorder";
            this.tb_Temperature.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_Temperature.Location = new System.Drawing.Point(87, 26);
            this.tb_Temperature.Name = "tb_Temperature";
            this.tb_Temperature.PreventEnterBeep = true;
            this.tb_Temperature.Size = new System.Drawing.Size(532, 21);
            this.tb_Temperature.TabIndex = 1;
            this.tb_Temperature.Text = "300";
            // 
            // ThermalTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 435);
            this.Controls.Add(this.tb_Temperature);
            this.Controls.Add(this.lb_Temperature);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThermalTabForm";
            this.Text = "ThermalTabForm";
            this.Load += new System.EventHandler(this.ThermalTabForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lb_Temperature;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Temperature;
    }
}