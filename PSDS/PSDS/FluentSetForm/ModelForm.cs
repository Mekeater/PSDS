using DevComponents.DotNetBar;
using GlobeCode.Common;
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
    public partial class ModelForm : Office2007Form
    {
        public ModelForm()
        {
            InitializeComponent();
        }

        public Energy energy=Energy.ON;
        public Viscous viscous = Viscous.k_eStandard;
        public Radiation radiation = Radiation.OFF;
        public Species species = Species.ON;
        public Action action;

        private void ModelForm_Load(object sender, EventArgs e)
        {
            this.cb_Energy.Items.AddRange(new string[] { "OFF", "ON" });
            //this.cb_Viscous.Items.AddRange(new string[] { "Inviscid","Laminar","Spalart-Allmaras模型",
            //    "标准k-ε模型", "RNG k-ε模型","Realizable k-ε模型","标准k-ω模型","BSL k-ω模型",
            //    "SST k-ω模型"});
            //Spalart-Allmaras模型 不加了
            this.cb_Viscous.Items.AddRange(new string[] { "Inviscid","Laminar",
                "标准k-ε模型", "RNG k-ε模型","Realizable k-ε模型","标准k-ω模型","BSL k-ω模型",
                "SST k-ω模型"});
            this.cb_Radiation.Items.AddRange(new string[] { "OFF", "Rosseland模型", "P1模型", "S2S模型", "DO模型" });
            this.cb_Species.Items.AddRange(new string[] { "OFF", "ON" });

            this.cb_Energy.SelectedIndex = 1;
            this.cb_Viscous.SelectedIndex = 2;
            this.cb_Radiation.SelectedIndex = 0;
            this.cb_Species.SelectedIndex = 1;

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

        private void labelX2_Click(object sender, EventArgs e)
        {
            this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Viscous;
        }

        private void cb_Energy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_Energy.SelectedIndex == 0)
            {
                this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Energy_OFF;
                energy = Energy.OFF;
            }
            else
            {
                this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Energy_ON;
                energy = Energy.ON;
            }
        }

        private void cb_Viscous_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.cb_Viscous.SelectedIndex)
            {
                case 0:
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Viscous_Inviscid;
                    viscous = Viscous.Inviscid;
                    break;
                case 1:
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Viscous_Laminar;
                    viscous = Viscous.Laminar;
                    break;
                //case 2:
                //    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Viscous_SpalartAllmaras;
                //    viscous = Viscous.SpalartAllmaras;
                //    break;
                case 2:
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Viscous_k_eStandard;
                    viscous = Viscous.k_eStandard;
                    break;
                case 3:
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Viscous_k_eRNG;
                    viscous = Viscous.k_eRNG;
                    break;
                case 4:
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Viscous_k_eRealizable;
                    viscous = Viscous.k_eRealizable;
                    break;
                case 5:
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Viscous_k_oStandard;
                    viscous = Viscous.k_oStandard;
                    break;
                case 6:
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Viscous_k_oBSL;
                    viscous = Viscous.k_oBSL;
                    break;
                case 7:
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Viscous_k_oSST;
                    viscous = Viscous.k_oSST;
                    break;
                default:
                    break;
            }
        }

        private void cb_Radiation_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cb_Radiation.SelectedItem.ToString())
            {
                case "OFF":
                    radiation = Radiation.OFF;
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Radiation_OFF;
                    break;
                case "Rosseland模型":
                    radiation = Radiation.Rosseland;
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Radiation_Rosseland;
                    break;
                case "P1模型":
                    radiation = Radiation.P1;
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Radiation_P1;
                    break;
                case "S2S模型":
                    radiation = Radiation.S2S;
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Radiation_S2S;
                    break;
                case "DO模型":
                    radiation = Radiation.DO;
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Radiation_DO;
                    break;
                default:
                    break;
            }

            //辐射模型开启，则能力方程自动开启
            if(!this.cb_Radiation.SelectedItem.ToString().Equals("OFF"))
            {
                this.cb_Energy.SelectedIndex = 1;
            }
        }

        private void cb_Species_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(this.cb_Species.SelectedIndex==0)
            {
                species = Species.OFF;
                this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Species_OFF;
            }
            else
            {
                species = Species.ON;
                this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Species_ON;
            }

            //组分模型开启，则能力方程自动开启
            if (!this.cb_Species.SelectedItem.ToString().Equals("OFF"))
            {
                this.cb_Energy.SelectedIndex = 1;
            }
        }

        private void labelX3_Click(object sender, EventArgs e)
        {
            this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Radiation;
        }

        private void labelX4_Click(object sender, EventArgs e)
        {
            this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Species;
        }
    }
}
