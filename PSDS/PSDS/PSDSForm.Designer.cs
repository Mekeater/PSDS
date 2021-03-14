namespace PSDS
{
    partial class PSDSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PSDSForm));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btn_Show = new DevComponents.DotNetBar.ButtonX();
            this.btn_BriefMode = new DevComponents.DotNetBar.ButtonX();
            this.btn_ExpertMode = new DevComponents.DotNetBar.ButtonX();
            this.btn_Run = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("SimSun", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.ForeColor = System.Drawing.Color.Green;
            this.labelX1.Location = new System.Drawing.Point(139, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(295, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "城市大气污染源扩散模拟软件";
            // 
            // btn_Show
            // 
            this.btn_Show.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Show.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Show.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Show.Location = new System.Drawing.Point(426, 65);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(103, 48);
            this.btn_Show.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Show.TabIndex = 1;
            this.btn_Show.Text = "结果展示";
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_BriefMode
            // 
            this.btn_BriefMode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_BriefMode.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_BriefMode.Location = new System.Drawing.Point(8, 23);
            this.btn_BriefMode.Name = "btn_BriefMode";
            this.btn_BriefMode.Size = new System.Drawing.Size(103, 48);
            this.btn_BriefMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_BriefMode.TabIndex = 1;
            this.btn_BriefMode.Text = "简要模式";
            this.btn_BriefMode.Click += new System.EventHandler(this.btn_BriefMode_Click);
            // 
            // btn_ExpertMode
            // 
            this.btn_ExpertMode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ExpertMode.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ExpertMode.Location = new System.Drawing.Point(128, 23);
            this.btn_ExpertMode.Name = "btn_ExpertMode";
            this.btn_ExpertMode.Size = new System.Drawing.Size(103, 48);
            this.btn_ExpertMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ExpertMode.TabIndex = 1;
            this.btn_ExpertMode.Text = "专家模式";
            this.btn_ExpertMode.Click += new System.EventHandler(this.btn_ExpertMode_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Run.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Run.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Run.Location = new System.Drawing.Point(290, 65);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(103, 48);
            this.btn_Run.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Run.TabIndex = 1;
            this.btn_Run.Text = "计算求解";
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_BriefMode);
            this.groupBox1.Controls.Add(this.btn_ExpertMode);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(31, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模拟参数设置";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.ForeColor = System.Drawing.Color.Gray;
            this.labelX2.Location = new System.Drawing.Point(39, 125);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(59, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "测试版";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.ForeColor = System.Drawing.Color.Gray;
            this.labelX3.Location = new System.Drawing.Point(139, 125);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(390, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "版本完善更新中......，如有疑问请联系作者:mekeater.sun@qq.com";
            // 
            // PSDSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 145);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PSDSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSDS";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_Show;
        private DevComponents.DotNetBar.ButtonX btn_BriefMode;
        private DevComponents.DotNetBar.ButtonX btn_ExpertMode;
        private DevComponents.DotNetBar.ButtonX btn_Run;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}

