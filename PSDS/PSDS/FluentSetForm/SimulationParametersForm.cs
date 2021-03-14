using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobeCode.DataStruct;
using System.IO;
using GlobeCode.Common;
using GlobeCode.FluentClass;

namespace GlobeCode
{
    public partial class SimulationParametersForm : Office2007Form
    {
        public SimulationParametersForm()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SimulationParametersForm_Load(object sender, EventArgs e)
        {
            if(GlobleVariable.projectName!="")
            {
                this.tb_projectName.Text = GlobleVariable.projectName;
            }

            //主模块子窗口
            if(GlobleVariable.modelForm==null||GlobleVariable.projectName.Equals(""))
            {
                GlobleVariable.solverForm  = new SolverForm();
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
                if(result==DialogResult.Yes)
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

            SetTabShow("求解器设定", GlobleVariable.solverForm );
            SetTabShow("物理模型设定", GlobleVariable.modelForm);
            SetTabShow("材料性质设定", GlobleVariable.materialsForm);
            SetTabShow("边界条件设定", GlobleVariable.boundaryConditionsForm);
            SetTabShow("求解控制参数设定", GlobleVariable.methodsForm);
            SetTabShow("初始条件设定", GlobleVariable.initiallizationForm);
            SetTabShow("求解设定", GlobleVariable.runCalculationForm);
            SetTabShow("计算结果导出", GlobleVariable.calculationDataExportForm);

            superTabCtrMain.SelectedTabIndex = 0;
        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            if(GlobleVariable.projectName!="")
            {
                GlobleVariable.projectName = this.tb_projectName.Text.ToString();
            }
            if(GlobleVariable.projectName=="")
            {
                MessageBox.Show("请填写模拟项目名称", "提示");
                return;
            }
            if(GlobleVariable.solverForm .meshFilePath.Equals(""))
            {
                MessageBox.Show("请加载mesh文件！","提示");
                return;
            }

            bool isExistProject = false;
            DirectoryInfo di = new DirectoryInfo(GlobleVariable.DataDirectoryRoot);
            foreach(DirectoryInfo dri in di.GetDirectories())
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
                        //创建工程文件夹下存放计算结果数据的文件夹
                        Directory.CreateDirectory(GlobleVariable.DataDirectoryRoot + GlobleVariable.projectName + "\\" + GlobleVariable.ResultDataDirName);

                        GlobleVariable.streamWriter = new System.IO.StreamWriter(GlobleVariable.DataDirectoryRoot + GlobleVariable.projectName + "\\" + GlobleVariable.JournalDirName + "\\" + GlobleVariable.projectName + ".jou");
                        writeJournalFile();
                    }
                    isExistProject = true;
                    break;
                }
            }
           
            if(!isExistProject)
            {
                //创建空的工程文件夹
                Directory.CreateDirectory(GlobleVariable.DataDirectoryRoot + GlobleVariable.projectName);
                //创建工程文件夹下存放Journal的文件夹
                Directory.CreateDirectory(GlobleVariable.DataDirectoryRoot + GlobleVariable.projectName + "\\" + GlobleVariable.JournalDirName);
                //创建工程文件夹下存放计算结果数据的文件夹
                Directory.CreateDirectory(GlobleVariable.DataDirectoryRoot + GlobleVariable.projectName + "\\" + GlobleVariable.ResultDataDirName);

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
                journal.write_Materials(); 
                journal.write_Boundary();
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
            catch(Exception ex)
            {
                MessageBox.Show("模拟参数设置失败\n" + ex.Message.ToString(),"提示");
                GlobleVariable.streamWriter.Flush();
                GlobleVariable.streamWriter.Close();
            }
            

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
            SuperTabItem item = superTabCtrMain.CreateTab(tabName);
            //设置显示名和控件名
            item.Text = tabName;
            item.Name = tabName;
            //将子窗体添加到Tab中
            item.AttachedControl.Controls.Add(form);
            //选择该子窗体。
            superTabCtrMain.SelectedTab = item;
        }

        private void tb_projectName_TextChanged(object sender, EventArgs e)
        {
            if(!this.tb_projectName.Text.ToString().Equals(""))
                GlobleVariable.projectName = this.tb_projectName.Text.ToString();
        }

        //选型卡窗口之间执行的操作
        private void superTabCtrMain_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {
            if (superTabCtrMain.SelectedTab.Text.Equals("物理模型设定"))
            {
                GlobleVariable.modelForm.action();
            }

            if (superTabCtrMain.SelectedTab.Text.Equals("材料性质设定"))
            {
                GlobleVariable.materialsForm.action();//执行委托
            }

            if(superTabCtrMain.SelectedTab.Text.Equals("边界条件设定"))
            { 
                if (GlobleVariable.materialsForm.ModelsStatus == ModelsSelect.OFFOFF)
                    GlobleVariable.currentModelsStatus = ModelsSelect.OFFOFF;
                else if(GlobleVariable.materialsForm.ModelsStatus == ModelsSelect.OFFON)
                    GlobleVariable.currentModelsStatus = ModelsSelect.OFFON;
                else if (GlobleVariable.materialsForm.ModelsStatus == ModelsSelect.ONONOFFON)
                    GlobleVariable.currentModelsStatus = ModelsSelect.ONONOFFON;
                else
                {
                    MessageBox.Show("当前模型组合尚未开发，敬请等待...","抱歉提示");
                    this.superTabCtrMain.SelectedTabIndex -= 1;
                    return;
                }
                GlobleVariable.boundaryConditionsForm.action();
            }

            if(superTabCtrMain.SelectedTab.Text.Equals("求解设定"))
            {
                GlobleVariable.runCalculationForm.action();
            }

            if(superTabCtrMain.SelectedTab.Text.Equals("计算结果导出"))
            {
                GlobleVariable.calculationDataExportForm.action();
            }
        }
    }
}
