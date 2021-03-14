using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobeCode.DataStruct;
using PSDS;

namespace GlobeCode
{
    public partial class RunForm : Office2007Form
    {
        private RunFluntAction runFluent;
        public RunForm(RunFluntAction runFluent)
        {
            InitializeComponent();
            this.runFluent = runFluent;
        }

        //Fluent执行的命令
        private string FluentCommand { get; set; }
        //Fluent可执行文件路径
        private string FluentExePath { get; set; }
        

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_FluentPath_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "Fluent 可执行文件路径";
            openFileDialog.Filter = "可执行程序(.exe)|*.exe";
            if(openFileDialog.ShowDialog()== DialogResult.OK)
            {
                tb_FluentPath.Text = openFileDialog.FileName;
                GlobleVariable.fluentEXEPath= openFileDialog.FileName;
            }
        }

        private void RunForm_Load(object sender, EventArgs e)
        {
            if (GlobleVariable.fluentEXEPath == null)
                this.tb_FluentPath.Text = @"D:\Program Files\ANSYS Inc\v191\fluent\ntbin\win64\fluent.exe";
            else
                this.tb_FluentPath.Text = GlobleVariable.fluentEXEPath;
        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            if(GlobleVariable.projectName.Equals(""))
            {
                MessageBox.Show("尚未进行模拟参数设置","提示");
                return;
            }

            FluentCommand = "fluent ";
            if (this.radiobt_2D.Checked)
            {
                if(this.radiobt_single.Checked)
                    FluentCommand += "2d ";
                else
                    FluentCommand += "2ddp ";
            }
            else
            {
                if(this.radiobt_single.Checked)
                    FluentCommand += "3d ";
                else
                    FluentCommand += "3ddp ";
            }

            if (this.radiobt_parallel.Checked)
                FluentCommand += "-t" + this.tb_Processes.Text.ToString() + " ";

            this.FluentCommand += "-hidden -i " + GlobleVariable.DataDirectoryRoot + GlobleVariable.projectName + "\\" + GlobleVariable.JournalDirName + "\\" + GlobleVariable.projectName + ".jou";
            this.FluentExePath = this.tb_FluentPath.Text.ToString();
            this.Close();

            runFluent(this.FluentExePath, this.FluentCommand);
        }

        private void tb_Processes_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是退格和数字，则屏蔽输入
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        private void radiobt_parallel_Click(object sender, EventArgs e)
        {
            this.label_Processes.Visible = true;
            this.tb_Processes.Visible = true;
        }

        private void radiobt_serial_Click(object sender, EventArgs e)
        {
            this.label_Processes.Visible = false;
            this.tb_Processes.Visible = false;
        }
    }
}
