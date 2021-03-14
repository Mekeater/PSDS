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
    public partial class CalculationDataExportForm : Office2007Form
    {
        public CalculationDataExportForm()
        {
            InitializeComponent();
        }

        public Action action;

        public StringBuilder sb_CreateSurface;//创建截面命令
        public List<string> surfacesName;//导出数据截面的名称

        private void CalculationDataExportForm_Load(object sender, EventArgs e)
        {
            this.cb_xyzCoordinate.Items.AddRange(new string[] {"X轴截面", "Y轴截面", "Z轴截面" });
            this.cb_xyzCoordinate.SelectedIndex = 0;

            action = new Action(ActionBind);
            if(this.lsb_Surface.Items.Count==0)
                action();

            surfacesName = new List<string>();
        }

        private void ActionBind()
        {
            this.lsb_Surface.Items.Clear();
            if (GlobleVariable.boundaryConditionsForm.boundarys != null)
            {
                if (GlobleVariable.boundaryConditionsForm.boundarys.Count == 0)
                    MessageBox.Show("未进行边界条件设置", "提示");
                else
                    foreach (string[] boundary in GlobleVariable.boundaryConditionsForm.boundarys)
                    {
                        this.lsb_Surface.Items.Add(boundary[1]);
                    }
            }
                
        }

        private void cb_xyzCoordinate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_xyzCoordinate.SelectedIndex == 0)
                this.tb_SurfaceName.Text = "x_" + this.tb_IsoValues.Text.ToString();
            else if (this.cb_xyzCoordinate.SelectedIndex == 1)
                this.tb_SurfaceName.Text = "y_" + this.tb_IsoValues.Text.ToString();
            else
                this.tb_SurfaceName.Text = "z_" + this.tb_IsoValues.Text.ToString();
        }

        private void tb_IsoValues_TextChanged(object sender, EventArgs e)
        {
            if (this.cb_xyzCoordinate.SelectedIndex == 0)
                this.tb_SurfaceName.Text = "x_" + this.tb_IsoValues.Text.ToString();
            else if (this.cb_xyzCoordinate.SelectedIndex == 1)
                this.tb_SurfaceName.Text = "y_" + this.tb_IsoValues.Text.ToString();
            else
                this.tb_SurfaceName.Text = "z_" + this.tb_IsoValues.Text.ToString();
        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            createSurfaceGUI(out sb_CreateSurface);
            this.lsb_Surface.Items.Add(this.tb_SurfaceName.Text.ToString());
        }

        private void createSurfaceGUI(out StringBuilder sb)
        {
            sb = new StringBuilder();
            sb.AppendLine("(cx-gui-do cx-set-list-selections \"Iso-Surface*Table1*DropDownList1(Surface of Constant)\" '( 9))");
            sb.AppendLine("(cx-gui-do cx-activate-item \"Iso-Surface*Table1*DropDownList1(Surface of Constant)\")");
            if (cb_xyzCoordinate.SelectedIndex == 0)
                sb.AppendLine("(cx-gui-do cx-set-list-selections \"Iso-Surface*Table1*DropDownList2\" '( 0))");
            else if (cb_xyzCoordinate.SelectedIndex == 1)
                sb.AppendLine("(cx-gui-do cx-set-list-selections \"Iso-Surface*Table1*DropDownList2\" '( 1))");
            else
                sb.AppendLine("(cx-gui-do cx-set-list-selections \"Iso-Surface*Table1*DropDownList2\" '( 2))");
            sb.AppendLine("(cx-gui-do cx-activate-item \"Iso-Surface*Table1*DropDownList2\")");
            sb.AppendLine("(cx-gui-do cx-set-real-entry-list \"Iso-Surface*Table1*RealEntry5(Iso-Values)\" '( " + this.tb_IsoValues.Text.ToString() + "))");
            sb.AppendLine("(cx-gui-do cx-set-text-entry \"Iso-Surface*Table1*TextEntry7(New Surface Name)\" \"" + this.tb_SurfaceName.Text.ToString() + "\")");
            sb.AppendLine("(cx-gui-do cx-activate-item \"Iso-Surface*PanelButtons*PushButton1(OK)\")");
        }

        private void lsb_Surface_ItemClick(object sender, EventArgs e)
        {
            this.surfacesName.Clear();
            foreach (ListBoxItem l in this.lsb_Surface.SelectedItems)
            {
                this.surfacesName.Add(l.Text.ToString());
            }
        }
    }
}
