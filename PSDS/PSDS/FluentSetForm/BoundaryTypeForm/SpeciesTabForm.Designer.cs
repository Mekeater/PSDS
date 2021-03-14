namespace GlobeCode
{
    partial class SpeciesTabForm
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
            this.lsb_SpeciesName = new DevComponents.DotNetBar.ListBoxAdv();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tb_Fractions = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(97, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "组分质量分数";
            // 
            // lsb_SpeciesName
            // 
            this.lsb_SpeciesName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsb_SpeciesName.AutoScroll = true;
            // 
            // 
            // 
            this.lsb_SpeciesName.BackgroundStyle.Class = "ListBoxAdv";
            this.lsb_SpeciesName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lsb_SpeciesName.ContainerControlProcessDialogKey = true;
            this.lsb_SpeciesName.DragDropSupport = true;
            this.lsb_SpeciesName.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.lsb_SpeciesName.Location = new System.Drawing.Point(12, 75);
            this.lsb_SpeciesName.Name = "lsb_SpeciesName";
            this.lsb_SpeciesName.Size = new System.Drawing.Size(165, 254);
            this.lsb_SpeciesName.TabIndex = 1;
            this.lsb_SpeciesName.Text = "listBoxAdv1";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 46);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(97, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "组分";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(215, 46);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(97, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "质量分数";
            // 
            // tb_Fractions
            // 
            this.tb_Fractions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_Fractions.Border.Class = "TextBoxBorder";
            this.tb_Fractions.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_Fractions.Location = new System.Drawing.Point(215, 75);
            this.tb_Fractions.Name = "tb_Fractions";
            this.tb_Fractions.PreventEnterBeep = true;
            this.tb_Fractions.Size = new System.Drawing.Size(432, 21);
            this.tb_Fractions.TabIndex = 4;
            this.tb_Fractions.TextChanged += new System.EventHandler(this.tb_Fractions_TextChanged);
            // 
            // SpeciesTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 358);
            this.Controls.Add(this.tb_Fractions);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.lsb_SpeciesName);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpeciesTabForm";
            this.Text = "SpeciesTabForm";
            this.Load += new System.EventHandler(this.SpeciesTabForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ListBoxAdv lsb_SpeciesName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Fractions;
    }
}