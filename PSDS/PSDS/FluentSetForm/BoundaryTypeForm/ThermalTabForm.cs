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
    public partial class ThermalTabForm : Office2007Form
    {
        public ThermalTabForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 热量温度设置
        /// </summary>
        public string temperature;

        public Action DataUpdate;//数据更新委托

        private void ThermalTabForm_Load(object sender, EventArgs e)
        {
            this.temperature = this.tb_Temperature.Text.ToString();
            this.DataUpdate = new Action(DataUpdateActive);
        }

        private void DataUpdateActive()
        {
            this.temperature = this.tb_Temperature.Text.ToString();
        }
    }
}
