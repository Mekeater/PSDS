using DevComponents.DotNetBar;
using GlobeCode.Common;
using GlobeCode.DataStruct;
using GlobeCode.FluentClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobeCode
{
    public partial class ProfileSimulationParametersForm : Office2007Form
    {
        public ProfileSimulationParametersForm()
        {
            InitializeComponent();
        }

        private void ProfileSimulationParametersForm_Load(object sender, EventArgs e)
        {
            if (GlobleVariable.projectName != "")
            {
                this.tb_projectName.Text = GlobleVariable.projectName;
            }

            //主模块子窗口
            if (GlobleVariable.modelForm == null || GlobleVariable.projectName.Equals(""))
            {
                GlobleVariable.solverForm = new SolverForm();
                GlobleVariable.modelForm = new ModelForm();
                GlobleVariable.materialsForm = new MaterialsForm();
                GlobleVariable.boundaryConditionsForm = new BoundaryConditionsForm();
                GlobleVariable.methodsForm = new MethodsForm();
                GlobleVariable.initiallizationForm = new InitiallizationForm();
                GlobleVariable.runCalculationForm = new RunCalculationForm();
                GlobleVariable.calculationDataExportForm = new CalculationDataExportForm();
            }
            else
            {
                DialogResult result = MessageBox.Show("存在工程参数，是否初始化工程参数？", "重要提示", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    GlobleVariable.solverForm = new SolverForm();
                    GlobleVariable.modelForm = new ModelForm();
                    GlobleVariable.materialsForm = new MaterialsForm();
                    GlobleVariable.boundaryConditionsForm = new BoundaryConditionsForm();
                    GlobleVariable.methodsForm = new MethodsForm();
                    GlobleVariable.initiallizationForm = new InitiallizationForm();
                    GlobleVariable.runCalculationForm = new RunCalculationForm();
                    GlobleVariable.calculationDataExportForm = new CalculationDataExportForm();
                }
            }

            this.cb_pollutionMatrial.Items.Clear();
            this.cb_pollutionMatrial.Items.AddRange(new string[] { "氯气", "硫化氢", "二氧化碳", "一氧化碳", "三氧化硫", "二氧化硫", "二氧化氮", "臭氧", "氨气" });

            /***********************************************************************/
            /*求解器设定默认参数*/
            /***********************************************************************/
            GlobleVariable.solverForm.solverType = SolverType.PressureBased;
            GlobleVariable.solverForm.velocityFormulation = VelocityFormulation.Absolute;
            GlobleVariable.solverForm.isGravity = true;

            /***********************************************************************/
            /*物理模型设定默认参数*/
            /***********************************************************************/
            GlobleVariable.modelForm.energy = Energy.ON;
            GlobleVariable.modelForm.viscous = Viscous.k_eStandard;
            GlobleVariable.modelForm.radiation = Radiation.OFF;
            GlobleVariable.modelForm.species = Species.ON;

            /***********************************************************************/
            /*边界条件设定默认参数*/
            /***********************************************************************/
            sb_BoundaryCon = new StringBuilder();

            /***********************************************************************/
            /*求解控制参数设定默认参数*/
            /***********************************************************************/
            GlobleVariable.methodsForm.pressure_VelocityCoupling = Pressure_VelocityCoupling.SIMPLE;

            /***********************************************************************/
            /*初始条件设定默认参数*/
            /***********************************************************************/
            GlobleVariable.initiallizationForm.intializeMethods = IntializeMethods.Hybrid;

        }

        private void tb_projectName_TextChanged(object sender, EventArgs e)
        {
            if (!this.tb_projectName.Text.ToString().Equals(""))
                GlobleVariable.projectName = this.tb_projectName.Text.ToString();
        }

        #region 求解器设置自定义参数

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "mesh文件加载";
            openFileDialog.Filter = "mesh文件(*.msh)|*.msh";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tb_MeshFile.Text = openFileDialog.FileName;
                GlobleVariable.solverForm.meshFilePath = openFileDialog.FileName;

                //添加边界条件
                List<string[]> boudarys = MeshInfoClass.GetBoundarys(GlobleVariable.solverForm.meshFilePath);
                this.cb_airInletZone.Items.Clear();
                this.cb_pollutionZone.Items.Clear();
                foreach (string[] boundary in boudarys)
                {
                    if (boundary[0].Equals(BoundaryTypeE.velocity_inlet.ToString()))
                        this.cb_airInletZone.Items.Add(boundary[1]);
                    else if (boundary[0].Equals(BoundaryTypeE.mass_flow_inlet.ToString()))
                        this.cb_pollutionZone.Items.Add(boundary[1]);
                }
            }
        }

        private void ckb_TimeType_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckb_TimeType.Checked)
                GlobleVariable.solverForm.timeType = TimeType.Transient;
            else
                GlobleVariable.solverForm.timeType = TimeType.Steady;
        }

        #endregion

        #region journal文件内容写入
        private void btn_Sure_Click(object sender, EventArgs e)
        {
            if (GlobleVariable.projectName != "")
            {
                GlobleVariable.projectName = this.tb_projectName.Text.ToString();
            }
            if (GlobleVariable.projectName == "")
            {
                MessageBox.Show("请填写模拟项目名称", "提示");
                return;
            }
            if (GlobleVariable.solverForm.meshFilePath.Equals(""))
            {
                MessageBox.Show("请加载mesh文件！", "提示");
                return;
            }

            bool isExistProject = false;
            DirectoryInfo di = new DirectoryInfo(GlobleVariable.DataDirectoryRoot);
            foreach (DirectoryInfo dri in di.GetDirectories())
            {
                if ((GlobleVariable.projectName).Equals(dri.Name))
                {
                    DialogResult dr = MessageBox.Show(GlobleVariable.projectName + "工程已存在，是否替换数据？", "提示", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        //删除原有的工程文件夹
                        Utility.DeleteDir(GlobleVariable.DataDirectoryRoot + GlobleVariable.projectName);
                        //创建空的工程文件夹
                        Directory.CreateDirectory(GlobleVariable.DataDirectoryRoot + GlobleVariable.projectName);
                        //创建工程文件夹下存放Journal的文件夹
                        Directory.CreateDirectory(GlobleVariable.DataDirectoryRoot + GlobleVariable.projectName + "\\" + GlobleVariable.JournalDirName);
                        //创建工程文件夹下存放计算结果数据(文本数据)的文件夹
                        Directory.CreateDirectory(GlobleVariable.DataDirectoryRoot + GlobleVariable.projectName + "\\" + GlobleVariable.ResultDataDirName);
                        //创建工程文件夹下存放计算结果数据（图片数据）的文件夹
                        Directory.CreateDirectory(GlobleVariable.DataDirectoryRoot + GlobleVariable.projectName + "\\" + GlobleVariable.PicDataDirName);

                        GlobleVariable.streamWriter = new System.IO.StreamWriter(GlobleVariable.DataDirectoryRoot + GlobleVariable.projectName + "\\" + GlobleVariable.JournalDirName + "\\" + GlobleVariable.projectName + ".jou");
                        writeJournalFile();
                    }
                    isExistProject = true;
                    break;
                }
            }

            if (!isExistProject)
            {
                //创建空的工程文件夹
                Directory.CreateDirectory(GlobleVariable.DataDirectoryRoot + GlobleVariable.projectName);
                //创建工程文件夹下存放Journal的文件夹
                Directory.CreateDirectory(GlobleVariable.DataDirectoryRoot + GlobleVariable.projectName + "\\" + GlobleVariable.JournalDirName);
                //创建工程文件夹下存放计算结果数据(文本数据)的文件夹
                Directory.CreateDirectory(GlobleVariable.DataDirectoryRoot + GlobleVariable.projectName + "\\" + GlobleVariable.ResultDataDirName);
                //创建工程文件夹下存放计算结果数据（图片数据）的文件夹
                Directory.CreateDirectory(GlobleVariable.DataDirectoryRoot + GlobleVariable.projectName + "\\" + GlobleVariable.PicDataDirName);

                GlobleVariable.streamWriter = new System.IO.StreamWriter(GlobleVariable.DataDirectoryRoot + GlobleVariable.projectName + "\\" + GlobleVariable.JournalDirName + "\\" + GlobleVariable.projectName + ".jou");
                writeJournalFile();
            }
        }

        /// <summary>
        /// 写jornal文件
        /// </summary>
        private void writeJournalFile()
        {
            try
            {
                GlobleVariable.streamWriter.WriteLine("/file/set-tui-version \"19.1\"");
                IJournal journal = new JournalClass();
                journal.write_Solver();
                journal.write_Model();
                write_Materials();
                write_Boundary();
                journal.write_Method();
                journal.write_Initiallization();
                journal.write_Calculation();
                journal.write_ResultDataExport();

                //退出Fluent
                GlobleVariable.streamWriter.WriteLine("exit");

                GlobleVariable.streamWriter.Flush();
                GlobleVariable.streamWriter.Close();
                MessageBox.Show("模拟参数设置完成!", "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show("模拟参数设置失败\n" + ex.Message.ToString(), "提示");
                GlobleVariable.streamWriter.Flush();
                GlobleVariable.streamWriter.Close();
            }
        }

        /// <summary>
        /// 特定材料写出
        /// </summary>
        private void write_Materials()
        {
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Materials\"))");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Materials\"))");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"NavigationPane*List_Tree1\")");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Materials\"))");

            //添加流体材料
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Materials*Table1*ButtonBox2*PushButton1(Create/Edit)\")");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Create/Edit Materials*Table1*Frame1*Frame2*ButtonBox2*PushButton1(Fluent Database)\")");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Fluent Database Materials*Table1*Frame1*Frame3*DropDownList1(Material Type)\" '( 1))");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Fluent Database Materials*Table1*Frame1*Frame3*DropDownList1(Material Type)\")");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Fluent Database Materials*Table1*Frame1*Frame3*ToggleBox2(Order Materials by)*Chemical Formula\" #t)");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Fluent Database Materials*Table1*Frame1*Frame3*ToggleBox2(Order Materials by)*Chemical Formula\")");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Fluent Database Materials*Table1*Frame1*List1(Materials)\" '( " + GetMatrialIndex(this.cb_pollutionMatrial.SelectedItem.ToString()) + "))");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Fluent Database Materials*Table1*Frame1*List1(Materials)\")");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Fluent Database Materials*PanelButtons*PushButton6(Copy)\")");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Fluent Database Materials*PanelButtons*PushButton1(Close)\")");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Create/Edit Materials*PanelButtons*PushButton1(Close)\")");

            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Materials*Table1*ButtonBox2*PushButton1(Create/Edit)\")");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Create/Edit Materials*PushButton3(Edit)\")");

            specieRemoveGUI("n2");
            specieRemoveGUI("o2");
            specieAddGUI(GetMatrialFullNameE(this.cb_pollutionMatrial.SelectedItem.ToString()));
            specieRemoveGUI("h2o))");
            specieAddGUI("air");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Species*PanelButtons*PushButton1(OK)\")");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Create/Edit Materials*PanelButtons*PushButton1(Close)\")");

            GlobleVariable.materialsForm.ListBox_Species = new ListBoxAdv();
            GlobleVariable.materialsForm.ListBox_Species.Items.Add(this.cb_pollutionMatrial.SelectedItem.ToString());
            GlobleVariable.materialsForm.ListBox_Species.Items.Add("空气");

        }

        /// <summary>
        /// 组分移除GUI
        /// </summary>
        /// <param name="specieName">移除组名称</param>
        private void specieRemoveGUI(string specieName)
        {
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Species*Table2*Frame2*List1(Selected Species)\" '( "+specieName+"))");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Species*Table2*Frame2*List1(Selected Species)\")");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Species*Table2*Frame2*ButtonBox2*PushButton2(Remove)\")");
        }

        /// <summary>
        /// 组分添加GUI
        /// </summary>
        /// <param name="specieName">添加组分名称</param>
        private void specieAddGUI(string specieName)
        {
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Species*Table2*List1(Available Materials)\" '( \""+specieName+"\"))");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Species*Table2*List1(Available Materials)\")");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Species*Table2*Frame2*ButtonBox2*PushButton1(Add)\")"); 
        }

        /// <summary>
        /// 获取中文材料名的英文全称
        /// </summary>
        /// <param name="matrilName"></param>
        /// <returns></returns>
        private string GetMatrialFullNameE(string materialName)
        {
            string matrialFullNameE = "";
            switch (materialName)
            {
                case "臭氧":
                    matrialFullNameE = MaterialsFullName.o3_full;
                    break;
                case "二氧化氮":
                    matrialFullNameE = MaterialsFullName.no2_full;
                    break;
                case "二氧化硫":
                    matrialFullNameE = MaterialsFullName.so2_full;
                    break;
                case "三氧化硫":
                    matrialFullNameE = MaterialsFullName.so3_full;
                    break;
                case "一氧化碳":
                    matrialFullNameE = MaterialsFullName.co_full;
                    break;
                case "二氧化碳":
                    matrialFullNameE = MaterialsFullName.co2_full;
                    break;
                case "硫化氢":
                    matrialFullNameE = MaterialsFullName.h2s_full;
                    break;
                case "水":
                    matrialFullNameE = MaterialsFullName.h2o_full;
                    break;
                case "氨气":
                    matrialFullNameE = MaterialsFullName.nh3_full;
                    break;
                case "氧气":
                    matrialFullNameE = MaterialsFullName.o2_full;
                    break;
                case "氮气":
                    matrialFullNameE = MaterialsFullName.n2_full;
                    break;
                case "空气":
                    matrialFullNameE = MaterialsFullName.air_full;
                    break;
                case "氯气":
                    matrialFullNameE = MaterialsFullName.cl2_full;
                    break;
                default:
                    break;
            }
            return matrialFullNameE;
        }

        /// <summary>
        /// 获取指定材料名的索引值
        /// </summary>
        /// <param name="matrialName"></param>
        /// <returns>材料名</returns>
        private string GetMatrialIndex(string matrialName)
        {
            string matrialIndex = "";
            switch (matrialName)
            {
                case "氨气":
                    matrialIndex =((int)Materials.nh3).ToString();
                    break;
                case "臭氧":
                    matrialIndex = ((int)Materials.o3).ToString();
                    break;
                case "二氧化氮":
                    matrialIndex = ((int)Materials.no2).ToString();
                    break;
                case "二氧化硫":
                    matrialIndex = ((int)Materials.so2).ToString();
                    break;
                case "三氧化硫":
                    matrialIndex = ((int)Materials.so3).ToString();
                    break;
                case "一氧化碳":
                    matrialIndex = ((int)Materials.co).ToString();
                    break;
                case "二氧化碳":
                    matrialIndex = ((int)Materials.co2).ToString();
                    break;
                case "硫化氢":
                    matrialIndex = ((int)Materials.h2s).ToString();
                    break;
                case "水":
                    matrialIndex = ((int)Materials.h2o).ToString();
                    break;
                case "氧气":
                    matrialIndex = ((int)Materials.o2).ToString();
                    break;
                case "氮气":
                    matrialIndex = ((int)Materials.n2).ToString();
                    break;
                case "氯气":
                    matrialIndex = ((int)Materials.cl2).ToString();
                    break;
            }
            return matrialIndex;
        }

        /// <summary>
        /// 特定边界条件写出
        /// </summary>
        private void write_Boundary()
        {
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Boundary Conditions\"))");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Boundary Conditions\"))");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-activate-item \"NavigationPane*List_Tree1\")");
            GlobleVariable.streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Boundary Conditions\"))");

            string[] boundaryTUIs = (sb_BoundaryCon.ToString()).Split('\n');
            foreach (string boundaryTUI in boundaryTUIs)
                if (!boundaryTUI.Equals(""))
                    GlobleVariable.streamWriter.WriteLine(boundaryTUI.Substring(0, boundaryTUI.Length - 1));
        }

        #endregion

        #region 边界条件设定自定义参数
        public StringBuilder sb_BoundaryCon;
        private void btn_SaveSpeedInlet_Click(object sender, EventArgs e)
        {
            try
            {
                BCP_ONONOFFON.VI vi = new BCP_ONONOFFON.VI();
                vi.boundaryName = this.cb_airInletZone.SelectedItem.ToString();

                //更新动量数据
                vi.gaugePressure ="0";
                vi.referenceFrame = ReferenceFrame.Absolute;

                TurbulenceSet turbulenceSet = new TurbulenceSet();
                turbulenceSet.turbulenceOrder = TurbulenceOrder.SecondOrder;
                turbulenceSet.secondOrder_TurbulenceMethod = SecondOrder_TurbulenceMethod.IntensityAndViscosityRatio;
                turbulenceSet.TurbulenceP1 = "5";
                turbulenceSet.TurbulenceP2 = "10";
                vi.turbulenceSet = turbulenceSet;
                vi.velocityMagnitude = this.tb_airSpeed.Text.ToString();
                vi.velocityMethod = VelocityMethod.Magnitude_NormalToBoundary;

                //更新组分数据
                vi.speciesMassFractions = new List<string> { "0", "1" };

                //更新热量数据
                vi.temperature = "300";

                sb_BoundaryCon.AppendLine(GlobleVariable.BCS.Set_ONONOFFON(vi: vi));

                MessageBox.Show("保存设置成功!", "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存设置失败!\n" + ex.ToString(), "提示");
            }
        }

        private void btn_SaveMassFlowInlet_Click(object sender, EventArgs e)
        {
            try
            {
                BCP_ONONOFFON.MI mi = new BCP_ONONOFFON.MI();
                mi.boundaryName = this.cb_pollutionZone.SelectedItem.ToString();

                //更新动量数据
                mi.dirctionMethond = PI_DirectionMethond.NormalToBoundary;
                mi.initialGaugePress = "0";
                mi.massFlowMethond = MassFlowMethond.MassFlowFlux;
                mi.massFlowRateOrFlux = this.tb_pollutionLoad.Text.ToString();
                mi.referenceFrame = ReferenceFrame.Absolute;

                TurbulenceSet turbulenceSet = new TurbulenceSet();
                turbulenceSet.turbulenceOrder = TurbulenceOrder.SecondOrder;
                turbulenceSet.secondOrder_TurbulenceMethod = SecondOrder_TurbulenceMethod.IntensityAndViscosityRatio;
                turbulenceSet.TurbulenceP1 = "5";
                turbulenceSet.TurbulenceP2 = "10";

                mi.turbulenceSet = turbulenceSet;
                

                //更新组分数据
                mi.speciesMassFractions = new List<string> {"1","0" };

                //更新热量数据
                mi.temperature = "300";

                sb_BoundaryCon.AppendLine(GlobleVariable.BCS.Set_ONONOFFON(mi: mi));

                MessageBox.Show("保存设置成功!", "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存设置失败!\n" + ex.ToString(), "提示");
            }
        }

        #endregion

        #region 求解设定自定义参数
        private void btn_Solve_Click(object sender, EventArgs e)
        {
            GlobleVariable.runCalculationForm.StartPosition = FormStartPosition.CenterScreen;
            GlobleVariable.runCalculationForm.Text = "迭代求解";
            GlobleVariable.runCalculationForm.FormBorderStyle = FormBorderStyle.Sizable;
            GlobleVariable.runCalculationForm.ShowDialog();
        }
        #endregion

        #region 计算结果导出自定义参数
        private void buttonX1_Click(object sender, EventArgs e)
        {
            GlobleVariable.calculationDataExportForm.StartPosition = FormStartPosition.CenterScreen;
            GlobleVariable.calculationDataExportForm.Text = "计算结果导出";
            GlobleVariable.calculationDataExportForm.FormBorderStyle= FormBorderStyle.Sizable;
            GlobleVariable.boundaryConditionsForm.boundarys = MeshInfoClass.GetBoundarys(GlobleVariable.solverForm.meshFilePath);
            GlobleVariable.calculationDataExportForm.ShowDialog();
        }
        #endregion

        private void tb_pollutionLoad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
