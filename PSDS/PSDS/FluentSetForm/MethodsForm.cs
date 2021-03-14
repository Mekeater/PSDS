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
    public partial class MethodsForm : Office2007Form
    {
        public MethodsForm()
        {
            InitializeComponent();
        }

        public Pressure_VelocityCoupling pressure_VelocityCoupling;

        private void MethodsForm_Load(object sender, EventArgs e)
        {
            this.cb_Pressure_VelocityCoupling.Items.AddRange(new string[] { "SIMPLE", "SIMPLEC", "PISO", "Coupled" });
            this.cb_Pressure_VelocityCoupling.SelectedIndex = 0;
        }

        private void cb_Pressure_VelocityCoupling_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.cb_Pressure_VelocityCoupling.SelectedIndex)
            {
                case 0:
                    pressure_VelocityCoupling = Pressure_VelocityCoupling.SIMPLE;
                    break;
                case 1:
                    pressure_VelocityCoupling = Pressure_VelocityCoupling.SIMPLEC;
                    break;
                case 2:
                    pressure_VelocityCoupling = Pressure_VelocityCoupling.PISO;
                    break;
                case 3:
                    pressure_VelocityCoupling = Pressure_VelocityCoupling.Coupled;
                    break;
            }
        }
    }
}
