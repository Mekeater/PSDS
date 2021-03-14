using DevComponents.DotNetBar;
using GlobeCode;
using GlobeCode.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSDS
{
    //整个命名空间的委托对象（参考Action编写的）
    public delegate void RunFluntAction(string processPath, string command);//mainForm绑定委托，RunForm触发委托

    public partial class PSDSForm : Office2007Form
    {
        public PSDSForm()
        {
            InitializeComponent();
        }

        private void btn_BriefMode_Click(object sender, EventArgs e)
        {
            ProfileSimulationParametersForm form = new ProfileSimulationParametersForm();
            form.ShowDialog();
        }

        private void btn_ExpertMode_Click(object sender, EventArgs e)
        {
            SimulationParametersForm form = new SimulationParametersForm();
            form.ShowDialog();
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            RunFluntAction runFluent = delegate (string processPath, string command)
            {
                Task t = Task.Run(() =>
                {
                    InvokeProcess.startProcess(processPath, command);
                });

            };
            RunForm runForm = new RunForm(runFluent);
            runForm.ShowDialog();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该功能待更新，敬请等待~", "温馨提示");
        }
    }
}
