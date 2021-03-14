using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobeCode.FluentClass;

namespace GlobeCode.DataStruct
{
    /// <summary>
    /// 全局静态变量类
    /// </summary>
    public class GlobleVariable
    {
        //工程数据保存数据文件夹组织
        /// <summary>
        /// 数据保存文件夹根目录
        /// </summary>
        public static readonly string DataDirectoryRoot = "../../ProjectData/";
        /// <summary>
        /// 存储Journal文件的文件夹名称
        /// </summary>
        public static readonly string JournalDirName = "Journal";
        /// <summary>
        /// 计算结果数据(文本数据)存储文件夹名称
        /// </summary>
        public static readonly string ResultDataDirName = "ResultData";
        /// <summary>
        /// 计算结果数据(图片数据)存储文件夹名称
        /// </summary>
        public static readonly string PicDataDirName = "PicData";

        //用于保存用户选择
        public static string fluentEXEPath=null;
        //模拟项目名称
        public static string projectName = "";
        //参数设置子窗口
        public static SolverForm solverForm =null;
        public static ModelForm modelForm = null;
        public static MaterialsForm materialsForm = null;
        public static BoundaryConditionsForm boundaryConditionsForm = null;
        public static MethodsForm methodsForm = null;
        public static InitiallizationForm initiallizationForm = null;
        public static RunCalculationForm runCalculationForm = null;
        public static CalculationDataExportForm calculationDataExportForm = null;
        //边界条件类型参数设置子窗口
        public static ThermalTabForm thermalTabForm = null;
        public static RadiationTabForm radiationTabForm = null;
        public static SpeciesTabForm speciesTabForm = null;
        public static PressureInletMomentumTabForm pressureInletMomentumTabForm = null;
        public static VelocityInletMomentumTabForm velocityInletMomentumTabForm = null;
        public static MassFlowInletMomentumTabForm massFlowInletMomentumTabForm = null;
        public static MassFlowOutletMomentumTabForm massFlowOutletMomentumTabForm = null;
        public static PressureOutletMomentumTabForm pressureOutletMomentumTabForm = null;
        //当前模型组合状态
        public static ModelsSelect currentModelsStatus;

        //journal文件写入流
        public static StreamWriter streamWriter = null;

        //边界条件 TUI命令 封装类 相关接口实现类
        public static BoundaryConditionSet BCS = new BoundaryConditionSet();
    }


   
}
