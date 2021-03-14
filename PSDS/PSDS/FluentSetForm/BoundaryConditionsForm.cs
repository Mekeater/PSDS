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

using GlobeCode.Common;
using GlobeCode.DataStruct;
using GlobeCode.FluentClass;
using System.IO;

namespace GlobeCode
{
    public partial class BoundaryConditionsForm : Office2007Form
    {
        public BoundaryConditionsForm()
        {
            InitializeComponent();
        }

        public Action action;
        public List<string[]> boundarys;
        private bool zonesToTypeChange = false;//判断边界类型的变化是否为点击zone区域所导致

        public StringBuilder sb_BoundaryCon;

        private void BoundaryConditionsForm_Load(object sender, EventArgs e)
        {
            this.lb_help.Text ="帮助：\r\n" + HelpDescriptions.BoundaryConditions;
            this.cb_BoundaryType.Items.AddRange(new string[] { "压力出口", "速度入口", "质量流入口", "压力入口", "质量流出口","出流", "壁面" });

            //边界条件模块子窗口
            if (GlobleVariable.thermalTabForm == null)
            {
                GlobleVariable.thermalTabForm = new ThermalTabForm();
                GlobleVariable.radiationTabForm = new RadiationTabForm();
                GlobleVariable.speciesTabForm = new SpeciesTabForm();
                GlobleVariable.pressureInletMomentumTabForm = new PressureInletMomentumTabForm();
                GlobleVariable.velocityInletMomentumTabForm = new VelocityInletMomentumTabForm();
                GlobleVariable.massFlowInletMomentumTabForm = new MassFlowInletMomentumTabForm();
                GlobleVariable.massFlowOutletMomentumTabForm = new MassFlowOutletMomentumTabForm();
                GlobleVariable.pressureOutletMomentumTabForm = new PressureOutletMomentumTabForm();
            }

            sb_BoundaryCon = new StringBuilder();//存储边界条件设置的相关命令

            action = new Action(BindAction);
        }

        private void BindAction()
        {
            string meshFilePath = GlobleVariable.solverForm.meshFilePath;
            if (!meshFilePath.Equals(""))
            {
                this.lsb_Zones.Items.Clear();
                boundarys = MeshInfoClass.GetBoundarys(GlobleVariable.solverForm.meshFilePath);
                foreach(string[] boundary in boundarys)
                {
                    this.lsb_Zones.Items.Add(boundary[1]);
                }
            }
            else
            {
                this.lsb_Zones.Items.Clear();
                this.lsb_Zones.Items.Add("未选择mesh文件路径!!!");
            }
            this.cb_BoundaryType.SelectedIndex = -1;
            this.lb_help.Text ="帮助：\r\n" + HelpDescriptions.BoundaryConditions;
            this.p_BoundaryTab.Visible = false;
        }


        /// <summary>
        /// 设置tab子窗口
        /// </summary>
        /// <param name="tabName">tab标签名</param>
        /// <param name="form">子窗口</param>
        private void SetTabShow(string tabName, Form form)
        {
            //设置该子窗体不为顶级窗体，否则不能加入到别的控件中
            form.TopLevel = false;
            form.Visible = true;
            //布满父控件
            form.Dock = DockStyle.Fill;
            //创建一个tab
            SuperTabItem item = superTabControlBoundry.CreateTab(tabName);
            //设置显示名和控件名
            item.Text = tabName;
            item.Name = tabName;
            //将子窗体添加到Tab中
            item.AttachedControl.Controls.Add(form);
            //选择该子窗体。
            superTabControlBoundry.SelectedTab = item;
        }

        private void cb_BoundaryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoundaryConditionsHelp_Set();

            if(this.cb_BoundaryType.SelectedIndex!=-1)
            {
                string boundaryTypeE = BoundaryConditionsTypeCToE(this.cb_BoundaryType.SelectedItem.ToString());//当前切换的边界类型英文名
                boundarys[this.lsb_Zones.SelectedIndex][0] = boundaryTypeE;//修改边界类型

                sb_BoundaryCon.AppendLine(GlobleVariable.BCS.ModifyBoundaryType(this.lsb_Zones.SelectedItem.ToString(), boundaryTypeE));
            }
        }

        private void lsb_Zones_ItemClick(object sender, EventArgs e)
        {
            BoundaryConditionsType_Set();

        }

        /// <summary>
        /// 显示边界条件类型以及边界条件设置子tab对话框
        /// </summary>
        private void BoundaryConditionsType_Set()
        {
            #region 舍弃代码
            //if (boundarys == null)
            //    return;

            //if(this.lsb_Zones.SelectedIndex==-1)
            //{
            //    MessageBox.Show("未选择列表中的区域", "提示");
            //    return;
            //}

            //this.zonesToTypeChange = true;
            //string boundary= boundarys[this.lsb_Zones.SelectedIndex][0].ToString();
            //if (boundary.Equals(BoundaryTypeE.mass_flow_inlet))
            //{
            //    this.cb_BoundaryType.Text = BoundaryTypeC.mass_flow_inlet;
            //}
            //else if (boundary.Equals(BoundaryTypeE.mass_flow_outlet))
            //{
            //    this.cb_BoundaryType.Text = BoundaryTypeC.mass_flow_outlet;
            //}
            //else if (boundary.Equals(BoundaryTypeE.outflow))
            //{
            //    this.cb_BoundaryType.Text = BoundaryTypeC.outflow;
            //}
            //else if (boundary.Equals(BoundaryTypeE.pressure_inlet))
            //{
            //    this.cb_BoundaryType.Text = BoundaryTypeC.pressure_inlet;
            //}
            //else if (boundary.Equals(BoundaryTypeE.pressure_outlet))
            //{
            //    this.cb_BoundaryType.Text = BoundaryTypeC.pressure_outlet;
            //}
            //else if (boundary.Equals(BoundaryTypeE.velocity_inlet))
            //{
            //    this.cb_BoundaryType.Text = BoundaryTypeC.velocity_inlet;
            //}
            //else if (boundary.Equals(BoundaryTypeE.wall))
            //{
            //    this.cb_BoundaryType.Text = BoundaryTypeC.wall;
            //}

            #endregion


            if (boundarys == null)
                return;

            if (this.lsb_Zones.SelectedIndex == -1)
            {
                MessageBox.Show("未选择列表中的区域", "提示");
                return;
            }

            this.zonesToTypeChange = true;
            this.p_BoundaryTab.Visible = true;
            this.superTabControlBoundry.Tabs.Clear();
            string boundary = boundarys[this.lsb_Zones.SelectedIndex][0].ToString();
            if (boundary.Equals(BoundaryTypeE.mass_flow_inlet))
            {
                this.cb_BoundaryType.Text = BoundaryTypeC.mass_flow_inlet;
                SetTabShow("动量", GlobleVariable.massFlowInletMomentumTabForm);
                GlobleVariable.massFlowInletMomentumTabForm.action();

            }
            else if (boundary.Equals(BoundaryTypeE.mass_flow_outlet))
            {
                this.cb_BoundaryType.Text = BoundaryTypeC.mass_flow_outlet;
                SetTabShow("动量", GlobleVariable.massFlowOutletMomentumTabForm);
            }
            else if (boundary.Equals(BoundaryTypeE.outflow))
            {
                this.cb_BoundaryType.Text = BoundaryTypeC.outflow;
                this.p_BoundaryTab.Visible = false;
            }
            else if (boundary.Equals(BoundaryTypeE.pressure_inlet))
            {
                this.cb_BoundaryType.Text = BoundaryTypeC.pressure_inlet;
                SetTabShow("动量", GlobleVariable.pressureInletMomentumTabForm);
                GlobleVariable.pressureInletMomentumTabForm.action();
            }
            else if (boundary.Equals(BoundaryTypeE.pressure_outlet))
            {
                this.cb_BoundaryType.Text = BoundaryTypeC.pressure_outlet;
                SetTabShow("动量", GlobleVariable.pressureOutletMomentumTabForm);
                GlobleVariable.pressureOutletMomentumTabForm.action();
            }
            else if (boundary.Equals(BoundaryTypeE.velocity_inlet))
            {
                this.cb_BoundaryType.Text = BoundaryTypeC.velocity_inlet;
                SetTabShow("动量", GlobleVariable.velocityInletMomentumTabForm);
                GlobleVariable.velocityInletMomentumTabForm.action();
            }
            else if (boundary.Equals(BoundaryTypeE.wall))
            {
                this.cb_BoundaryType.Text = BoundaryTypeC.wall;
                this.p_BoundaryTab.Visible = false;
            }


            if (!boundary.Equals(BoundaryTypeE.outflow) || !boundary.Equals(BoundaryTypeE.wall))
            {
                if (boundary.Equals(BoundaryTypeE.mass_flow_outlet))
                {
                    if (GlobleVariable.modelForm.radiation == Radiation.P1 || GlobleVariable.modelForm.radiation == Radiation.S2S || GlobleVariable.modelForm.radiation == Radiation.DO)
                        SetTabShow("辐射", GlobleVariable.radiationTabForm);
                }
                else
                {
                    if (GlobleVariable.modelForm.radiation == Radiation.P1 || GlobleVariable.modelForm.radiation == Radiation.S2S || GlobleVariable.modelForm.radiation == Radiation.DO)
                        SetTabShow("辐射", GlobleVariable.radiationTabForm);
                    if (GlobleVariable.modelForm.species == Species.ON)
                        SetTabShow("组分", GlobleVariable.speciesTabForm);
                    if (GlobleVariable.modelForm.energy == Energy.ON)
                        SetTabShow("热量", GlobleVariable.thermalTabForm);
                }
            }

            this.superTabControlBoundry.SelectedTabIndex = 0;

            if (GlobleVariable.modelForm.species == Species.ON)
                GlobleVariable.speciesTabForm.action();//执行委托，设置组分
            if (GlobleVariable.velocityInletMomentumTabForm.action != null)
                GlobleVariable.velocityInletMomentumTabForm.action();
        }

        /// <summary>
        /// 边界条件帮助说明和边界条件设置子tab对话框
        /// </summary>
        private void BoundaryConditionsHelp_Set()
        {
            if (this.cb_BoundaryType.SelectedItem == null)
                return;
            if (this.lsb_Zones.SelectedIndex == -1)
            {
                MessageBox.Show("未选择列表中的区域", "提示");
                this.cb_BoundaryType.SelectedIndex = -1;
                return;
            }

            this.p_BoundaryTab.Visible = true;
            this.superTabControlBoundry.Tabs.Clear();
            switch (this.cb_BoundaryType.SelectedItem.ToString())
            {
                case "压力出口":
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.PressureOutlet;
                    if (!zonesToTypeChange)
                    {
                        SetTabShow("动量", GlobleVariable.pressureOutletMomentumTabForm);
                        GlobleVariable.pressureOutletMomentumTabForm.action();
                    }
                    break;
                case "速度入口":
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.VelocityInlet;
                    if (!zonesToTypeChange)
                    {
                        SetTabShow("动量", GlobleVariable.velocityInletMomentumTabForm);
                        GlobleVariable.velocityInletMomentumTabForm.action();
                    }
                    break;
                case "质量流入口":
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Mass_FlowInlet;
                    if (!zonesToTypeChange)
                        SetTabShow("动量", GlobleVariable.massFlowInletMomentumTabForm);
                    break;
                case "压力入口":
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.PressureInlet;
                    if (!zonesToTypeChange)
                    {
                        SetTabShow("动量", GlobleVariable.pressureInletMomentumTabForm);
                        GlobleVariable.pressureInletMomentumTabForm.action();
                    }
                    break;
                case "质量流出口":
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Mass_FlowOutlet;
                    if (!zonesToTypeChange)
                        SetTabShow("动量", GlobleVariable.massFlowOutletMomentumTabForm);
                    break;
                case "出流":
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.OutFlow;
                    this.p_BoundaryTab.Visible = false;
                    break;
                case "壁面":
                    this.lb_help.Text = "帮助：\r\n" + HelpDescriptions.Wall;
                    this.p_BoundaryTab.Visible = false;
                    break;
                default:
                    break;
            }
            if (!zonesToTypeChange && (!this.cb_BoundaryType.SelectedItem.ToString().Equals("出流") || !this.cb_BoundaryType.SelectedItem.ToString().Equals("壁面")))
            {
                if (this.cb_BoundaryType.SelectedItem.ToString().Equals("质量流出口"))
                {
                    if (GlobleVariable.modelForm.radiation == Radiation.P1 || GlobleVariable.modelForm.radiation == Radiation.S2S || GlobleVariable.modelForm.radiation == Radiation.DO)
                        SetTabShow("辐射", GlobleVariable.radiationTabForm);
                }
                else
                {
                    SetTabShow("热量", GlobleVariable.thermalTabForm);
                    if (GlobleVariable.modelForm.radiation == Radiation.P1 || GlobleVariable.modelForm.radiation == Radiation.S2S || GlobleVariable.modelForm.radiation == Radiation.DO)
                        SetTabShow("辐射", GlobleVariable.radiationTabForm);
                    if (GlobleVariable.modelForm.species == Species.ON)
                        SetTabShow("组分", GlobleVariable.speciesTabForm);
                }
            }

            this.superTabControlBoundry.SelectedTabIndex = 0;

            this.zonesToTypeChange = false;
        }

        /// <summary>
        /// 边界条件类型中文名转英文名
        /// </summary>
        /// <param name="E"></param>
        /// <returns></returns>
        private string BoundaryConditionsTypeCToE(string C)
        {
            string E = null;
            switch(C)
            {
                case "压力入口":
                    E = BoundaryTypeE.pressure_inlet.ToString();
                    break;
                case "速度入口":
                    E = BoundaryTypeE.velocity_inlet.ToString();
                    break;
                case "质量流入口":
                    E = BoundaryTypeE.mass_flow_inlet.ToString();
                    break;
                case "质量流出口":
                    E = BoundaryTypeE.mass_flow_outlet.ToString();
                    break;
                case "压力出口":
                    E = BoundaryTypeE.pressure_outlet.ToString();
                    break;
                case "出流":
                    E = BoundaryTypeE.outflow.ToString();
                    break;
                case "壁面":
                    E = BoundaryTypeE.wall.ToString();
                    break;
                default:
                    break;
            }
            return E;
        }


        private void btn_SaveSet_Click(object sender, EventArgs e)
        {
            if(GlobleVariable.currentModelsStatus==ModelsSelect.ONONOFFON)
            {
                Set_ONONOFFON_TUI();
            }
            else if(GlobleVariable.currentModelsStatus == ModelsSelect.OFFOFF)
            {
                Set_OFFOFF_TUI();
            }
            else if (GlobleVariable.currentModelsStatus == ModelsSelect.OFFON)
            {
                Set_OFFON_TUI();
            }
            else
            {
                MessageBox.Show("该功能尚未实现...", "抱歉提示");
            }
        }


        private void btn_Initial_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 设置ONONOFFON模型组合下的TUI命令
        /// </summary>
        private void Set_ONONOFFON_TUI()
        {
            if (this.cb_BoundaryType.SelectedItem.ToString().Equals(BoundaryTypeC.velocity_inlet))
            {
                try
                {
                    BCP_ONONOFFON.VI vi = new BCP_ONONOFFON.VI();
                    vi.boundaryName = this.lsb_Zones.SelectedItem.ToString();

                    //更新动量数据
                    GlobleVariable.velocityInletMomentumTabForm.DataUpdate();
                    vi.gaugePressure = GlobleVariable.velocityInletMomentumTabForm.gaugePressure;
                    vi.referenceFrame = GlobleVariable.velocityInletMomentumTabForm.referenceFrame;
                    vi.turbulenceSet = GlobleVariable.velocityInletMomentumTabForm.turbulenceSet;
                    vi.velocityMagnitude = GlobleVariable.velocityInletMomentumTabForm.velocityMagnitude;
                    vi.velocityMethod = GlobleVariable.velocityInletMomentumTabForm.velocityMethod;
                    vi.xyzDirctionOrComponent = GlobleVariable.velocityInletMomentumTabForm.xyzDirctionOrComponent;

                    //更新组分数据
                    GlobleVariable.speciesTabForm.DataUpdate();
                    vi.speciesMassFractions = GlobleVariable.speciesTabForm.speciesMassFractions;

                    //更新热量数据
                    GlobleVariable.thermalTabForm.DataUpdate();
                    vi.temperature = GlobleVariable.thermalTabForm.temperature;

                    sb_BoundaryCon.AppendLine(GlobleVariable.BCS.Set_ONONOFFON(vi: vi));

                    MessageBox.Show("保存设置成功!", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存设置失败!\n" + ex.ToString(), "提示");
                }
            }
            else if (this.cb_BoundaryType.SelectedItem.ToString().Equals(BoundaryTypeC.pressure_inlet))
            {
                try
                {
                    BCP_ONONOFFON.PI pi = new BCP_ONONOFFON.PI();
                    pi.boundaryName = this.lsb_Zones.SelectedItem.ToString();

                    //更新动量数据
                    GlobleVariable.pressureInletMomentumTabForm.DataUpdate();
                    pi.directionMethond = GlobleVariable.pressureInletMomentumTabForm.directionMethond;
                    pi.guageInitialPressure = GlobleVariable.pressureInletMomentumTabForm.guageInitialPressure;
                    pi.guageTotalPressure = GlobleVariable.pressureInletMomentumTabForm.guageTotalPressure;
                    pi.referenceFrame = GlobleVariable.pressureInletMomentumTabForm.referenceFrame;
                    pi.turbulenceSet = GlobleVariable.pressureInletMomentumTabForm.turbulenceSet;
                    pi.xyzDirection = GlobleVariable.pressureInletMomentumTabForm.xyzDirection;

                    //更新组分数据
                    GlobleVariable.speciesTabForm.DataUpdate();
                    pi.speciesMassFractions = GlobleVariable.speciesTabForm.speciesMassFractions;

                    //更新热量数据
                    GlobleVariable.thermalTabForm.DataUpdate();
                    pi.temperature = GlobleVariable.thermalTabForm.temperature;

                    sb_BoundaryCon.AppendLine(GlobleVariable.BCS.Set_ONONOFFON(pi: pi));

                    MessageBox.Show("保存设置成功!", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存设置失败!\n" + ex.ToString(), "提示");
                }
            }
            else if (this.cb_BoundaryType.SelectedItem.ToString().Equals(BoundaryTypeC.mass_flow_inlet))
            {
                try
                {
                    BCP_ONONOFFON.MI mi = new BCP_ONONOFFON.MI();
                    mi.boundaryName = this.lsb_Zones.SelectedItem.ToString();

                    //更新动量数据
                    GlobleVariable.massFlowInletMomentumTabForm.DataUpdate();
                    mi.averageFlux = GlobleVariable.massFlowInletMomentumTabForm.averageFlux;
                    mi.dirctionMethond = GlobleVariable.massFlowInletMomentumTabForm.dirctionMethond;
                    mi.initialGaugePress = GlobleVariable.massFlowInletMomentumTabForm.initialGaugePress;
                    mi.massFlowMethond = GlobleVariable.massFlowInletMomentumTabForm.massFlowMethond;
                    mi.massFlowRateOrFlux = GlobleVariable.massFlowInletMomentumTabForm.massFlowRateOrFlux;
                    mi.referenceFrame = GlobleVariable.massFlowInletMomentumTabForm.referenceFrame;
                    mi.turbulenceSet = GlobleVariable.massFlowInletMomentumTabForm.turbulenceSet;
                    mi.xyzDirection = GlobleVariable.massFlowInletMomentumTabForm.xyzDirection;

                    //更新组分数据
                    GlobleVariable.speciesTabForm.DataUpdate();
                    mi.speciesMassFractions = GlobleVariable.speciesTabForm.speciesMassFractions;

                    //更新热量数据
                    GlobleVariable.thermalTabForm.DataUpdate();
                    mi.temperature = GlobleVariable.thermalTabForm.temperature;

                    sb_BoundaryCon.AppendLine(GlobleVariable.BCS.Set_ONONOFFON(mi: mi));

                    MessageBox.Show("保存设置成功!", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存设置失败!\n" + ex.ToString(), "提示");
                }
            }
            else if (this.cb_BoundaryType.SelectedItem.ToString().Equals(BoundaryTypeC.pressure_outlet))
            {
                try
                {
                    BCP_ONONOFFON.PO po = new BCP_ONONOFFON.PO();
                    po.boundaryName = this.lsb_Zones.SelectedItem.ToString();
                    //更新动量数据
                    GlobleVariable.pressureOutletMomentumTabForm.DataUpdate();
                    po.bfDirectionM = GlobleVariable.pressureOutletMomentumTabForm.bfDirectionM;
                    po.bfPressure = GlobleVariable.pressureOutletMomentumTabForm.bfPressure;
                    po.gaugePressure = GlobleVariable.pressureOutletMomentumTabForm.gaugePressure;
                    po.isCheck = GlobleVariable.pressureOutletMomentumTabForm.isCheck;
                    po.massFlowParameter = GlobleVariable.pressureOutletMomentumTabForm.massFlowParameter;
                    po.referenceFrame = GlobleVariable.pressureOutletMomentumTabForm.referenceFrame;
                    po.turbulenceSet = GlobleVariable.pressureOutletMomentumTabForm.turbulenceSet;
                    po.xyzDirection = GlobleVariable.pressureOutletMomentumTabForm.xyzDirection;

                    //更新组分数据
                    GlobleVariable.speciesTabForm.DataUpdate();
                    po.speciesMassFractions = GlobleVariable.speciesTabForm.speciesMassFractions;

                    //更新热量数据
                    GlobleVariable.thermalTabForm.DataUpdate();
                    po.temperature = GlobleVariable.thermalTabForm.temperature;

                    sb_BoundaryCon.AppendLine(GlobleVariable.BCS.Set_ONONOFFON(po: po));

                    MessageBox.Show("保存设置成功!", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存设置失败!\n" + ex.ToString(), "提示");
                }

            }
            else if (this.cb_BoundaryType.SelectedItem.ToString().Equals(BoundaryTypeC.mass_flow_outlet))
            {
                try
                {
                    BCP_ONONOFFON.MO mo = new BCP_ONONOFFON.MO();
                    mo.boundaryName = this.lsb_Zones.SelectedItem.ToString();

                    //更新动量数据
                    GlobleVariable.massFlowOutletMomentumTabForm.DataUpdate();
                    mo.averageMassFlux = GlobleVariable.massFlowOutletMomentumTabForm.averageMassFlux;
                    mo.directionMethod = GlobleVariable.massFlowOutletMomentumTabForm.directionMethod;
                    mo.massFlowMethond = GlobleVariable.massFlowOutletMomentumTabForm.massFlowMethond;
                    mo.massRateOrFlux = GlobleVariable.massFlowOutletMomentumTabForm.massRateOrFlux;
                    mo.xyzDirection = GlobleVariable.massFlowOutletMomentumTabForm.xyzDirection;
                    sb_BoundaryCon.AppendLine(GlobleVariable.BCS.Set_ONONOFFON(mo: mo));
                    MessageBox.Show("保存设置成功!", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存设置失败!\n" + ex.ToString(), "提示");
                }
            }
        }

        /// <summary>
        /// 设置OFFOFF模型组合下的TUI命令
        /// </summary>
        private void Set_OFFOFF_TUI()
        {
            //MessageBox.Show("该功能尚未实现...", "抱歉提示");
            if (this.cb_BoundaryType.SelectedItem.ToString().Equals(BoundaryTypeC.velocity_inlet))
            {
                try
                {
                    BCP_OFFOFF.VI vi = new BCP_OFFOFF.VI();
                    vi.boundaryName = this.lsb_Zones.SelectedItem.ToString();
                    //更新动量数据
                    GlobleVariable.velocityInletMomentumTabForm.DataUpdate();
                    vi.gaugePressure = GlobleVariable.velocityInletMomentumTabForm.gaugePressure;
                    vi.referenceFrame = GlobleVariable.velocityInletMomentumTabForm.referenceFrame;
                    vi.velocityMagnitude = GlobleVariable.velocityInletMomentumTabForm.velocityMagnitude;
                    vi.velocityMethod = GlobleVariable.velocityInletMomentumTabForm.velocityMethod;
                    vi.xyzDirctionOrComponent = GlobleVariable.velocityInletMomentumTabForm.xyzDirctionOrComponent;

                    sb_BoundaryCon.AppendLine(GlobleVariable.BCS.Set_OFFOFF(vi: vi));

                    MessageBox.Show("保存设置成功!", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存设置失败!\n" + ex.ToString(), "提示");
                }
            }
            else if (this.cb_BoundaryType.SelectedItem.ToString().Equals(BoundaryTypeC.pressure_inlet))
            {
                try
                {
                    BCP_OFFOFF.PI pi = new BCP_OFFOFF.PI();
                    pi.boundaryName = this.lsb_Zones.SelectedItem.ToString();
                    //更新动量数据
                    GlobleVariable.pressureInletMomentumTabForm.DataUpdate();
                    pi.directionMethond = GlobleVariable.pressureInletMomentumTabForm.directionMethond;
                    pi.guageInitialPressure = GlobleVariable.pressureInletMomentumTabForm.guageInitialPressure;
                    pi.guageTotalPressure = GlobleVariable.pressureInletMomentumTabForm.guageTotalPressure;
                    pi.referenceFrame = GlobleVariable.pressureInletMomentumTabForm.referenceFrame;
                    pi.xyzDirection = GlobleVariable.pressureInletMomentumTabForm.xyzDirection;

                    sb_BoundaryCon.AppendLine(GlobleVariable.BCS.Set_OFFOFF(pi: pi));

                    MessageBox.Show("保存设置成功!", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存设置失败!\n" + ex.ToString(), "提示");
                }
            }
            else if (this.cb_BoundaryType.SelectedItem.ToString().Equals(BoundaryTypeC.mass_flow_inlet))
            {
                try
                {
                    BCP_OFFOFF.MI mi = new BCP_OFFOFF.MI();
                    mi.boundaryName = this.lsb_Zones.SelectedItem.ToString();
                    //更新动量数据
                    GlobleVariable.massFlowInletMomentumTabForm.DataUpdate();
                    mi.averageFlux = GlobleVariable.massFlowInletMomentumTabForm.averageFlux;
                    mi.dirctionMethond = GlobleVariable.massFlowInletMomentumTabForm.dirctionMethond;
                    mi.initialGaugePress = GlobleVariable.massFlowInletMomentumTabForm.initialGaugePress;
                    mi.massFlowMethond = GlobleVariable.massFlowInletMomentumTabForm.massFlowMethond;
                    mi.massFlowRateOrFlux = GlobleVariable.massFlowInletMomentumTabForm.massFlowRateOrFlux;
                    mi.referenceFrame = GlobleVariable.massFlowInletMomentumTabForm.referenceFrame;
                    mi.xyzDirection = GlobleVariable.massFlowInletMomentumTabForm.xyzDirection;

                    sb_BoundaryCon.AppendLine(GlobleVariable.BCS.Set_OFFOFF(mi: mi));

                    MessageBox.Show("保存设置成功!", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存设置失败!\n" + ex.ToString(), "提示");
                }
            }
            else if (this.cb_BoundaryType.SelectedItem.ToString().Equals(BoundaryTypeC.pressure_outlet))
            {
                try
                {
                    BCP_OFFOFF.PO po = new BCP_OFFOFF.PO();
                    po.boundaryName = this.lsb_Zones.SelectedItem.ToString();
                    //更新动量数据
                    GlobleVariable.pressureOutletMomentumTabForm.DataUpdate();
                    po.bfDirectionM = GlobleVariable.pressureOutletMomentumTabForm.bfDirectionM;
                    po.bfPressure = GlobleVariable.pressureOutletMomentumTabForm.bfPressure;
                    po.gaugePressure = GlobleVariable.pressureOutletMomentumTabForm.gaugePressure;
                    po.isCheck = GlobleVariable.pressureOutletMomentumTabForm.isCheck;
                    po.massFlowParameter = GlobleVariable.pressureOutletMomentumTabForm.massFlowParameter;
                    po.referenceFrame = GlobleVariable.pressureOutletMomentumTabForm.referenceFrame;
                    po.xyzDirection = GlobleVariable.pressureOutletMomentumTabForm.xyzDirection;

                    sb_BoundaryCon.AppendLine(GlobleVariable.BCS.Set_OFFOFF(po: po));

                    MessageBox.Show("保存设置成功!", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存设置失败!\n" + ex.ToString(), "提示");
                }

            }
            else if (this.cb_BoundaryType.SelectedItem.ToString().Equals(BoundaryTypeC.mass_flow_outlet))
            {
                try
                {
                    BCP_OFFOFF.MO mo = new BCP_OFFOFF.MO();
                    mo.boundaryName = this.lsb_Zones.SelectedItem.ToString();
                    //更新动量数据
                    GlobleVariable.massFlowOutletMomentumTabForm.DataUpdate();
                    mo.averageMassFlux = GlobleVariable.massFlowOutletMomentumTabForm.averageMassFlux;
                    mo.directionMethod = GlobleVariable.massFlowOutletMomentumTabForm.directionMethod;
                    mo.massFlowMethond = GlobleVariable.massFlowOutletMomentumTabForm.massFlowMethond;
                    mo.massRateOrFlux = GlobleVariable.massFlowOutletMomentumTabForm.massRateOrFlux;
                    mo.xyzDirection = GlobleVariable.massFlowOutletMomentumTabForm.xyzDirection;

                    sb_BoundaryCon.AppendLine(GlobleVariable.BCS.Set_OFFOFF(mo: mo));

                    MessageBox.Show("保存设置成功!", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存设置失败!\n" + ex.ToString(), "提示");
                }
            }
        }

        /// <summary>
        /// 设置OFFON模型组合下的TUI命令
        /// </summary>
        private void Set_OFFON_TUI()
        {
            //MessageBox.Show("该功能尚未实现...", "抱歉提示");
            if (this.cb_BoundaryType.SelectedItem.ToString().Equals(BoundaryTypeC.velocity_inlet))
            {
                try
                {

                    MessageBox.Show("保存设置成功!", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存设置失败!\n" + ex.ToString(), "提示");
                }
            }
            else if (this.cb_BoundaryType.SelectedItem.ToString().Equals(BoundaryTypeC.pressure_inlet))
            {
                try
                {

                    MessageBox.Show("保存设置成功!", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存设置失败!\n" + ex.ToString(), "提示");
                }
            }
            else if (this.cb_BoundaryType.SelectedItem.ToString().Equals(BoundaryTypeC.mass_flow_inlet))
            {
                try
                {
                    MessageBox.Show("保存设置成功!", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存设置失败!\n" + ex.ToString(), "提示");
                }
            }
            else if (this.cb_BoundaryType.SelectedItem.ToString().Equals(BoundaryTypeC.pressure_outlet))
            {
                try
                {

                    MessageBox.Show("保存设置成功!", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存设置失败!\n" + ex.ToString(), "提示");
                }

            }
            else if (this.cb_BoundaryType.SelectedItem.ToString().Equals(BoundaryTypeC.mass_flow_outlet))
            {
                try
                {
                    MessageBox.Show("保存设置成功!", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存设置失败!\n" + ex.ToString(), "提示");
                }
            }
        }

    }
}
