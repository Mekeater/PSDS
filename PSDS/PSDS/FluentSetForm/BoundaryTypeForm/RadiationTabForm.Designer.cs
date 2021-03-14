namespace GlobeCode
{
    partial class RadiationTabForm
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cb_TemperatureMethod = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tb_Emissivity = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_BlackBoduTem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_BlackBoduTem = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(125, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "外部黑体温度方法：";
            // 
            // cb_TemperatureMethod
            // 
            this.cb_TemperatureMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_TemperatureMethod.DisplayMember = "Text";
            this.cb_TemperatureMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_TemperatureMethod.FormattingEnabled = true;
            this.cb_TemperatureMethod.ItemHeight = 15;
            this.cb_TemperatureMethod.Location = new System.Drawing.Point(130, 25);
            this.cb_TemperatureMethod.Name = "cb_TemperatureMethod";
            this.cb_TemperatureMethod.Size = new System.Drawing.Size(491, 21);
            this.cb_TemperatureMethod.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_TemperatureMethod.TabIndex = 1;
            this.cb_TemperatureMethod.SelectedIndexChanged += new System.EventHandler(this.cb_TemperatureMethod_SelectedIndexChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 117);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(125, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "内部辐射率：";
            // 
            // tb_Emissivity
            // 
            this.tb_Emissivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_Emissivity.Border.Class = "TextBoxBorder";
            this.tb_Emissivity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_Emissivity.Location = new System.Drawing.Point(130, 119);
            this.tb_Emissivity.Name = "tb_Emissivity";
            this.tb_Emissivity.PreventEnterBeep = true;
            this.tb_Emissivity.Size = new System.Drawing.Size(491, 21);
            this.tb_Emissivity.TabIndex = 3;
            this.tb_Emissivity.Text = "1";
            // 
            // tb_BlackBoduTem
            // 
            this.tb_BlackBoduTem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_BlackBoduTem.Border.Class = "TextBoxBorder";
            this.tb_BlackBoduTem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_BlackBoduTem.Location = new System.Drawing.Point(130, 74);
            this.tb_BlackBoduTem.Name = "tb_BlackBoduTem";
            this.tb_BlackBoduTem.PreventEnterBeep = true;
            this.tb_BlackBoduTem.Size = new System.Drawing.Size(491, 21);
            this.tb_BlackBoduTem.TabIndex = 5;
            this.tb_BlackBoduTem.Text = "300";
            this.tb_BlackBoduTem.Visible = false;
            // 
            // lb_BlackBoduTem
            // 
            // 
            // 
            // 
            this.lb_BlackBoduTem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_BlackBoduTem.Location = new System.Drawing.Point(12, 72);
            this.lb_BlackBoduTem.Name = "lb_BlackBoduTem";
            this.lb_BlackBoduTem.Size = new System.Drawing.Size(112, 23);
            this.lb_BlackBoduTem.TabIndex = 4;
            this.lb_BlackBoduTem.Text = "黑体温度(K)：";
            this.lb_BlackBoduTem.Visible = false;
            // 
            // RadiationTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 400);
            this.Controls.Add(this.tb_BlackBoduTem);
            this.Controls.Add(this.lb_BlackBoduTem);
            this.Controls.Add(this.tb_Emissivity);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cb_TemperatureMethod);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RadiationTabForm";
            this.Text = "RadiationTabForm";
            this.Load += new System.EventHandler(this.RadiationTabForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_TemperatureMethod;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Emissivity;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_BlackBoduTem;
        private DevComponents.DotNetBar.LabelX lb_BlackBoduTem;
    }
}