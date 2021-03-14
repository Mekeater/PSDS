using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobeCode.DataStruct;
using GlobeCode.FluentClass;

namespace GlobeCode.Common
{
    /// <summary>
    /// 生成journal文件中的Mesh部分，实现IJournal接口
    /// </summary>
    public class JournalClass : GlobleVariable, IJournal
    {
        public void write_Boundary()
        {
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Boundary Conditions\"))");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Boundary Conditions\"))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"NavigationPane*List_Tree1\")");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Boundary Conditions\"))");

            string[] boundaryTUIs = (boundaryConditionsForm.sb_BoundaryCon.ToString()).Split('\n');
            foreach (string boundaryTUI in boundaryTUIs)
                if(!boundaryTUI.Equals(""))
                    streamWriter.WriteLine(boundaryTUI.Substring(0, boundaryTUI.Length - 1));
        }

        public void write_Calculation()
        {
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Solution|Run Calculation\"))");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Solution|Run Calculation\"))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"NavigationPane*List_Tree1\")");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Solution|Run Calculation\"))");
            if(GlobleVariable.solverForm.timeType==TimeType.Steady)
            {
                if (!GlobleVariable.runCalculationForm.numberOFIterations.Equals(""))
                {
                    streamWriter.WriteLine("(cx-gui-do cx-set-integer-entry \"Run Calculation*Table1*IntegerEntry10(Number of Iterations)\" " + GlobleVariable.runCalculationForm.numberOFIterations + ")");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Run Calculation*Table1*IntegerEntry10(Number of Iterations)\")");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Run Calculation*Table1*PushButton22(Calculate)\")");
                }
            }
            else
            {
                runCalculationForm.DataUpdate();
                streamWriter.WriteLine("(cx-gui-do cx-set-real-entry-list \"Run Calculation*Table1*Table7*RealEntry1(Time Step Size)\" '( " + runCalculationForm.m_TimeStepingSize + "))");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Run Calculation*Table1*Table7*RealEntry1(Time Step Size)\")");
                streamWriter.WriteLine("(cx-gui-do cx-set-integer-entry \"Run Calculation*Table1*Table7*IntegerEntry2(Number of Time Steps)\" " + runCalculationForm.m_TimeStepingNumber + ")");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Run Calculation*Table1*Table7*IntegerEntry2(Number of Time Steps)\")");
                streamWriter.WriteLine("(cx-gui-do cx-set-integer-entry \"Run Calculation*Table1*IntegerEntry10(Number of Iterations)\" " + runCalculationForm.m_MaxIterations_TimeStep + ")");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Run Calculation*Table1*IntegerEntry10(Number of Iterations)\")");
                if (runCalculationForm.m_timeStepingMethod==TimeStepingMethod.Fixed)
                {
                    streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Run Calculation*Table1*Table6*DropDownList1(Time Stepping Method)\" '( 0))");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Run Calculation*Table1*Table6*DropDownList1(Time Stepping Method)\")");
                }
                else
                {
                    streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Run Calculation*Table1*Table6*DropDownList1(Time Stepping Method)\" '( 1))");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Run Calculation*Table1*Table6*DropDownList1(Time Stepping Method)\")");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Run Calculation*Table1*Table6*PushButton2(Settings)\")");
                    streamWriter.WriteLine("(cx-gui-do cx-set-real-entry-list \"Adaptive Time Step Settings*Table1*RealEntry2(Truncation Error Tolerance)\" '( "+runCalculationForm.m_ErrorTolerance+"))");
                    streamWriter.WriteLine("(cx-gui-do cx-set-real-entry-list \"Adaptive Time Step Settings*Table1*RealEntry3(Ending Time)\" '( "+runCalculationForm.m_EndTime+"))");
                    streamWriter.WriteLine("(cx-gui-do cx-set-real-entry-list \"Adaptive Time Step Settings*Table1*RealEntry4(Minimum Time Step Size)\" '( "+runCalculationForm.m_MinTimeStep+"))");
                    streamWriter.WriteLine("(cx-gui-do cx-set-real-entry-list \"Adaptive Time Step Settings*Table1*RealEntry5(Maximum Time Step Size)\" '( "+runCalculationForm.m_MaxTimeStep+"))");
                    streamWriter.WriteLine("(cx-gui-do cx-set-real-entry-list \"Adaptive Time Step Settings*Table1*RealEntry6(Minimum Step Change Factor)\" '( "+runCalculationForm.m_MinTimeStepChangeFactor+"))");
                    streamWriter.WriteLine("(cx-gui-do cx-set-real-entry-list \"Adaptive Time Step Settings*Table1*RealEntry7(Maximum Step Change Factor)\" '( "+runCalculationForm.m_MaxTimeStepChangeFactor+"))");
                    streamWriter.WriteLine("(cx-gui-do cx-set-integer-entry \"Adaptive Time Step Settings*Table1*IntegerEntry8(Number of Fixed Time Steps)\" "+runCalculationForm.m_TimeStepFixedNum+")");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Adaptive Time Step Settings*Table1*IntegerEntry8(Number of Fixed Time Steps)\")");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Adaptive Time Step Settings*PanelButtons*PushButton1(OK)\")");
                }
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Run Calculation*Table1*PushButton22(Calculate)\")");
            }
        }

        public void write_Initiallization()
        {
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Solution|Initialization\"))");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Solution|Initialization\"))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"NavigationPane*List_Tree1\")");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Solution|Initialization\"))");
            if (initiallizationForm.intializeMethods == IntializeMethods.Hybrid)
            {
                streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Solution Initialization*Table1*ToggleBox3(Initialization Methods)*Hybrid  Initialization\" #t)");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Solution Initialization*Table1*ToggleBox3(Initialization Methods)*Hybrid  Initialization\")");
            }
            else
            {
                streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Solution Initialization*Table1*ToggleBox3(Initialization Methods)*Standard Initialization\" #t)");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Solution Initialization*Table1*ToggleBox3(Initialization Methods)*Standard Initialization\")");
            }
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Solution Initialization*Table1*ButtonBox10*PushButton2(Initialize)\")");

            //如果是不定常流(瞬态)，则需要设置随时间保存数据
            if(solverForm.timeType==TimeType.Transient)
            {
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Ribbon*Frame1*Frame6(Postprocessing)*Table1*Table3(Surface)*PushButton1(Create)\")");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"MenuBar*PopupMenuCreate*Iso-Surface...\")");
                string[] surfaces = (calculationDataExportForm.sb_CreateSurface.ToString()).Split('\n');
                for (int i = 0; i < surfaces.Length - 1; i++)
                {
                    streamWriter.WriteLine(surfaces[i].Substring(0, surfaces[i].Length - 1));
                }
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Iso-Surface*PanelButtons*PushButton2(Cancel)\")");

                streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Solution|Calculation Activities\"))");
                streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Solution|Calculation Activities\"))");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"NavigationPane*List_Tree1\")");
                streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Solution|Calculation Activities\"))");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Calculation Activities*ButtonBox4*PushButton1(Create)\")");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"MenuBar*PopupMenuAutomaticExport*Solution Data Export...\")");

                /***********************************************/
                //写入文本数据命名
                /***********************************************/

                streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Automatic Export*Table1*Table2*DropDownList1(File Type)\" '( 1))");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Automatic Export*Table1*Table2*DropDownList1(File Type)\")");

                string surfacesJou = "(cx-gui-do cx-set-list-selections \"Automatic Export*Table1*List4(Surfaces)\" '( ";
                for (int i = 0; i < calculationDataExportForm.surfacesName.Count; i++)
                {
                    surfacesJou += "\"" + calculationDataExportForm.surfacesName[i] + "\" ";
                }
                surfacesJou = surfacesJou.Substring(0, surfacesJou.Length - 1);
                surfacesJou += "))";
                streamWriter.WriteLine(surfacesJou);
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Automatic Export*Table1*List4(Surfaces)\")");

                string quantitiesJou = "(cx-gui-do cx-set-list-selections \"Automatic Export*Table1*Table5*List1(Quantities)\" '( ";
                //静压
                quantitiesJou += "\"Static Pressure\" ";
                //总压
                quantitiesJou += "\"Total Pressure\" ";
                //速度大小
                quantitiesJou += "\"Velocity Magnitude\" ";
                //速度角度
                quantitiesJou += "\"Velocity Angle\" ";
                //各组分质量分数
                quantitiesJou += "\"Total Pressure\" ";

                foreach (object o in materialsForm.ListBox_Species.Items)
                {
                    quantitiesJou += "\"Mass fraction of " + materialsForm.MaterialsCToE(o.ToString()) + "\" ";
                }
                quantitiesJou = quantitiesJou.Substring(0, quantitiesJou.Length - 1);
                quantitiesJou += "))";
                streamWriter.WriteLine(quantitiesJou);
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Automatic Export*Table1*Table5*List1(Quantities)\")");

                string executablePath = Utility.ExecutablePath();
                executablePath = executablePath.Substring(0, executablePath.LastIndexOf("PSDS"));
                string DataExportPath = executablePath.Substring(0, executablePath.LastIndexOf("PSDS")) + "PSDS\\";
                DataExportPath += "ProjectData\\" + GlobleVariable.projectName + "\\" + GlobleVariable.ResultDataDirName + "\\" + projectName;
                streamWriter.WriteLine("(cx-gui-do cx-set-text-entry \"Automatic Export*Table1*Table7*Table1*TextEntry1(File Name)\" \""+ DataExportPath + "\")");
                streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Automatic Export*Table1*Table7*DropDownList2(Append File Name with)\" '( 1))");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Automatic Export*Table1*Table7*DropDownList2(Append File Name with)\")");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Automatic Export*PanelButtons*PushButton1(OK)\")");

                /***********************************************/
                //写入图片数据命令
                /***********************************************/

                animationNames = new List<string>();
                //生成组分云图（其它类型图片待生成）
                string viewsPath = Utility.SourceCodeDir()+"//TestData/views.vw";
                int temp = 2;//第几个组分的标记（从2开始计）
                foreach (object o in materialsForm.ListBox_Species.Items)
                {
                    quantitiesJou += "\"Mass fraction of " + materialsForm.MaterialsCToE(o.ToString()) + "\" ";
                    //生成所有截面对应云图
                    for (int i = 0; i < calculationDataExportForm.surfacesName.Count; i++)
                    {
                        surfacesJou += "\"" + calculationDataExportForm.surfacesName[i] + "\" ";
                        if (temp == 2)
                            animationNames.Add(savePicSet(materialsForm.MaterialsCToE(o.ToString()), calculationDataExportForm.surfacesName[i], true, viewsPath, "horizontal-view", temp + "0"));
                        else
                            animationNames.Add(savePicSet(materialsForm.MaterialsCToE(o.ToString()), calculationDataExportForm.surfacesName[i], false, viewsPath, "horizontal-view", temp + "0"));
                    }
                    temp++;
                }
            }
        }

        public void write_Materials()
        {
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Materials\"))");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Materials\"))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"NavigationPane*List_Tree1\")");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Materials\"))");

            //添加流体材料

            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Materials*Table1*ButtonBox2*PushButton1(Create/Edit)\")");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Create/Edit Materials*Table1*Frame1*Frame2*ButtonBox2*PushButton1(Fluent Database)\")");
            if(modelForm.species==Species.ON)
            {
                streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Fluent Database Materials*Table1*Frame1*Frame3*DropDownList1(Material Type)\" '( 1))");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Fluent Database Materials*Table1*Frame1*Frame3*DropDownList1(Material Type)\")");
            }
            streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Fluent Database Materials*Table1*Frame1*Frame3*ToggleBox2(Order Materials by)*Chemical Formula\" #t)");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Fluent Database Materials*Table1*Frame1*Frame3*ToggleBox2(Order Materials by)*Chemical Formula\")");

            if (materialsForm.matrialsIndex.Count != 0)
            {
                string matrialsIndex = "(";
                Parallel.For(0, materialsForm.matrialsIndex.Count, (i) =>
                {
                    matrialsIndex += " " + materialsForm.matrialsIndex[i] + " ";
                });
                matrialsIndex = matrialsIndex.Substring(0, matrialsIndex.Length - 1);
                matrialsIndex += "))";
                streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Fluent Database Materials*Table1*Frame1*List1(Materials)\" '" + matrialsIndex);
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Fluent Database Materials*Table1*Frame1*List1(Materials)\")");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Fluent Database Materials*PanelButtons*PushButton6(Copy)\")");
            }
            
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Fluent Database Materials*PanelButtons*PushButton1(Close)\")");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Create/Edit Materials*PanelButtons*PushButton1(Close)\")");

            //选择组分材料
            if (modelForm.species == Species.ON)
            {
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Materials*Table1*ButtonBox2*PushButton1(Create/Edit)\")");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Create/Edit Materials*PushButton3(Edit)\")");

                string[] speciesMaterials = (materialsForm.sb_Species.ToString()).Split('\n');
                for (int i = 0; i < speciesMaterials.Length - 1; i++)//如果命令行非常多，要想办法并行优化速度（待优化）
                {
                    streamWriter.WriteLine(speciesMaterials[i].Substring(0, speciesMaterials[i].Length - 1));
                }
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Species*PanelButtons*PushButton1(OK)\")");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Create/Edit Materials*PanelButtons*PushButton1(Close)\")");
            }
        }

        public void write_Solver()
        {
            //mesh格网
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"MenuBar*ReadSubMenu*Mesh...\")");
            streamWriter.WriteLine("(cx-gui-do cx-set-file-dialog-entries \"Select File\" '(\""+solverForm .meshFilePath+"\") \"Mesh Files(*.msh* *.MSH* )\")");

            //求解器类型
            if (solverForm.solverType==SolverType.PressureBased)
            {
                streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"General*Table1*Table2(Solver)*ButtonBox1(Type)*Pressure-Based\" #t)");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"General*Table1*Table2(Solver)*ButtonBox1(Type)*Pressure-Based\")");
            }
            else
            {
                streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"General*Table1*Table2(Solver)*ButtonBox1(Type)*Density-Based\" #t)");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"General*Table1*Table2(Solver)*ButtonBox1(Type)*Density-Based\")");
            }
            //速度方程
            if(solverForm.velocityFormulation==VelocityFormulation.Absolute)
            {
                streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"General*Table1*Table2(Solver)*ButtonBox3(Velocity Formulation)*Absolute\" #t)");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"General*Table1*Table2(Solver)*ButtonBox3(Velocity Formulation)*Absolute\")");
            }
            else
            {
                streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"General*Table1*Table2(Solver)*ButtonBox3(Velocity Formulation)*Relative\" #t)");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"General*Table1*Table2(Solver)*ButtonBox3(Velocity Formulation)*Relative\")");
            }
            //时间类型
            if(solverForm.timeType==TimeType.Steady)
            {
                streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"General*Table1*Table2(Solver)*ToggleBox5(Time)*Steady\" #t)");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"General*Table1*Table2(Solver)*ToggleBox5(Time)*Steady\")");
            }
            else
            {
                streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"General*Table1*Table2(Solver)*ToggleBox5(Time)*Transient\" #t)");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"General*Table1*Table2(Solver)*ToggleBox5(Time)*Transient\")");
            }

            //考虑重力
            if(solverForm.isGravity)
            {
                streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"General*Table1*Table3*CheckButton1(Gravity)\" #t)");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"General*Table1*Table3*CheckButton1(Gravity)\")");
                if (solverForm.gravityDirection == GravityDirection.X)
                {
                    streamWriter.WriteLine("(cx-gui-do cx-set-real-entry-list \"General*Table1*Table3*Frame4*Frame1(Gravitational Acceleration)*RealEntry2(X)\" '( "+solverForm.gravitySize+"))");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"General*Table1*Table3*Frame4*Frame1(Gravitational Acceleration)*RealEntry2(X)\")");
                }
                else if (solverForm.gravityDirection == GravityDirection.Y)
                {
                    streamWriter.WriteLine("(cx-gui-do cx-set-real-entry-list \"General*Table1*Table3*Frame4*Frame1(Gravitational Acceleration)*RealEntry2(Y)\" '( " + solverForm.gravitySize + "))");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"General*Table1*Table3*Frame4*Frame1(Gravitational Acceleration)*RealEntry2(Y)\")");
                }
                else
                {
                    streamWriter.WriteLine("(cx-gui-do cx-set-real-entry-list \"General*Table1*Table3*Frame4*Frame1(Gravitational Acceleration)*RealEntry2(Z)\" '( " + solverForm.gravitySize + "))");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"General*Table1*Table3*Frame4*Frame1(Gravitational Acceleration)*RealEntry2(Z)\")");
                }
            }
        }

        public void write_Method()
        {
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Solution|Methods\"))");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Solution|Methods\"))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"NavigationPane*List_Tree1\")");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Solution|Methods\"))");

            string Scheme = "(cx-gui-do cx-set-list-selections \"Solution Methods*Table1*Table2(Pressure-Velocity Coupling)*DropDownList2(Scheme)\" '( ";
            
            if (methodsForm.pressure_VelocityCoupling == Pressure_VelocityCoupling.SIMPLE)
                Scheme += Pressure_VelocityCoupling.SIMPLE.ToString();
            else if (methodsForm.pressure_VelocityCoupling == Pressure_VelocityCoupling.SIMPLEC)
                Scheme += Pressure_VelocityCoupling.SIMPLEC.ToString();
            else if (methodsForm.pressure_VelocityCoupling == Pressure_VelocityCoupling.PISO)
                Scheme += Pressure_VelocityCoupling.PISO.ToString();
            else
                Scheme += Pressure_VelocityCoupling.Coupled.ToString();

            Scheme += "))";
            streamWriter.WriteLine(Scheme);
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Solution Methods*Table1*Table2(Pressure-Velocity Coupling)*DropDownList2(Scheme)\")");
        }

        public void write_Model()
        {
            //能量方程
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Models|Energy (Off)\"))");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Models|Energy (Off)\"))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"NavigationPane*List_Tree1\")");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Models|Energy (Off)\"))");

            if (modelForm.energy==Energy.ON)
            {
                streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Energy*Table1(Energy)*ToggleBox1*CheckButton1(Energy Equation)\" #t)");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Energy*Table1(Energy)*ToggleBox1*CheckButton1(Energy Equation)\")");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Energy*PanelButtons*PushButton1(OK)\")");
            }
            else
            {
                streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Energy*Table1(Energy)*ToggleBox1*CheckButton1(Energy Equation)\" #f)");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Energy*Table1(Energy)*ToggleBox1*CheckButton1(Energy Equation)\")");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Energy*PanelButtons*PushButton1(OK)\")");
            }

            //湍流模型
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Models|Viscous (Laminar)\"))");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Models|Viscous (Laminar)\"))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"NavigationPane*List_Tree1\")");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Models|Viscous (Laminar)\"))");

            switch (modelForm.viscous)
            {
                case Viscous.Inviscid:
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Viscous Model*Table1*ToggleBox1(Model)*Inviscid\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Viscous Model*Table1*ToggleBox1(Model)*Inviscid\")");
                    break;
                case Viscous.Laminar:
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Viscous Model*Table1*ToggleBox1(Model)*Laminar\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Viscous Model*Table1*ToggleBox1(Model)*Laminar\")");
                    break;
                case Viscous.SpalartAllmaras:
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Viscous Model*Table1*ToggleBox1(Model)*Spalart-Allmaras (1 eqn)\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Viscous Model*Table1*ToggleBox1(Model)*Spalart-Allmaras (1 eqn)\")");
                    break;
                case Viscous.k_eStandard:
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Viscous Model*Table1*ToggleBox1(Model)*k-epsilon (2 eqn)\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Viscous Model*Table1*ToggleBox1(Model)*k-epsilon (2 eqn)\")");
                    break;
                case Viscous.k_eRNG:
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Viscous Model*Table1*ToggleBox1(Model)*k-epsilon (2 eqn)\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Viscous Model*Table1*ToggleBox1(Model)*k-epsilon (2 eqn)\")");
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Viscous Model*Table1*ToggleBox6(k-epsilon Model)*RNG\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Viscous Model*Table1*ToggleBox6(k-epsilon Model)*RNG\")");
                    break;
                case Viscous.k_eRealizable:
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Viscous Model*Table1*ToggleBox1(Model)*k-epsilon (2 eqn)\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Viscous Model*Table1*ToggleBox1(Model)*k-epsilon (2 eqn)\")");
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Viscous Model*Table1*ToggleBox6(k-epsilon Model)*Realizable\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Viscous Model*Table1*ToggleBox6(k-epsilon Model)*Realizable\")");
                    break;
                case Viscous.k_oStandard:
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Viscous Model*Table1*ToggleBox1(Model)*k-omega (2 eqn)\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Viscous Model*Table1*ToggleBox1(Model)*k-omega (2 eqn)\")");
                    break;
                case Viscous.k_oBSL:
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Viscous Model*Table1*ToggleBox1(Model)*k-omega (2 eqn)\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Viscous Model*Table1*ToggleBox1(Model)*k-omega (2 eqn)\")");
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Viscous Model*Table1*ToggleBox7(k-omega Model)*BSL\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Viscous Model*Table1*ToggleBox7(k-omega Model)*BSL\")");
                    break;
                case Viscous.k_oSST:
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Viscous Model*Table1*ToggleBox1(Model)*k-omega (2 eqn)\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Viscous Model*Table1*ToggleBox1(Model)*k-omega (2 eqn)\")");
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Viscous Model*Table1*ToggleBox7(k-omega Model)*SST\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Viscous Model*Table1*ToggleBox7(k-omega Model)*SST\")");
                    break;
                default:
                    break;
            }
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Viscous Model*PanelButtons*PushButton1(OK)\")");

            //辐射模型
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Models|Radiation (Off)\"))");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Models|Radiation (Off)\"))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"NavigationPane*List_Tree1\")");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Models|Radiation (Off)\"))");
            switch (modelForm.radiation)
            {
                case Radiation.OFF:
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Radiation Model*Table1*Frame1*ToggleBox1(Model)*Off\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Radiation Model*Table1*Frame1*ToggleBox1(Model)*Off\")");
                    break;
                case Radiation.Rosseland:
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Radiation Model*Table1*Frame1*ToggleBox1(Model)*Rosseland\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Radiation Model*Table1*Frame1*ToggleBox1(Model)*Rosseland\")");
                    break;
                case Radiation.P1:
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Radiation Model*Table1*Frame1*ToggleBox1(Model)*P1\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Radiation Model*Table1*Frame1*ToggleBox1(Model)*P1\")");
                    break;
                case Radiation.S2S:
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Radiation Model*Table1*Frame1*ToggleBox1(Model)*Surface to Surface (S2S)\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Radiation Model*Table1*Frame1*ToggleBox1(Model)*Surface to Surface (S2S)\")");
                    break;
                case Radiation.DO:
                    streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Radiation Model*Table1*Frame1*ToggleBox1(Model)*Discrete Ordinates (DO)\" #t)");
                    streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Radiation Model*Table1*Frame1*ToggleBox1(Model)*Discrete Ordinates (DO)\")");
                    break;
                default:
                    break;
            }
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Radiation Model*PanelButtons*PushButton1(OK)\")");

            //组分传输模型
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Models|Species (Off)\"))");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Models|Species (Off)\"))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"NavigationPane*List_Tree1\")");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Setup|Models|Species (Off)\"))");
            if (modelForm.species==Species.ON)
            {
                streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Species Model*Table1*ToggleBox1(Model)*Species Transport\" #t)");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Species Model*Table1*ToggleBox1(Model)*Species Transport\")");
            }
            else
            {
                streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Species Model*Table1*ToggleBox1(Model)*Off\" #t)");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Species Model*Table1*ToggleBox1(Model)*Off\")");
            }

            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Species Model*PanelButtons*PushButton1(OK)\")");
        }

        public void write_ResultDataExport()
        {
            //如果是定常流
            if(solverForm.timeType==TimeType.Steady)
            {
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Ribbon*Frame1*Frame6(Postprocessing)*Table1*Table3(Surface)*PushButton1(Create)\")");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"MenuBar*PopupMenuCreate*Iso-Surface...\")");
                string[] surfaces = (calculationDataExportForm.sb_CreateSurface.ToString()).Split('\n');
                for (int i = 0; i < surfaces.Length - 1; i++)
                {
                    streamWriter.WriteLine(surfaces[i].Substring(0, surfaces[i].Length - 1));
                }
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Iso-Surface*PanelButtons*PushButton2(Cancel)\")");

                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"MenuBar*ExportSubMenu*Solution Data...\")");
                streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Export*Table1*Table2*DropDownList1(File Type)\" '( 1))");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Export*Table1*Table2*DropDownList1(File Type)\")");

                string surfacesJou = "(cx-gui-do cx-set-list-selections \"Export*Table1*List4(Surfaces)\" '( ";
                for(int i=0;i<calculationDataExportForm.surfacesName.Count;i++)
                {
                    surfacesJou += "\""+calculationDataExportForm.surfacesName[i]+"\" ";
                }
                surfacesJou = surfacesJou.Substring(0, surfacesJou.Length - 1);
                surfacesJou += "))";
                streamWriter.WriteLine(surfacesJou);
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Export*Table1*List4(Surfaces)\")");

                string quantitiesJou = "(cx-gui-do cx-set-list-selections \"Export*Table1*Table5*List1(Quantities)\" '( ";
                //静压
                quantitiesJou += "\"Static Pressure\" ";
                //总压
                quantitiesJou += "\"Total Pressure\" ";
                //速度大小
                quantitiesJou += "\"Velocity Magnitude\" ";
                //速度角度
                quantitiesJou += "\"Velocity Angle\" ";
                //各组分质量分数
                quantitiesJou += "\"Total Pressure\" ";
                
                foreach(object o in materialsForm.ListBox_Species.Items)
                {
                    quantitiesJou += "\"Mass fraction of " +materialsForm.MaterialsCToE(o.ToString())+"\" ";
                }
                quantitiesJou = quantitiesJou.Substring(0, quantitiesJou.Length - 1);
                quantitiesJou += "))";
                streamWriter.WriteLine(quantitiesJou);
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Export*PanelButtons*PushButton1(OK)\")");
                string executablePath = Utility.ExecutablePath();
                executablePath = executablePath.Substring(0, executablePath.LastIndexOf("GlobeCode"));
                string DataExportPath = executablePath.Substring(0, executablePath.LastIndexOf("GlobeCode"))+ "GlobeCode\\";

                DataExportPath+= "ProjectData\\" + GlobleVariable.projectName + "\\" + GlobleVariable.ResultDataDirName + "\\" + projectName + ".dat";

                streamWriter.WriteLine("(cx-gui-do cx-set-file-dialog-entries \"Select File\" '( \""+ DataExportPath + "\") \"ASCII Files ()\")");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Export*PanelButtons*PushButton2(Cancel)\")");
            }


            /***************************************************/
            //导出图片
            /***************************************************/
            foreach(string animationName in animationNames)
            {
                savePic(animationName);
            }
        }


        private List<string> animationNames;

        /// <summary>
        /// 保存图片设置
        /// </summary>
        /// <param name="speciesName">组分英文简称</param>
        /// <param name="sectionName">截面名称</param>
        /// <param name="isLoadViews">是否加载视图（只需加载一次即可）</param>
        /// <param name="viewsPath">视图路径</param>
        /// <param name="viewName">视图名称</param>
        /// <param name="gridIndexCom">2个整数的网格索引组合</param>
        /// <returns>动画名</returns>
        private string savePicSet(string speciesName,string sectionName,bool isLoadViews,string viewsPath,string viewName,string gridIndexCom)
        {
            //图片存储命令
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Solution|Calculation Activities|Solution Animations\"))");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Solution|Calculation Activities|Solution Animations\"))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"NavigationPane*List_Tree1\")");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Solution|Calculation Activities|Solution Animations\"))");

            //选择图片信息临时存储位置

            string picTempDir = Utility.SourceCodeDir()+ "//ProjectData//"+projectName+"//"+PicDataDirName;
            Utility.DeleteDirFile(picTempDir);
            streamWriter.WriteLine("(cx-gui-do cx-set-text-entry \"Animation Definition*Table2*TextEntry7\" \""+ picTempDir + "\")");

            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Animation Definition*Table6*PushButton1(New Object)\")");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"MenuBar*PopupMenuNewObject*Contours...\")");

            //选择组分云图
            streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Contours*Table1*Frame3*Table1*DropDownList1(Contours of)\" '( \"Species...\"))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Contours*Table1*Frame3*Table1*DropDownList1(Contours of)\")");

            //选择氯气组分云图
            streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Contours*Table1*Frame3*Table1*DropDownList2\" '( \"Mass fraction of "+speciesName+"\"))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Contours*Table1*Frame3*Table1*DropDownList2\")");

            //选择截面
            streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Contours*Table1*Frame3*Frame2*List2(Surfaces)\" '( \""+sectionName+"\"))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Contours*Table1*Frame3*Frame2*List2(Surfaces)\")");

            //选择全图
            streamWriter.WriteLine("(cx-gui-do cx-set-toggle-button2 \"Contours*Table1*Frame1*ToggleBox1(Options)*CheckButton1(Filled)\" #t)");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Contours*Table1*Frame1*ToggleBox1(Options)*CheckButton1(Filled)\")");

            //云图命名
            streamWriter.WriteLine("(cx-gui-do cx-set-text-entry \"Contours*Table1*TextEntry2(Contour Name)\" \"contour-"+sectionName+"_"+gridIndexCom+"\")");

            //设置完成
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Contours*PanelButtons*PushButton1(OK)\")");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Contours*PanelButtons*PushButton2(Cancel)\")");

            //选中云图
            streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Animation Definition*List3(Animation Object)\" '( \"contour-"+sectionName+"_" + gridIndexCom + "\"))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Animation Definition*List3(Animation Object)\")");

            //导入视图
            if (isLoadViews)
            {
                streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Animation Definition*Table2*DropDownList12\" '( 7))");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Animation Definition*Table2*DropDownList12\")");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Views*ButtonBox3(Actions)*PushButton6(Read)\")");

                streamWriter.WriteLine("(cx-gui-do cx-set-file-dialog-entries \"Select File\" '( \"" + viewsPath + "\") \"View Files (*.vw)\")");
                streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Views*PanelButtons*PushButton2(Close)\")");
            }
            //设置视图
            streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Animation Definition*Table2*DropDownList12\" '( "+viewName+"))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Animation Definition*Table2*DropDownList12\")");

            //动画命名
            string animationName = projectName + "_" + sectionName + "_" + gridIndexCom;
            streamWriter.WriteLine("(cx-gui-do cx-set-text-entry \"Animation Definition*TextEntry1(Name:)\" \""+ animationName + "\")");

            //动画设置完成
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Animation Definition*PanelButtons*PushButton1(OK)\")");
            return animationName;
        }

        /// <summary>
        /// 图片导出
        /// </summary>
        /// <param name="animationName">动画名</param>
        private void savePic(string animationName)
        {
            //打开动画
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Results|Animations\"))");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Results|Animations\"))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"NavigationPane*List_Tree1\")");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Results|Animations\"))");
            //打开回放
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Results|Animations|Solution Animation Playback\"))");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Results|Animations|Solution Animation Playback\"))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"NavigationPane*List_Tree1\")");
            streamWriter.WriteLine("(cx-gui-do cx-set-list-tree-selections \"NavigationPane*List_Tree1\" (list \"Results|Animations|Solution Animation Playback\"))");
            //选择云图
            streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Playback*Frame8*List1(Animation Sequences)\" '( "+ animationName + "))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Playback*Frame8*List1(Animation Sequences)\")");
            //选择导出为图片格式
            streamWriter.WriteLine("(cx-gui-do cx-set-list-selections \"Playback*DropDownList6(Write/Record Format)\" '( 1))");
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Playback*DropDownList6(Write/Record Format)\")");
            //确定导出
            streamWriter.WriteLine("(cx-gui-do cx-activate-item \"Playback*PanelButtons*PushButton1(Apply)\")");

            //图片保存
            //string picTempDir = Utility.SourceCodeDir() + "//TestData//temp";
            //string picTargetDir = Utility.SourceCodeDir() + "//ProjectData//" + projectName + "//PicData";
            //Utility.picMove(picTempDir, picTargetDir);
        }
    }
}
