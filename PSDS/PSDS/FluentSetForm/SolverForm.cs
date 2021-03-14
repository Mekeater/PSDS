using DevComponents.DotNetBar;
using GlobeCode.Common;
using GlobeCode.DataStruct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobeCode
{
    public partial class SolverForm : Office2007Form
    {
        public SolverForm()
        {
            InitializeComponent();
        }

        //mesh文件路径
        public string meshFilePath = "";
        public SolverType solverType;
        public VelocityFormulation velocityFormulation;
        public TimeType timeType;
        public bool isGravity;//是否考虑重力
        public GravityDirection gravityDirection= GravityDirection.Z;//默认为Z轴方向
        public string gravitySize="-9.81";//重力大小

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "mesh文件加载";
            openFileDialog.Filter = "mesh文件(*.msh)|*.msh";
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                this.tb_MeshFile.Text = openFileDialog.FileName;
                meshFilePath = openFileDialog.FileName;
            }
        }

        private void MeshFlieForm_Load(object sender, EventArgs e)
        {
            cb_SolverType.Items.AddRange(new string[] { "基于压力法(压力基)", "基于密度法(密度基)" });
            cb_VelocityFormulation.Items.AddRange(new string[] { "绝对速度", "相对速度" });
            cb_TimeType.Items.AddRange(new string[] { "稳态", "瞬态" });
            cb_GravityDirection.Items.AddRange(new string[] { "X", "Y", "Z" });

            cb_SolverType.SelectedIndex = 0;
            cb_VelocityFormulation.SelectedIndex = 0;
            cb_TimeType.SelectedIndex = 0;
            cb_GravityDirection.SelectedIndex = 2;

            solverType = SolverType.PressureBased;
            velocityFormulation = VelocityFormulation.Absolute;
            timeType = TimeType.Steady;

            isGravity = false;
            gravityDirection = GravityDirection.Z;

            this.lb_help.Text = "帮助：\r\n";
        }

        private void cb_SolverType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_SolverType.SelectedIndex == 0)
            {
                solverType = SolverType.PressureBased;
                this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.PressureBase;
            }
            else
            {
                solverType = SolverType.DensityBased;
                this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.DensityBase;
            }
        }

        private void cb_VelocityFormulation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_VelocityFormulation.SelectedIndex == 0)
            {
                velocityFormulation = VelocityFormulation.Absolute;
                this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.VAbsolute;
            }
            else
            {
                velocityFormulation = VelocityFormulation.Relative;
                this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.VRelative;
            }
        }

        private void cb_TimeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_TimeType.SelectedIndex == 0)
            {
                timeType = TimeType.Steady;
                this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Stready;
            }
            else
            {
                timeType = TimeType.Transient;
                this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Transient;
            }
        }

        private void ckB_Gravity_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckB_Gravity.Checked)
            {
                isGravity = true;
                this.cb_GravityDirection.Enabled = true;
                this.tb_GravitySize.Enabled = true;
            }
            else
            {
                isGravity = false;
                this.cb_GravityDirection.Enabled = false;
                this.tb_GravitySize.Enabled = false;
            }
        }

        private void cb_GravityDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cb_GravityDirection.SelectedIndex==0)
                gravityDirection = GravityDirection.X;
            else if(this.cb_GravityDirection.SelectedIndex == 1)
                gravityDirection = GravityDirection.Y;
            else
                gravityDirection = GravityDirection.Z;
        }

        private void tb_GravitySize_TextChanged(object sender, EventArgs e)
        {
            this.gravitySize = this.tb_GravitySize.Text.ToString();
        }
    }
}
