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

namespace GlobeCode
{
    public partial class RunCalculationForm : Office2007Form
    {
        public RunCalculationForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 迭代次数
        /// </summary>
        public string numberOFIterations;

        public TimeStepingMethod m_timeStepingMethod;
        public string m_TimeStepingSize;
        public string m_TimeStepingNumber;
        public string m_MaxIterations_TimeStep;
        public string m_ErrorTolerance;
        public string m_EndTime;
        public string m_MinTimeStepChangeFactor;
        public string m_MaxTimeStepChangeFactor;
        public string m_MinTimeStep;
        public string m_MaxTimeStep;
        public string m_TimeStepFixedNum;

        public Action action;
        public Action DataUpdate;//界面数据更新委托
        private void RunCalculationForm_Load(object sender, EventArgs e)
        {
            this.cb_TimeStepingMethod.Items.AddRange(new string[] { "时间步固定不变", "时间步自适应改变" });
            this.cb_TimeStepingMethod.SelectedIndex = 0;
            ActionBind();
            action = new Action(ActionBind);
            DataUpdate = new Action(DataUpdateActive);
        }

        private void ActionBind()
        {
            if (GlobleVariable.solverForm.timeType == TimeType.Steady)
            {
                this.p_Steady.Visible = true;
                this.p_Transient.Visible = false;
            }
            else
            {
                this.p_Steady.Visible = false;
                this.p_Transient.Visible = true;
            }
        }

        public void DataUpdateActive()
        {
            this.m_EndTime = this.tb_EndTime.Text.ToString();
            this.m_ErrorTolerance = this.tb_ErrorTolerance.Text.ToString();
            this.m_MaxIterations_TimeStep = this.tb_MaxIterations_TimeStep.Text.ToString();
            this.m_MaxTimeStep = this.tb_MaxTimeStep.Text.ToString();
            this.m_MaxTimeStepChangeFactor = this.tb_MaxTimeStepChangeFactor.Text.ToString();
            this.m_MinTimeStep = this.tb_MinTimeStep.Text.ToString();
            this.m_MinTimeStepChangeFactor = this.tb_MinTimeStepChangeFactor.Text.ToString();
            this.m_TimeStepFixedNum = this.tb_TimeStepFixedNum.Text.ToString();
            this.m_TimeStepingNumber = this.tb_TimeStepingNumber.Text.ToString();
            this.m_TimeStepingSize = this.tb_TimeStepingSize.Text.ToString();
        }

        private void tb_NumberOfIterations_TextChanged(object sender, EventArgs e)
        {
            this.numberOFIterations = this.tb_NumberOfIterations.Text.ToString();
        }

        private void cb_TimeStepingMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cb_TimeStepingMethod.SelectedIndex==0)
            {
                p_AdaptiveTimeStepSet.Visible = false;
                this.m_timeStepingMethod = TimeStepingMethod.Fixed;
            }
            else
            {
                p_AdaptiveTimeStepSet.Visible = true;
                this.m_timeStepingMethod = TimeStepingMethod.Adaptive;
            }
        }
    }
}
