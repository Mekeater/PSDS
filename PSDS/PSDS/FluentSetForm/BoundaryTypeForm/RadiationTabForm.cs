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

namespace GlobeCode
{
    public partial class RadiationTabForm : Office2007Form
    {
        public RadiationTabForm()
        {
            InitializeComponent();
        }

        private void RadiationTabForm_Load(object sender, EventArgs e)
        {
            this.cb_TemperatureMethod.Items.AddRange(new string[] { "边界温度","指定外部温度"});
            this.cb_TemperatureMethod.SelectedIndex = 0;
        }

        private void cb_TemperatureMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cb_TemperatureMethod.SelectedIndex==1)
            {
                this.lb_BlackBoduTem.Visible = true;
                this.tb_BlackBoduTem.Visible = true;
            }
            else
            {
                this.lb_BlackBoduTem.Visible = false;
                this.tb_BlackBoduTem.Visible = false;
            }
        }
    }
}
