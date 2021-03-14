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
    public partial class InitiallizationForm : Office2007Form
    {
        public InitiallizationForm()
        {
            InitializeComponent();
        }

        public IntializeMethods intializeMethods;

        private void InitiallizationForm_Load(object sender, EventArgs e)
        {
            this.cb_InitialMethods.Items.AddRange(new string[] {"混合初始化","标准初始化" });
            this.cb_InitialMethods.SelectedIndex = 0;
        }

        private void cb_InitialMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_InitialMethods.SelectedIndex == 0)
                this.intializeMethods = IntializeMethods.Hybrid;
            else
                this.intializeMethods = IntializeMethods.Standard;
        }
    }
}
