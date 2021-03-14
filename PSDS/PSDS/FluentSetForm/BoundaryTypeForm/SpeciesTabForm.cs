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
    public partial class SpeciesTabForm : Office2007Form
    {
        public SpeciesTabForm()
        {
            InitializeComponent();
        }

        public Action action;

        /// <summary>
        /// 组分质量分数设置
        /// </summary>
        public List<string> speciesMassFractions;
        public Action DataUpdate;//数据更新委托

        private Dictionary<string, string> speciesFractions;

        private void SpeciesTabForm_Load(object sender, EventArgs e)
        {
           
            speciesMassFractions = new List<string>();
           
            action = new Action(BindAction);
            DataUpdate = new Action(DataUpdateActive);

            //初始 平均组分质量分数
            int speciesNum = GlobleVariable.materialsForm.ListBox_Species.Items.Count;
            this.tb_Fractions.Text = (1.0 / speciesNum).ToString("#0.0");
            speciesFractions = new Dictionary<string, string>();
        }

        private void BindAction()
        {
            if (GlobleVariable.materialsForm.ListBox_Species == null)
                return;
            this.lsb_SpeciesName.Items.Clear();
            string speciesMaterialName;//组分材料名
            for (int i = 0; i < GlobleVariable.materialsForm.ListBox_Species.Items.Count-1; i++)
            {
                speciesMaterialName = GlobleVariable.materialsForm.ListBox_Species.Items[i].ToString();
                this.lsb_SpeciesName.Items.Add(speciesMaterialName);
                
                //初始化质量分数
                if(speciesFractions.ContainsKey(speciesMaterialName))
                {
                    speciesFractions.Remove(speciesMaterialName);
                    speciesFractions.Add(speciesMaterialName, this.tb_Fractions.Text.ToString());
                }
                else
                    speciesFractions.Add(speciesMaterialName, this.tb_Fractions.Text.ToString());

            }
            this.lsb_SpeciesName.SelectedIndex = 0;
        }

        private void DataUpdateActive()
        {
            speciesMassFractions = new List<string>();
            for(int i=0;i<this.lsb_SpeciesName.Items.Count;i++)
            {
                string test = speciesFractions[this.lsb_SpeciesName.Items[i].ToString()];
                speciesMassFractions.Add(speciesFractions[this.lsb_SpeciesName.Items[i].ToString()]);
            }
        }

        private void tb_Fractions_TextChanged(object sender, EventArgs e)
        {
            try
            {
                speciesFractions[this.lsb_SpeciesName.SelectedItem.ToString()] = this.tb_Fractions.Text.ToString();

            }
            catch { }
           
        }
    }
}
