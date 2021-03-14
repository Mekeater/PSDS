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
    public partial class PressureInletMomentumTabForm : Office2007Form
    {
        public PressureInletMomentumTabForm()
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
        /// 指定方向的方法
        /// </summary>
        public PI_DirectionMethond directionMethond;
        /// <summary>
        /// 总表压
        /// </summary>
        public string guageTotalPressure;
        /// <summary>
        /// 初始表压
        /// </summary>
        public string guageInitialPressure;
        /// <summary>
        /// 湍流设置
        /// </summary>
        public TurbulenceSet turbulenceSet;
        /// <summary>
        /// [xyz方向矢量] 指定方向方法为矢量时，此值不能为空
        /// </summary>
        public float[] xyzDirection = null;

        public Action action;

        public Action DataUpdate;

        private void PressureInletMomentumTabForm_Load(object sender, EventArgs e)
        {
            this.cb_ReferenceFrame.Items.AddRange(new string[] { "绝对", "相对于相邻单元区域" });
            this.cb_BackflowDirection.Items.AddRange(new string[] { "方向矢量", "垂直于边界"});
            this.cb_TurbulenceMethod.Items.AddRange(new string[] { "湍流动能与湍流耗散率", "湍流强度与湍流长度", "湍流强度与湍流粘度比", "湍流强度与水力直径" });

            this.cb_ReferenceFrame.SelectedIndex = 0;
            this.cb_BackflowDirection.SelectedIndex = 1;
            this.cb_TurbulenceMethod.SelectedIndex = 2;

            this.action = new Action(bindAction);
            this.DataUpdate = new Action(DataUpdateActive);
        }

        private void bindAction()
        {
            if (GlobleVariable.modelForm.viscous == Viscous.Laminar || GlobleVariable.modelForm.viscous == Viscous.Inviscid)
                this.p_Turbulence.Visible = false;
            else
                this.p_Turbulence.Visible = true;
        }

        private void DataUpdateActive()
        {
            if (this.cb_ReferenceFrame.SelectedIndex == 0)
                this.referenceFrame = ReferenceFrame.Absolute;
            else
                this.referenceFrame = ReferenceFrame.Relative;

            if (this.cb_BackflowDirection.SelectedIndex == 0)
                this.directionMethond = PI_DirectionMethond.DirectionVector;
            else
                this.directionMethond = PI_DirectionMethond.NormalToBoundary;

            this.guageTotalPressure = this.tb_GaugeTotalPressure.Text.ToString();
            this.guageInitialPressure = this.tb_InitialGaugePressure.Text.ToString();
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

        private void cb_BackflowDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_BackflowDirection.SelectedIndex == 0)
                this.p_Direction.Visible = true;
            else
                this.p_Direction.Visible = false;
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
