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
    public partial class ModelsForm : Office2007Form
    {
        public ModelsForm()
        {
            InitializeComponent();
        }

        public Energy energy;
        public Viscous viscous;
        public Radiation radiation;
        public Species species;
        public Action action;

        private void ModelsForm_Load(object sender, EventArgs e)
        {
            this.cb_Energy.Items.AddRange(new string[] { "OFF", "ON" });
            this.cb_Viscous.Items.AddRange(new string[] { "Inviscid","Laminar","Spalart-Allmaras模型",
                "标准k-ε模型", "RNG k-ε模型","Realizable k-ε模型","标准k-ω模型","BSL k-ω模型",
                "SST k-ω模型"});
            this.cb_Radiation.Items.AddRange(new string[] { "OFF", "Rosseland模型", "P1模型", "S2S模型", "DO模型" });
            this.cb_Species.Items.AddRange(new string[] { "OFF", "ON" });

            this.cb_Energy.SelectedIndex = 0;
            this.cb_Viscous.SelectedIndex = 3;
            this.cb_Radiation.SelectedIndex = 0;
            this.cb_Species.SelectedIndex = 1;

            energy = Energy.OFF;
            viscous = Viscous.k_eStandard;
            radiation = Radiation.OFF;
            species = Species.ON;

            this.lb_help.Text = "帮助：\r\n";

            action = new Action(bindAction);
        }

        private void bindAction()
        {
            if (GlobleVariable.solverForm.solverType == SolverType.PressureBased)
            {
                this.cb_Radiation.Items.Clear();
                this.cb_Radiation.Items.AddRange(new string[] { "OFF", "Rosseland模型", "P1模型", "S2S模型", "DO模型" });
            }
            else
            {
                this.cb_Radiation.Items.Clear();
                this.cb_Radiation.Items.AddRange(new string[] { "OFF", "P1模型", "S2S模型", "DO模型" });
            }
        }
    }
}
