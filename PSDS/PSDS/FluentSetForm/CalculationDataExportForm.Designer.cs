namespace GlobeCode
{
    partial class CalculationDataExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculationDataExportForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_help = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_SurfaceName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btn_Sure = new DevComponents.DotNetBar.ButtonX();
            this.tb_IsoValues = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cb_xyzCoordinate = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lsb_Surface = new DevComponents.DotNetBar.ListBoxAdv();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 399);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lb_help);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(714, 104);
            this.panel3.TabIndex = 1;
            // 
            // lb_help
            // 
            this.lb_help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_help.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_help.ForeColor = System.Drawing.Color.Green;
            this.lb_help.Location = new System.Drawing.Point(0, 0);
            this.lb_help.Name = "lb_help";
            this.lb_help.Size = new System.Drawing.Size(710, 100);
            this.lb_help.TabIndex = 4;
            this.lb_help.Text = "帮助：";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tb_SurfaceName);
            this.panel2.Controls.Add(this.labelX4);
            this.panel2.Controls.Add(this.btn_Sure);
            this.panel2.Controls.Add(this.tb_IsoValues);
            this.panel2.Controls.Add(this.labelX3);
            this.panel2.Controls.Add(this.cb_xyzCoordinate);
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Controls.Add(this.lsb_Surface);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 298);
            this.panel2.TabIndex = 0;
            // 
            // tb_SurfaceName
            // 
            this.tb_SurfaceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_SurfaceName.Border.Class = "TextBoxBorder";
            this.tb_SurfaceName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_SurfaceName.Location = new System.Drawing.Point(249, 151);
            this.tb_SurfaceName.Name = "tb_SurfaceName";
            this.tb_SurfaceName.PreventEnterBeep = true;
            this.tb_SurfaceName.Size = new System.Drawing.Size(451, 21);
            this.tb_SurfaceName.TabIndex = 8;
            this.tb_SurfaceName.Text = "x_0";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(249, 122);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "截面名称：";
            // 
            // btn_Sure
            // 
            this.btn_Sure.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Sure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sure.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Sure.Location = new System.Drawing.Point(625, 194);
            this.btn_Sure.Name = "btn_Sure";
            this.btn_Sure.Size = new System.Drawing.Size(75, 23);
            this.btn_Sure.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Sure.TabIndex = 6;
            this.btn_Sure.Text = "创建";
            this.btn_Sure.Click += new System.EventHandler(this.btn_Sure_Click);
            // 
            // tb_IsoValues
            // 
            this.tb_IsoValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_IsoValues.Border.Class = "TextBoxBorder";
            this.tb_IsoValues.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_IsoValues.Location = new System.Drawing.Point(249, 95);
            this.tb_IsoValues.Name = "tb_IsoValues";
            this.tb_IsoValues.PreventEnterBeep = true;
            this.tb_IsoValues.Size = new System.Drawing.Size(451, 21);
            this.tb_IsoValues.TabIndex = 5;
            this.tb_IsoValues.Text = "0";
            this.tb_IsoValues.TextChanged += new System.EventHandler(this.tb_IsoValues_TextChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(249, 66);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "高度值(m)：";
            // 
            // cb_xyzCoordinate
            // 
            this.cb_xyzCoordinate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_xyzCoordinate.DisplayMember = "Text";
            this.cb_xyzCoordinate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_xyzCoordinate.FormattingEnabled = true;
            this.cb_xyzCoordinate.ItemHeight = 15;
            this.cb_xyzCoordinate.Location = new System.Drawing.Point(249, 39);
            this.cb_xyzCoordinate.Name = "cb_xyzCoordinate";
            this.cb_xyzCoordinate.Size = new System.Drawing.Size(451, 21);
            this.cb_xyzCoordinate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_xyzCoordinate.TabIndex = 3;
            this.cb_xyzCoordinate.SelectedIndexChanged += new System.EventHandler(this.cb_xyzCoordinate_SelectedIndexChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(249, 10);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "创建截面";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(10, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "选择截面";
            // 
            // lsb_Surface
            // 
            this.lsb_Surface.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsb_Surface.AutoScroll = true;
            // 
            // 
            // 
            this.lsb_Surface.BackgroundStyle.Class = "ListBoxAdv";
            this.lsb_Surface.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lsb_Surface.CheckStateMember = null;
            this.lsb_Surface.ContainerControlProcessDialogKey = true;
            this.lsb_Surface.DragDropSupport = true;
            this.lsb_Surface.Font = new System.Drawing.Font("SimSun", 12F);
            this.lsb_Surface.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.lsb_Surface.Location = new System.Drawing.Point(10, 35);
            this.lsb_Surface.Name = "lsb_Surface";
            this.lsb_Surface.SelectionMode = DevComponents.DotNetBar.eSelectionMode.MultiSimple;
            this.lsb_Surface.Size = new System.Drawing.Size(200, 252);
            this.lsb_Surface.TabIndex = 0;
            this.lsb_Surface.Text = "listBoxAdv1";
            this.lsb_Surface.ItemClick += new System.EventHandler(this.lsb_Surface_ItemClick);
            // 
            // CalculationDataExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 399);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculationDataExportForm";
            this.Text = "CalculationDataExportForm";
            this.Load += new System.EventHandler(this.CalculationDataExportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label lb_help;
    private DevComponents.DotNetBar.ListBoxAdv lsb_Surface;
    private DevComponents.DotNetBar.LabelX labelX1;
    private DevComponents.DotNetBar.LabelX labelX2;
    private DevComponents.DotNetBar.Controls.ComboBoxEx cb_xyzCoordinate;
    private DevComponents.DotNetBar.LabelX labelX3;
    private DevComponents.DotNetBar.Controls.TextBoxX tb_IsoValues;
    private DevComponents.DotNetBar.ButtonX btn_Sure;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_SurfaceName;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}