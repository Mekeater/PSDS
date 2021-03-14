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
    public partial class PressureOutletMomentumTabForm : Office2007Form
    {
        public PressureOutletMomentumTabForm()
        {
            InitializeComponent();
        }

        //记录湍流4中方法分别对应的默认值
        private string TurbulenceMethod1P1 = "1";
        private string TurbulenceMethod1P2 = "1";
        private string TurbulenceMethod2P1 = "5";
        private string TurbulenceMethod2P2 = "1";
        private string TurbulenceMethod3P1 = "5";
        private string TurbulenceMethod3P2 = "10";
        private string TurbulenceMethod4P1 = "5";
        private string TurbulenceMethod4P2 = "1";

        /***********开放 动量相关值**********/
        /// <summary>
        /// 参考框架
        /// </summary>
        public ReferenceFrame referenceFrame;
        /// <summary>
        /// 回流方向方法
        /// </summary>
        public BackflowDirectionMethond bfDirectionM;
        /// <summary>
        /// 回流压力类型
        /// </summary>
        public BackflowPressure bfPressure;
        /// <summary>
        /// 表压
        /// </summary>
        public string gaugePressure;
        /// <summary>
        /// 复选情况
        /// </summary>
        public PO_MomentumCheck isCheck;
        /// <summary>
        /// 湍流设置
        /// </summary>
        public TurbulenceSet turbulenceSet;
        /// <summary>
        /// [xyz方向矢量],bfdm为DirectionVector时，需要在指定
        /// </summary>
        public float[] xyzDirection = null;
        /// <summary>
        /// [目标质量流率的参数],目标质量流率复选时，需要在指定
        /// </summary>
        public float[] massFlowParameter = null;

        public Action action;
        public Action DataUpdate;//动量值数据更新委托

        private void PressureOutletMomentumTabForm_Load(object sender, EventArgs e)
        {
            this.cb_ReferenceFrame.Items.AddRange(new string[] { "绝对", "相对于相邻单元区域" });
            this.cb_BackflowPressure.Items.AddRange(new string[] {"总压","静压" });
            this.cb_BackflowDirection.Items.AddRange(new string[] { "方向矢量", "垂直于边界","相邻单元格方向"});
            this.cb_TurbulenceMethod.Items.AddRange(new string[] { "湍流动能与湍流耗散率", "湍流强度与湍流长度", "湍流强度与湍流粘度比", "湍流强度与水力直径" });

            this.cb_ReferenceFrame.SelectedIndex = 0;
            this.cb_BackflowDirection.SelectedIndex = 1;
            this.cb_BackflowPressure.SelectedIndex = 0;
            this.cb_TurbulenceMethod.SelectedIndex = 2;

            this.action = new Action(bindAction);
            this.DataUpdate = new Action(DataUpdateAction);
        }

        private void bindAction()
        {
            if (GlobleVariable.modelForm.viscous == Viscous.Laminar || GlobleVariable.modelForm.viscous == Viscous.Inviscid)
                this.p_Turbulence.Visible = false;
            else
                this.p_Turbulence.Visible = true;
        }

        /// <summary>
        /// 更新控件值
        /// </summary>
        private void DataUpdateAction()
        {
            if (this.cb_ReferenceFrame.SelectedIndex == 0)
                this.referenceFrame = ReferenceFrame.Absolute;
            else
                this.referenceFrame = ReferenceFrame.Relative;

            if (cb_BackflowDirection.SelectedIndex == 0)
            {
                this.bfDirectionM = BackflowDirectionMethond.DirectionVector;
                this.xyzDirection = new float[] { Convert.ToSingle(this.tb_FlowDirection_X.Text.ToString()),
                 Convert.ToSingle(this.tb_FlowDirection_Y.Text.ToString()),
                  Convert.ToSingle(this.tb_FlowDirection_Z.Text.ToString())};
            }
            else if (cb_BackflowDirection.SelectedIndex == 1)
                this.bfDirectionM = BackflowDirectionMethond.NormalToBoundary;
            else
                this.bfDirectionM = BackflowDirectionMethond.FromNeighboringCell;

            if (this.cb_BackflowPressure.SelectedIndex == 0)
                this.bfPressure = BackflowPressure.TotalPressure;
            else
                this.bfPressure = BackflowPressure.StaticPressure;

            this.gaugePressure = this.tb_GaugePressure.Text.ToString();

            isCheck = new PO_MomentumCheck();
            if (ckb_RadialEP.Checked)
                isCheck.RadialEquilibriumPD = true;
            if (ckb_AverageP.Checked)
                isCheck.AverageP = true;
            if (ckb_TargetMassFlow.Checked)
            {
                isCheck.TargetMassFlow = true;
                this.massFlowParameter = new float[] {Convert.ToSingle(this.tb_TargetMassFlow.Text.ToString()),
                Convert.ToSingle(this.tb_UpPressure.Text.ToString()),Convert.ToSingle(this.tb_LowPressure.Text.ToString())};
            }

            turbulenceSet = new TurbulenceSet();
            turbulenceSet.turbulenceOrder = TurbulenceOrder.SecondOrder;
            if (this.cb_TurbulenceMethod.SelectedIndex == 0)
                turbulenceSet.secondOrder_TurbulenceMethod = SecondOrder_TurbulenceMethod.KAndEpsilon;
            else if(this.cb_TurbulenceMethod.SelectedIndex == 1)
                turbulenceSet.secondOrder_TurbulenceMethod = SecondOrder_TurbulenceMethod.IntensityAndLengthScale;
            else if (this.cb_TurbulenceMethod.SelectedIndex == 2)
                turbulenceSet.secondOrder_TurbulenceMethod = SecondOrder_TurbulenceMethod.IntensityAndViscosityRatio;
            else
                turbulenceSet.secondOrder_TurbulenceMethod = SecondOrder_TurbulenceMethod.IntensityAndHydraulicDiameter;
            turbulenceSet.TurbulenceP1 = this.tb_TurbulenceP1.Text.ToString();
            turbulenceSet.TurbulenceP2 = this.tb_TurbulenceP2.Text.ToString();
            
            
        }

        private void cb_BackflowDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_BackflowDirection.SelectedIndex == 0)
                this.p_BackflowDirection.Visible = true;
            else
                this.p_BackflowDirection.Visible = false;
        }

        private void ckb_TargetMassFlow_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckb_TargetMassFlow.Checked == true)
                this.p_MassFlowRate.Visible = true;
            else
                this.p_MassFlowRate.Visible = false;
        }

        private void cb_TurbulenceMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cb_TurbulenceMethod.SelectedIndex)
            {
                case 0:
                    this.lb_TurbulenceP1.Text = "湍流动能(m2/s2)：";
                    this.lb_TurbulenceP2.Text = "湍流耗散率(m2/s2)：";
                    this.tb_TurbulenceP1.Text = TurbulenceMethod1P1;
                    this.tb_TurbulenceP2.Text = TurbulenceMethod1P2;
                    break;
                case 1:
                    this.lb_TurbulenceP1.Text = "湍流强度(%)：";
                    this.lb_TurbulenceP2.Text = "湍流长度(m)：";
                    this.tb_TurbulenceP1.Text = TurbulenceMethod2P1;
                    this.tb_TurbulenceP2.Text = TurbulenceMethod2P2;
                    break;
                case 2:
                    this.lb_TurbulenceP1.Text = "湍流强度(%)：";
                    this.lb_TurbulenceP2.Text = "湍流粘度比：";
                    this.tb_TurbulenceP1.Text = TurbulenceMethod3P1;
                    this.tb_TurbulenceP2.Text = TurbulenceMethod3P2;
                    break;
                case 3:
                    this.lb_TurbulenceP1.Text = "湍流强度(%)：";
                    this.lb_TurbulenceP2.Text = "水力直径(m)：";
                    this.tb_TurbulenceP1.Text = TurbulenceMethod4P1;
                    this.tb_TurbulenceP2.Text = TurbulenceMethod4P2;
                    break;
                default:
                    break;
            }
        }

        private void tb_TurbulenceP1_TextChanged(object sender, EventArgs e)
        {
            switch (this.cb_TurbulenceMethod.SelectedIndex)
            {
                case 0:
                    TurbulenceMethod1P1 = this.tb_TurbulenceP1.Text.ToString();
                    break;
                case 1:
                    TurbulenceMethod2P1 = this.tb_TurbulenceP1.Text.ToString();
                    break;
                case 2:
                    TurbulenceMethod3P1 = this.tb_TurbulenceP1.Text.ToString();
                    break;
                case 3:
                    TurbulenceMethod4P1 = this.tb_TurbulenceP1.Text.ToString();
                    break;
                default:
                    break;
            }
        }

        private void tb_TurbulenceP2_TextChanged(object sender, EventArgs e)
        {
            switch (this.cb_TurbulenceMethod.SelectedIndex)
            {
                case 0:
                    TurbulenceMethod1P2 = this.tb_TurbulenceP2.Text.ToString();
                    break;
                case 1:
                    TurbulenceMethod2P2 = this.tb_TurbulenceP2.Text.ToString();
                    break;
                case 2:
                    TurbulenceMethod3P2 = this.tb_TurbulenceP2.Text.ToString();
                    break;
                case 3:
                    TurbulenceMethod4P2 = this.tb_TurbulenceP2.Text.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
