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
    public partial class VelocityInletMomentumTabForm : Office2007Form
    {
        public VelocityInletMomentumTabForm()
        {
            InitializeComponent();
        }

        //记录三个panel的初始高度，进行灵活的收缩。
        private int panel1Height;
        private int panel2Height;
        private int panel3Height;

        private bool initForm = true;//初始化界面

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
        /// 速度方法
        /// </summary>
        public VelocityMethod velocityMethod;
        /// <summary>
        /// 参考框架
        /// </summary>
        public ReferenceFrame referenceFrame;
        /// <summary>
        /// 速度大小
        /// </summary>
        public string velocityMagnitude;
        /// <summary>
        /// 初始表压
        /// </summary>
        public string gaugePressure;
        /// <summary>
        /// 湍流设置
        /// </summary>
        public TurbulenceSet turbulenceSet;
        /// <summary>
        /// [xyz方向或者xyz速度分量](根据速度方法而定，如果速度方法选择：大小和方向则该参数代表速度方向；如果速度方法选择：速度分量的矢量和则该参数代表速度分量(m/s)，否则默认为null)
        /// </summary>
        public float[] xyzDirctionOrComponent = null;

        public Action action;

        /// <summary>
        /// 数据更新委托
        /// </summary>
        public Action DataUpdate;

        private void VelocityInletMomentumTabForm_Load(object sender, EventArgs e)
        {
            this.cb_VelocityMethod.Items.AddRange(new string[] { "大小和方向", "速度分量的矢量和", "方向垂直于边界面" });
            this.cb_ReferenceFrame.Items.AddRange(new string[] { "绝对", "相对于相邻单元区域" });
            this.cb_TurbulenceMethod.Items.AddRange(new string[] { "湍流动能与湍流耗散率", "湍流强度与湍流长度", "湍流强度与湍流粘度比", "湍流强度与水力直径"  });
            
            this.cb_VelocityMethod.SelectedIndex = 2;
            this.cb_ReferenceFrame.SelectedIndex = 0;
            this.cb_TurbulenceMethod.SelectedIndex = 2;

            this.panel1Height = this.p_VelocityMethond1.Height;
            this.panel2Height = this.p_VelocityMethond2.Height;
            this.panel3Height = this.p_VelocityMethond3.Height;

            this.p_VelocityMethond1.Height = 0;
            this.p_VelocityMethond2.Height = 0;

            initForm = false;

            action = new Action(bindAction);
            DataUpdate = new Action(DataUpdateActive);
        }

        private void bindAction()
        {
            if(GlobleVariable.modelForm.viscous==Viscous.Laminar|| GlobleVariable.modelForm.viscous==Viscous.Inviscid)
                this.p_Turbulence.Visible = false;
            else
                this.p_Turbulence.Visible = true;
        }

        private void DataUpdateActive()
        {
            if (this.cb_VelocityMethod.SelectedIndex == 0)
            {
                this.velocityMethod = VelocityMethod.MagnitudeAndDirection;
                this.velocityMagnitude = this.tb_VelocityMethond1_Magnitude.Text.ToString();
            }
            else if (this.cb_VelocityMethod.SelectedIndex == 1)
                this.velocityMethod = VelocityMethod.Components;
            else
            {
                this.velocityMethod = VelocityMethod.Magnitude_NormalToBoundary;
                this.velocityMagnitude = this.tb_VelocityMethond3_Magnitude.Text.ToString();
            }

            if (this.cb_ReferenceFrame.SelectedIndex == 0)
                this.referenceFrame = ReferenceFrame.Absolute;
            else
                this.referenceFrame = ReferenceFrame.Relative;

            this.gaugePressure = this.tb_GaugePressure.Text.ToString();

            this.xyzDirctionOrComponent = new float[] {Convert.ToSingle(this.tb_VelocityMethond1_X.Text.ToString()),
            Convert.ToSingle(this.tb_VelocityMethond1_Y.Text.ToString()),
            Convert.ToSingle(this.tb_VelocityMethond1_Z.Text.ToString())};

            turbulenceSet = new TurbulenceSet();
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
        }

        private void cb_VelocityMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initForm)
                return;

            this.p_VelocityMethond1.Height = panel1Height;
            this.p_VelocityMethond2.Height = panel2Height;
            this.p_VelocityMethond3.Height = panel3Height;
            switch (this.cb_VelocityMethod.SelectedIndex)
            {
                case 0:
                    this.p_VelocityMethond2.Height = 0;
                    this.p_VelocityMethond3.Height = 0;
                    break;
                case 1:
                    this.p_VelocityMethond1.Height = 0;
                    this.p_VelocityMethond3.Height = 0;
                    break;
                case 2:
                    this.p_VelocityMethond1.Height = 0;
                    this.p_VelocityMethond2.Height = 0;
                    break;
                default:
                    break;
            }
        }

        private void cb_TurbulenceMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.cb_TurbulenceMethod.SelectedIndex)
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
