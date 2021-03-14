using DevComponents.DotNetBar;
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
    public partial class MassFlowOutletMomentumTabForm : Office2007Form
    {
        public MassFlowOutletMomentumTabForm()
        {
            InitializeComponent();
        }

        /***********开放 动量相关值**********/

        /// <summary>
        /// 指定质量流方法
        /// </summary>
        public MassFlowMethond massFlowMethond;
        /// <summary>
        /// 指定方向方法
        /// </summary>
        public MO_DirectionMethod directionMethod;
        /// <summary>
        /// 质量流率或者质量流通量(根据massFlowMethond参数值确定)
        /// </summary>
        public string massRateOrFlux;
        /// <summary>
        /// [平均质量流通量]massFlowMethond为MassFluxWithAverageMassFlux时 指定
        /// </summary>
        public string averageMassFlux = null;
        /// <summary>
        /// [方向分量] directionMethod为DirectionVector时指定
        /// </summary>
        public float[] xyzDirection = null;

        public Action DataUpdate;

        private void MassFlowOutletMomentumTabForm_Load(object sender, EventArgs e)
        {
            this.cb_MsssFlowMethod.Items.AddRange(new string[] { "质量流率", "质量通量", "质量通量和平均质量通量" });
            this.cb_Direction.Items.AddRange(new string[] { "方向矢量", "垂直于边界" });

            this.cb_Direction.SelectedIndex = 1;
            this.cb_MsssFlowMethod.SelectedIndex = 0;
            this.DataUpdate = new Action(DataUpdateAction);
        }

        private void DataUpdateAction()
        {
            if (this.cb_MsssFlowMethod.SelectedIndex == 0)
            {
                this.massFlowMethond = MassFlowMethond.MassFlowRate;
                this.massRateOrFlux = this.tb_massFlowRate.Text.ToString();
            }
            else if (this.cb_MsssFlowMethod.SelectedIndex == 1)
            {
                this.massFlowMethond = MassFlowMethond.MassFlowFlux;
                this.massRateOrFlux = this.tb_massFlowFlux.Text.ToString();
            }
            else
            {
                this.massFlowMethond = MassFlowMethond.MassFluxWithAverageMassFlux;
                this.averageMassFlux = this.tb_averageFlux.Text.ToString();
            }

            if (this.cb_Direction.SelectedIndex == 0)
                this.directionMethod = MO_DirectionMethod.DirectionVector;
            else
                this.directionMethod = MO_DirectionMethod.OutwardNormal;

            this.xyzDirection = new float[] {Convert.ToSingle(this.tb_FlowDirection_X.Text.ToString()),
            Convert.ToSingle(this.tb_FlowDirection_Y.Text.ToString()),
            Convert.ToSingle(this.tb_FlowDirection_Z.Text.ToString())};
        }

        private void cb_Direction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_Direction.SelectedIndex == 0)
                this.p_Direction.Visible = true;
            else
                this.p_Direction.Visible = false;
        }

        private void cb_MsssFlowMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_MsssFlowMethod.SelectedIndex == 0)
            {
                this.p_MassFlux.Visible = false;
                this.p_AverageMassFlux.Visible = false;
                this.p_MassFlowRate.Visible = true;
            }
            else if (this.cb_MsssFlowMethod.SelectedIndex == 1)
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
