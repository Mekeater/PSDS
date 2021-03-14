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
using GlobeCode.Common;
using GlobeCode.FluentClass;

namespace GlobeCode
{
    public partial class MaterialsForm : Office2007Form
    {
        public MaterialsForm()
        {
            InitializeComponent();
        }

        public ListBoxAdv listBox_MatrialsFluid;
        public StringBuilder sb_Species;
        public List<string> matrialsIndex;
        public Action action; //委托类型
        public ListBoxAdv ListBox_Species = null;

        public ModelsSelect ModelsStatus;//模型组合情况

        private void MaterialsForm_Load(object sender, EventArgs e)
        {
            if(this.lsb_MatrialsDB.Items.Count==0)
            {
                this.lsb_MatrialsDB.Items.Add("氨气");
                this.lsb_MatrialsDB.Items.Add("臭氧");
                this.lsb_MatrialsDB.Items.Add("二氧化氮");
                this.lsb_MatrialsDB.Items.Add("二氧化硫");
                this.lsb_MatrialsDB.Items.Add("三氧化硫");
                this.lsb_MatrialsDB.Items.Add("一氧化碳");
                this.lsb_MatrialsDB.Items.Add("二氧化碳");
                this.lsb_MatrialsDB.Items.Add("硫化氢");
                this.lsb_MatrialsDB.Items.Add("氯气");

                if (GlobleVariable.modelForm.species == Species.OFF)
                {
                    this.lsb_MatrialsDB.Items.Add("水");
                    this.lsb_MatrialsDB.Items.Add("氧气");
                    this.lsb_MatrialsDB.Items.Add("氮气");
                }

                this.lsb_MatrialsFluid.Items.Add("空气");
                listBox_MatrialsFluid = this.lsb_MatrialsFluid;

                this.lsb_Species.Items.Add("水");
                this.lsb_Species.Items.Add("氧气");
                this.lsb_Species.Items.Add("氮气");
            }
            

            sb_Species = new StringBuilder();//存储组分材料选择的指令
            matrialsIndex = new List<string>();//存储可用（计算）材料的索引值
            action = new Action(SpeciesIsOn);//绑定委托

            this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Materials;

            ListBox_Species = this.lsb_Species;
        }

        //判断组分传输模型是否打开
        private void SpeciesIsOn()
        {
            if (GlobleVariable.modelForm.species == Species.OFF)
            {
                this.lsb_Species.Visible = false;
                this.lb_Species.Visible = false;
                this.btn_left1.Visible = false;
                this.btn_right1.Visible = false;
                if (!this.lsb_MatrialsDB.Items.Contains("水"))
                {
                    this.lsb_MatrialsDB.Items.Add("水");
                    this.lsb_MatrialsDB.Items.Add("氧气");
                    this.lsb_MatrialsDB.Items.Add("氮气");
                }
            }
            else
            {
                this.lsb_Species.Visible = true;
                this.lb_Species.Visible = true;
                this.btn_left1.Visible = true;
                this.btn_right1.Visible = true;
                if (this.lsb_MatrialsDB.Items.Contains("水"))
                {
                    this.lsb_MatrialsDB.Items.Remove("水");
                    this.lsb_MatrialsDB.Items.Remove("氧气");
                    this.lsb_MatrialsDB.Items.Remove("氮气");
                }
            }

            UpdataModelsStatus();
        }

        /// <summary>
        /// 更新模型组合状态
        /// </summary>
        private void UpdataModelsStatus()
        {
            if (GlobleVariable.modelForm.energy == Energy.OFF &&
                (GlobleVariable.modelForm.viscous == Viscous.Inviscid ||
                GlobleVariable.modelForm.viscous == Viscous.Laminar))
            {
                this.ModelsStatus = ModelsSelect.OFFOFF;
            }
            else if (GlobleVariable.modelForm.energy == Energy.OFF &&
                (GlobleVariable.modelForm.viscous != Viscous.Inviscid &&
                GlobleVariable.modelForm.viscous != Viscous.Laminar))
            {
                this.ModelsStatus = ModelsSelect.OFFON;
            }

            else if (GlobleVariable.modelForm.energy == Energy.ON &&
                (GlobleVariable.modelForm.viscous == Viscous.Inviscid ||
                GlobleVariable.modelForm.viscous == Viscous.Laminar) &&
                GlobleVariable.modelForm.radiation != Radiation.OFF &&
                GlobleVariable.modelForm.species == Species.ON)
            {
                this.ModelsStatus = ModelsSelect.ONOFFONON;
            }
            else if (GlobleVariable.modelForm.energy == Energy.ON &&
                (GlobleVariable.modelForm.viscous == Viscous.Inviscid ||
                GlobleVariable.modelForm.viscous == Viscous.Laminar) &&
                GlobleVariable.modelForm.radiation != Radiation.OFF &&
                GlobleVariable.modelForm.species == Species.OFF)
            {
                this.ModelsStatus = ModelsSelect.ONOFFONOFF;
            }

            else if (GlobleVariable.modelForm.energy == Energy.ON &&
               (GlobleVariable.modelForm.viscous == Viscous.Inviscid ||
               GlobleVariable.modelForm.viscous == Viscous.Laminar) &&
               GlobleVariable.modelForm.radiation == Radiation.OFF &&
               GlobleVariable.modelForm.species == Species.ON)
            {
                this.ModelsStatus = ModelsSelect.ONOFFOFFON; ;
            }
            else if (GlobleVariable.modelForm.energy == Energy.ON &&
               (GlobleVariable.modelForm.viscous == Viscous.Inviscid ||
               GlobleVariable.modelForm.viscous == Viscous.Laminar) &&
               GlobleVariable.modelForm.radiation == Radiation.OFF &&
               GlobleVariable.modelForm.species == Species.OFF)
            {
                this.ModelsStatus = ModelsSelect.ONOFFOFFOFF;
            }

            else if (GlobleVariable.modelForm.energy == Energy.ON &&
               (GlobleVariable.modelForm.viscous != Viscous.Inviscid ||
               GlobleVariable.modelForm.viscous != Viscous.Laminar) &&
               GlobleVariable.modelForm.radiation == Radiation.OFF &&
               GlobleVariable.modelForm.species == Species.ON)
            {
                this.ModelsStatus = ModelsSelect.ONONOFFON;
            }
            else if (GlobleVariable.modelForm.energy == Energy.ON &&
              (GlobleVariable.modelForm.viscous != Viscous.Inviscid ||
              GlobleVariable.modelForm.viscous != Viscous.Laminar) &&
              GlobleVariable.modelForm.radiation == Radiation.OFF &&
              GlobleVariable.modelForm.species == Species.OFF)
            {
                this.ModelsStatus = ModelsSelect.ONONOFFOFF;
            }

            else if (GlobleVariable.modelForm.energy == Energy.ON &&
              (GlobleVariable.modelForm.viscous != Viscous.Inviscid ||
              GlobleVariable.modelForm.viscous != Viscous.Laminar) &&
              GlobleVariable.modelForm.radiation != Radiation.OFF &&
              GlobleVariable.modelForm.species == Species.ON)
            {
                this.ModelsStatus = ModelsSelect.ONONONON;
            }
            else if (GlobleVariable.modelForm.energy == Energy.ON &&
              (GlobleVariable.modelForm.viscous != Viscous.Inviscid ||
              GlobleVariable.modelForm.viscous != Viscous.Laminar) &&
              GlobleVariable.modelForm.radiation != Radiation.OFF &&
              GlobleVariable.modelForm.species == Species.OFF)
            {
                this.ModelsStatus = ModelsSelect.ONONONOFF;
            }
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.lsb_MatrialsDB.SelectedItem.ToString())
                {
                    case "氨气":
                        matrialsIndex.Add(((int)Materials.nh3).ToString());
                        break;
                    case "臭氧":
                        matrialsIndex.Add(((int)Materials.o3).ToString());
                        break;
                    case "二氧化氮":
                        matrialsIndex.Add(((int)Materials.no2).ToString());
                        break;
                    case "二氧化硫":
                        matrialsIndex.Add(((int)Materials.so2).ToString());
                        break;
                    case "三氧化硫":
                        matrialsIndex.Add(((int)Materials.so3).ToString());
                        break;
                    case "一氧化碳":
                        matrialsIndex.Add(((int)Materials.co).ToString());
                        break;
                    case "二氧化碳":
                        matrialsIndex.Add(((int)Materials.co2).ToString());
                        break;
                    case "硫化氢":
                        matrialsIndex.Add(((int)Materials.h2s).ToString());
                        break;
                    case "水":
                        matrialsIndex.Add(((int)Materials.h2o).ToString());
                        break;
                    case "氧气":
                        matrialsIndex.Add(((int)Materials.o2).ToString());
                        break;
                    case "氮气":
                        matrialsIndex.Add(((int)Materials.n2).ToString());
                        break;
                    case "氯气":
                        matrialsIndex.Add(((int)Materials.cl2).ToString());
                        break;
                }

                this.lsb_MatrialsFluid.Items.Add(this.lsb_MatrialsDB.SelectedItem.ToString());
                this.lsb_MatrialsDB.Items.Remove(this.lsb_MatrialsDB.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.lsb_MatrialsFluid.SelectedItem.ToString())
                {
                    case "氨气":
                        matrialsIndex.Remove(((int)Materials.nh3).ToString());
                        break;
                    case "臭氧":
                        matrialsIndex.Remove(((int)Materials.o3).ToString());
                        break;
                    case "二氧化氮":
                        matrialsIndex.Remove(((int)Materials.no2).ToString());
                        break;
                    case "二氧化硫":
                        matrialsIndex.Remove(((int)Materials.so2).ToString());
                        break;
                    case "三氧化硫":
                        matrialsIndex.Remove(((int)Materials.so3).ToString());
                        break;
                    case "一氧化碳":
                        matrialsIndex.Remove(((int)Materials.co).ToString());
                        break;
                    case "二氧化碳":
                        matrialsIndex.Remove(((int)Materials.co2).ToString());
                        break;
                    case "硫化氢":
                        matrialsIndex.Remove(((int)Materials.h2s).ToString());
                        break;
                    case "水":
                        matrialsIndex.Remove(((int)Materials.h2o).ToString());
                        break;
                    case "氧气":
                        matrialsIndex.Remove(((int)Materials.o2).ToString());
                        break;
                    case "氮气":
                        matrialsIndex.Remove(((int)Materials.n2).ToString());
                        break;
                    case "氯气":
                        matrialsIndex.Remove(((int)Materials.cl2).ToString());
                        break;
                }

                this.lsb_MatrialsDB.Items.Add(this.lsb_MatrialsFluid.SelectedItem.ToString());
                this.lsb_MatrialsFluid.Items.Remove(this.lsb_MatrialsFluid.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //添加组分操作
        private void btn_right1_Click(object sender, EventArgs e)
        {
            if (this.lsb_MatrialsFluid.Items.Count == 0)
            {
                MessageBox.Show("无材料添加", "提示");
                return;
            }
            if (this.lsb_MatrialsFluid.SelectedItem == null)
            {
                MessageBox.Show("未选择材料", "提示");
                return;
            }
            sb_Species.Append("(cx-gui-do cx-set-list-selections \"Species*Table2*List1(Available Materials)\" '( \"");
            switch (this.lsb_MatrialsFluid.SelectedItem.ToString())
            {
                case "臭氧":
                    sb_Species.Append(MaterialsFullName.o3_full);
                    break;
                case "二氧化氮":
                    sb_Species.Append(MaterialsFullName.no2_full);
                    break;
                case "二氧化硫":
                    sb_Species.Append(MaterialsFullName.so2_full);
                    break;
                case "三氧化硫":
                    sb_Species.Append(MaterialsFullName.so3_full);
                    break;
                case "一氧化碳":
                    sb_Species.Append(MaterialsFullName.co_full);
                    break;
                case "二氧化碳":
                    sb_Species.Append(MaterialsFullName.co2_full);
                    break;
                case "硫化氢":
                    sb_Species.Append(MaterialsFullName.h2s_full);
                    break;
                case "水":
                    sb_Species.Append(MaterialsFullName.h2o_full);
                    break;
                case "氨气":
                    sb_Species.Append(MaterialsFullName.nh3_full);
                    break;
                case "氧气":
                    sb_Species.Append(MaterialsFullName.o2_full);
                    break;
                case "氮气":
                    sb_Species.Append(MaterialsFullName.n2_full);
                    break;
                case "空气":
                    sb_Species.Append(MaterialsFullName.air_full);
                    break;
                case "氯气":
                    sb_Species.Append(MaterialsFullName.cl2_full);
                    break;
                default:
                    break;
            }
            sb_Species.AppendLine("\"))");
            sb_Species.AppendLine("(cx-gui-do cx-activate-item \"Species*Table2*List1(Available Materials)\")");
            sb_Species.AppendLine("(cx-gui-do cx-activate-item \"Species*Table2*Frame2*ButtonBox2*PushButton1(Add)\")");

            this.lsb_Species.Items.Add(this.lsb_MatrialsFluid.SelectedItem.ToString());
            this.lsb_MatrialsFluid.Items.Remove(this.lsb_MatrialsFluid.SelectedItem.ToString());

        }
        //移除组分操作
        private void btn_left1_Click(object sender, EventArgs e)
        {
            if (this.lsb_Species.Items.Count == 1)
            {
                MessageBox.Show("必须保留至少一种材料!", "提示");
                return;
            }
            if (this.lsb_Species.SelectedItem == null)
            {
                MessageBox.Show("未选择材料", "提示");
                return;
            }

            sb_Species.Append("(cx-gui-do cx-set-list-selections \"Species*Table2*Frame2*List1(Selected Species)\" '( ");
            switch (this.lsb_Species.SelectedItem.ToString())
            {
                case "臭氧":
                    sb_Species.Append(Materials.o3.ToString());
                    break;
                case "二氧化氮":
                    sb_Species.Append(Materials.no2.ToString());
                    break;
                case "二氧化硫":
                    sb_Species.Append(Materials.so2.ToString());
                    break;
                case "三氧化硫":
                    sb_Species.Append(Materials.so3.ToString());
                    break;
                case "一氧化碳":
                    sb_Species.Append(Materials.co.ToString());
                    break;
                case "二氧化碳":
                    sb_Species.Append(Materials.co2.ToString());
                    break;
                case "硫化氢":
                    sb_Species.Append(Materials.h2s.ToString());
                    break;
                case "水":
                    sb_Species.Append(Materials.h2o.ToString());
                    break;
                case "氧气":
                    sb_Species.Append(Materials.o2.ToString());
                    break;
                case "氮气":
                    sb_Species.Append(Materials.n2.ToString());
                    break;
                case "氯气":
                    sb_Species.Append(Materials.cl2.ToString());
                    break;
                default:
                    break;
            }
            sb_Species.AppendLine("))");
            sb_Species.AppendLine("(cx-gui-do cx-activate-item \"Species*Table2*Frame2*List1(Selected Species)\")");
            sb_Species.AppendLine("(cx-gui-do cx-activate-item \"Species*Table2*Frame2*ButtonBox2*PushButton2(Remove)\")");

            this.lsb_MatrialsFluid.Items.Add(this.lsb_Species.SelectedItem.ToString());
            this.lsb_Species.Items.Remove(this.lsb_Species.SelectedItem.ToString());
        }

        /// <summary>
        /// 材料名 中文转英文简称
        /// </summary>
        /// <param name="C">材料中文名</param>
        /// <returns></returns>
        public string MaterialsCToE(string C)
        {
            string E = null;
            switch (C)
            {
                case "臭氧":
                    E = Materials.o3.ToString();
                    break;
                case "二氧化氮":
                    E = Materials.no2.ToString();
                    break;
                case "二氧化硫":
                    E = Materials.so2.ToString();
                    break;
                case "三氧化硫":
                    E = Materials.so3.ToString();
                    break;
                case "一氧化碳":
                    E = Materials.co.ToString();
                    break;
                case "二氧化碳":
                    E = Materials.co2.ToString();
                    break;
                case "硫化氢":
                    E = Materials.h2s.ToString();
                    break;
                case "水":
                    E = Materials.h2o.ToString();
                    break;
                case "氧气":
                    E = Materials.o2.ToString();
                    break;
                case "氮气":
                    E = Materials.n2.ToString();
                    break;
                case "氯气":
                    E = Materials.cl2.ToString();
                    break;
                case "空气":
                    E = "air";
                    break;
            }
            return E;
        }
    }
}
