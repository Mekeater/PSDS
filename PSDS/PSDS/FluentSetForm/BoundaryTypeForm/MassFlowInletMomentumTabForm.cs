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
    public partial class MassFlowInletMomentumTabForm : Office2007Form
    {
        public MassFlowInletMomentumTabForm()
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
        /// 质量流方法
        /// </summary>
        public MassFlowMethond massFlowMethond;
        /// <summary>
        /// 指定方向方法
        /// </summary>
        public PI_DirectionMethond dirctionMethond;
        /// <summary>
        /// 质量流率或质量流量
        /// </summary>
        public string massFlowRateOrFlux;
        /// <summary>
        /// 初始表压
        /// </summary>
        public string initialGaugePress;
        /// <summary>
        /// 湍流设置
        /// </summary>
        public TurbulenceSet turbulenceSet;
        /// <summary>
        /// [平均质量流量]根据质量流方法确定该值是否为null
        /// </summary>
        public string averageFlux = null;
        /// <summary>
        /// [xyz方向矢量]根据指定方向方法确定确定该值是否为null
        /// </summary>
        public float[] xyzDirection = null;

        public Action action;
        public Action DataUpdate;

        private void MassFlowInletMomentumTabForm_Load(object sender, EventArgs e)
        {
            this.cb_ReferenceFrame.Items.AddRange(new string[] { "绝对", "相对于相邻单元区域" });
            this.cb_MsssFlowMethod.Items.AddRange(new string[] {"质量流率","质量通量", "质量通量和平均质量通量" });
            this.cb_Direction.Items.AddRange(new string[] { "方向矢量", "垂直于边界" });
            this.cb_TurbulenceMethod.Items.AddRange(new string[] { "湍流动能与湍流耗散率", "湍流强度与湍流长度", "湍流强度与湍流粘度比", "湍流强度与水力直径" });

            this.cb_ReferenceFrame.SelectedIndex = 0;
            this.cb_Direction.SelectedIndex = 1;
            this.cb_TurbulenceMethod.SelectedIndex = 2;
            this.cb_MsssFlowMethod.SelectedIndex = 0;

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

        private void DataUpdateAction()
        {
            if (this.cb_ReferenceFrame.SelectedIndex == 0)
                this.referenceFrame = ReferenceFrame.Absolute;
            else
                this.referenceFrame = ReferenceFrame.Relative;

            if (this.cb_MsssFlowMethod.SelectedIndex == 0)
            {
                this.massFlowMethond = MassFlowMethond.MassFlowRate;
                this.massFlowRateOrFlux = this.tb_massFlowRate.Text.ToString();
            }
            else if (this.cb_MsssFlowMethod.SelectedIndex == 1)
            {
                this.massFlowMethond = MassFlowMethond.MassFlowFlux;
                this.massFlowRateOrFlux = this.tb_massFlowFlux.Text.ToString();
            }
            else
                this.massFlowMethond = MassFlowMethond.MassFluxWithAverageMassFlux;

            if (this.cb_Direction.SelectedIndex == 0)
                this.dirctionMethond = PI_DirectionMethond.DirectionVector;
            else
            {
                this.dirctionMethond = PI_DirectionMethond.NormalToBoundary;
                this.averageFlux = this.tb_averageFlux.Text.ToString();
            }

            this.initialGaugePress = this.tb_InitialGaugePressure.Text.ToString();

            this.turbulenceSet = new TurbulenceSet();
            turbulenceSet.turbulenceOrder = TurbulenceOrder.SecondOrder;
            if (this.cb_TurbulenceMethod.SelectedIndex == 0)
                turbulenceSet.secondOrder_TurbulenceMethod = SecondOrder_TurbulenceMethod.KAndEpsilon;
            else if (this.cb_TurbulenceMethod.SelectedIndex == 1)
                turbulenceSet.secondOrder_TurbulenceMethod = SecondOrder_TurbulenceMethod.IntensityAndLengthScale;
            else if (this.cb_TurbulenceMethod.SelectedIndex == 2)
                turbulenceSet.secondOrder_TurbulenceMethod = SecondOrder_TurbulenceMethod.IntensityAndViscosityRatio;
            else
                turbulenceSet.secondOrder_TurbulenceMethod = SecondOrder_TurbulenceMethod.IntensityAndHydraulicDiameter;
            turbulenceSet.TurbulenceP1 = this.tb_TurbulenceP1.Text.ToString();
            turbulenceSet.TurbulenceP2 = this.tb_TurbulenceP2.Text.ToString();

            this.xyzDirection = new float[] {Convert.ToSingle(this.tb_FlowDirection_X.Text.ToString()),
            Convert.ToSingle(this.tb_FlowDirection_Y.Text.ToString()),
            Convert.ToSingle(this.tb_FlowDirection_Z.Text.ToString())};

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

        private void cb_Direction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cb_Direction.SelectedIndex==0)
                this.p_Direction.Visible = true;
            else
                this.p_Direction.Visible = false;
        }

        private void cb_MsssFlowMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cb_MsssFlowMethod.SelectedIndex==0)
            {
                this.p_MassFlux.Visible = false;
                this.p_AverageMassFlux.Visible = false;
                this.p_MassFlowRate.Visible = true;
            }
            else if(this.cb_MsssFlowMethod.SelectedIndex==1)
            {
                this.p_MassFlux.Visible = true;
                this.p_AverageMassFlux.Visible = false;
                this.p_MassFlowRate.Visible = false;
            }
            else
            {
                this.p_MassFlux.Visible = true;
                this.p_AverageMassFlux.Visible = true;
                this.p_MassFlowRate.Visible = false;
            }
        }
    }
}
