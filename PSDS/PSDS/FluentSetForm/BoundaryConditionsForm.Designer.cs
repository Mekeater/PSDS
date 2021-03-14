namespace GlobeCode
{
    partial class BoundaryConditionsForm
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
            this.p_BoundaryTab = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Initial = new DevComponents.DotNetBar.ButtonX();
            this.btn_SaveSet = new DevComponents.DotNetBar.ButtonX();
            this.superTabControlBoundry = new DevComponents.DotNetBar.SuperTabControl();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cb_BoundaryType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lsb_Zones = new DevComponents.DotNetBar.ListBoxAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_help = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.p_BoundaryTab.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControlBoundry)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.p_BoundaryTab);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.cb_BoundaryType);
            this.panel1.Controls.Add(this.lsb_Zones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 472);
            this.panel1.TabIndex = 0;
            // 
            // p_BoundaryTab
            // 
            this.p_BoundaryTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_BoundaryTab.Controls.Add(this.panel3);
            this.p_BoundaryTab.Controls.Add(this.superTabControlBoundry);
            this.p_BoundaryTab.Location = new System.Drawing.Point(235, 27);
            this.p_BoundaryTab.Name = "p_BoundaryTab";
            this.p_BoundaryTab.Size = new System.Drawing.Size(611, 332);
            this.p_BoundaryTab.TabIndex = 3;
            this.p_BoundaryTab.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Initial);
            this.panel3.Controls.Add(this.btn_SaveSet);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(611, 40);
            this.panel3.TabIndex = 8;
            // 
            // btn_Initial
            // 
            this.btn_Initial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Initial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Initial.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Initial.Location = new System.Drawing.Point(508, 5);
            this.btn_Initial.Name = "btn_Initial";
            this.btn_Initial.Size = new System.Drawing.Size(79, 23);
            this.btn_Initial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Initial.TabIndex = 1;
            this.btn_Initial.Text = "默认设置";
            this.btn_Initial.Click += new System.EventHandler(this.btn_Initial_Click);
            // 
            // btn_SaveSet
            // 
            this.btn_SaveSet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SaveSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveSet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SaveSet.Location = new System.Drawing.Point(415, 5);
            this.btn_SaveSet.Name = "btn_SaveSet";
            this.btn_SaveSet.Size = new System.Drawing.Size(79, 23);
            this.btn_SaveSet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SaveSet.TabIndex = 0;
            this.btn_SaveSet.Text = "保存设置";
            this.btn_SaveSet.Click += new System.EventHandler(this.btn_SaveSet_Click);
            // 
            // superTabControlBoundry
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControlBoundry.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControlBoundry.ControlBox.MenuBox.Name = "";
            this.superTabControlBoundry.ControlBox.Name = "";
            this.superTabControlBoundry.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControlBoundry.ControlBox.MenuBox,
            this.superTabControlBoundry.ControlBox.CloseBox});
            this.superTabControlBoundry.Dock = System.Windows.Forms.DockStyle.Top;
            this.superTabControlBoundry.Location = new System.Drawing.Point(0, 0);
            this.superTabControlBoundry.Name = "superTabControlBoundry";
            this.superTabControlBoundry.ReorderTabsEnabled = true;
            this.superTabControlBoundry.SelectedTabFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold);
            this.superTabControlBoundry.SelectedTabIndex = 0;
            this.superTabControlBoundry.Size = new System.Drawing.Size(611, 268);
            this.superTabControlBoundry.TabFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superTabControlBoundry.TabIndex = 7;
            this.superTabControlBoundry.Text = "superTabControl1";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(11, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(66, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "边界类型：";
            // 
            // cb_BoundaryType
            // 
            this.cb_BoundaryType.DisplayMember = "Text";
            this.cb_BoundaryType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_BoundaryType.FormattingEnabled = true;
            this.cb_BoundaryType.ItemHeight = 15;
            this.cb_BoundaryType.Location = new System.Drawing.Point(79, 24);
            this.cb_BoundaryType.Name = "cb_BoundaryType";
            this.cb_BoundaryType.Size = new System.Drawing.Size(150, 21);
            this.cb_BoundaryType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_BoundaryType.TabIndex = 1;
            this.cb_BoundaryType.SelectedIndexChanged += new System.EventHandler(this.cb_BoundaryType_SelectedIndexChanged);
            // 
            // lsb_Zones
            // 
            this.lsb_Zones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsb_Zones.AutoScroll = true;
            // 
            // 
            // 
            this.lsb_Zones.BackgroundStyle.Class = "ListBoxAdv";
            this.lsb_Zones.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lsb_Zones.CheckStateMember = null;
            this.lsb_Zones.ContainerControlProcessDialogKey = true;
            this.lsb_Zones.DragDropSupport = true;
            this.lsb_Zones.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lsb_Zones.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.lsb_Zones.Location = new System.Drawing.Point(10, 51);
            this.lsb_Zones.Name = "lsb_Zones";
            this.lsb_Zones.Size = new System.Drawing.Size(219, 309);
            this.lsb_Zones.TabIndex = 0;
            this.lsb_Zones.Text = "listBoxAdv1";
            this.lsb_Zones.ItemClick += new System.EventHandler(this.lsb_Zones_ItemClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lb_help);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 104);
            this.panel2.TabIndex = 1;
            // 
            // lb_help
            // 
            this.lb_help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_help.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_help.ForeColor = System.Drawing.Color.Green;
            this.lb_help.Location = new System.Drawing.Point(0, 0);
            this.lb_help.Name = "lb_help";
            this.lb_help.Size = new System.Drawing.Size(849, 100);
            this.lb_help.TabIndex = 4;
            this.lb_help.Text = "帮助：";
            // 
            // BoundaryConditionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BoundaryConditionsForm";
            this.Text = "BoundaryConditionsForm";
            this.Load += new System.EventHandler(this.BoundaryConditionsForm_Load);
            this.panel1.ResumeLayout(false);
            this.p_BoundaryTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControlBoundry)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_help;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_BoundaryType;
        private DevComponents.DotNetBar.ListBoxAdv lsb_Zones;
        private System.Windows.Forms.Panel p_BoundaryTab;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.ButtonX btn_Initial;
        private DevComponents.DotNetBar.ButtonX btn_SaveSet;
        private DevComponents.DotNetBar.SuperTabControl superTabControlBoundry;
    }
}