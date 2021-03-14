namespace GlobeCode
{
    partial class MaterialsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_left1 = new DevComponents.DotNetBar.ButtonX();
            this.btn_right1 = new DevComponents.DotNetBar.ButtonX();
            this.lb_Species = new DevComponents.DotNetBar.LabelX();
            this.lsb_Species = new DevComponents.DotNetBar.ListBoxAdv();
            this.btn_left = new DevComponents.DotNetBar.ButtonX();
            this.btn_right = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lsb_MatrialsFluid = new DevComponents.DotNetBar.ListBoxAdv();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lsb_MatrialsDB = new DevComponents.DotNetBar.ListBoxAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_help = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_left1);
            this.panel1.Controls.Add(this.btn_right1);
            this.panel1.Controls.Add(this.lb_Species);
            this.panel1.Controls.Add(this.lsb_Species);
            this.panel1.Controls.Add(this.btn_left);
            this.panel1.Controls.Add(this.btn_right);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.lsb_MatrialsFluid);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.lsb_MatrialsDB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 438);
            this.panel1.TabIndex = 0;
            // 
            // btn_left1
            // 
            this.btn_left1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_left1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_left1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_left1.Location = new System.Drawing.Point(439, 232);
            this.btn_left1.Name = "btn_left1";
            this.btn_left1.Size = new System.Drawing.Size(75, 23);
            this.btn_left1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_left1.TabIndex = 8;
            this.btn_left1.Text = "<--";
            this.btn_left1.Click += new System.EventHandler(this.btn_left1_Click);
            // 
            // btn_right1
            // 
            this.btn_right1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_right1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_right1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_right1.Location = new System.Drawing.Point(439, 145);
            this.btn_right1.Name = "btn_right1";
            this.btn_right1.Size = new System.Drawing.Size(75, 23);
            this.btn_right1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_right1.TabIndex = 7;
            this.btn_right1.Text = "-->";
            this.btn_right1.Click += new System.EventHandler(this.btn_right1_Click);
            // 
            // lb_Species
            // 
            // 
            // 
            // 
            this.lb_Species.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_Species.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Species.Location = new System.Drawing.Point(520, 45);
            this.lb_Species.Name = "lb_Species";
            this.lb_Species.Size = new System.Drawing.Size(75, 23);
            this.lb_Species.TabIndex = 6;
            this.lb_Species.Text = "组分材料";
            // 
            // lsb_Species
            // 
            this.lsb_Species.AutoScroll = true;
            // 
            // 
            // 
            this.lsb_Species.BackgroundStyle.Class = "ListBoxAdv";
            this.lsb_Species.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lsb_Species.CheckStateMember = null;
            this.lsb_Species.ContainerControlProcessDialogKey = true;
            this.lsb_Species.DragDropSupport = true;
            this.lsb_Species.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.lsb_Species.Location = new System.Drawing.Point(520, 74);
            this.lsb_Species.Name = "lsb_Species";
            this.lsb_Species.Size = new System.Drawing.Size(168, 252);
            this.lsb_Species.TabIndex = 3;
            this.lsb_Species.Text = "listBoxAdv2";
            // 
            // btn_left
            // 
            this.btn_left.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_left.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_left.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_left.Location = new System.Drawing.Point(184, 232);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(75, 23);
            this.btn_left.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_left.TabIndex = 5;
            this.btn_left.Text = "<--";
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_right.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_right.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_right.Location = new System.Drawing.Point(184, 145);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(75, 23);
            this.btn_right.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_right.TabIndex = 4;
            this.btn_right.Text = "-->";
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(265, 45);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "流体材料";
            // 
            // lsb_MatrialsFluid
            // 
            this.lsb_MatrialsFluid.AutoScroll = true;
            // 
            // 
            // 
            this.lsb_MatrialsFluid.BackgroundStyle.Class = "ListBoxAdv";
            this.lsb_MatrialsFluid.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lsb_MatrialsFluid.ContainerControlProcessDialogKey = true;
            this.lsb_MatrialsFluid.DragDropSupport = true;
            this.lsb_MatrialsFluid.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.lsb_MatrialsFluid.Location = new System.Drawing.Point(265, 74);
            this.lsb_MatrialsFluid.Name = "lsb_MatrialsFluid";
            this.lsb_MatrialsFluid.Size = new System.Drawing.Size(168, 252);
            this.lsb_MatrialsFluid.TabIndex = 2;
            this.lsb_MatrialsFluid.Text = "listBoxAdv2";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(10, 45);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "材料库";
            // 
            // lsb_MatrialsDB
            // 
            this.lsb_MatrialsDB.AutoScroll = true;
            // 
            // 
            // 
            this.lsb_MatrialsDB.BackgroundStyle.Class = "ListBoxAdv";
            this.lsb_MatrialsDB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lsb_MatrialsDB.CheckStateMember = null;
            this.lsb_MatrialsDB.ContainerControlProcessDialogKey = true;
            this.lsb_MatrialsDB.DragDropSupport = true;
            this.lsb_MatrialsDB.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.lsb_MatrialsDB.Location = new System.Drawing.Point(10, 74);
            this.lsb_MatrialsDB.Name = "lsb_MatrialsDB";
            this.lsb_MatrialsDB.Size = new System.Drawing.Size(168, 252);
            this.lsb_MatrialsDB.TabIndex = 0;
            this.lsb_MatrialsDB.Text = "listBoxAdv1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lb_help);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 104);
            this.panel2.TabIndex = 1;
            // 
            // lb_help
            // 
            this.lb_help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_help.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_help.ForeColor = System.Drawing.Color.Green;
            this.lb_help.Location = new System.Drawing.Point(0, 0);
            this.lb_help.Name = "lb_help";
            this.lb_help.Size = new System.Drawing.Size(697, 100);
            this.lb_help.TabIndex = 3;
            this.lb_help.Text = "帮助：";
            // 
            // MaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaterialsForm";
            this.Text = "materialsForm";
            this.Load += new System.EventHandler(this.MaterialsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_help;
        private DevComponents.DotNetBar.ListBoxAdv lsb_MatrialsDB;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ListBoxAdv lsb_MatrialsFluid;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_left;
        private DevComponents.DotNetBar.ButtonX btn_right;
        private DevComponents.DotNetBar.LabelX lb_Species;
        private DevComponents.DotNetBar.ListBoxAdv lsb_Species;
        private DevComponents.DotNetBar.ButtonX btn_left1;
        private DevComponents.DotNetBar.ButtonX btn_right1;
    }
}