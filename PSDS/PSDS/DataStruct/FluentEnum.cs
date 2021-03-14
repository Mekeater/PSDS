using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobeCode.DataStruct
{
    /*
     * Fluent相关选择的枚举类
     */

    /// <summary>
    /// 求解器类型
    /// </summary>
    public enum SolverType
    {
        PressureBased,
        DensityBased
    };
    /// <summary>
    /// 速度方程
    /// </summary>
    public enum VelocityFormulation
    {
        Absolute,
        Relative
    };
    /// <summary>
    /// 时间类型
    /// </summary>
    public enum TimeType
    {
        Steady,
        Transient
    };
    /// <summary>
    /// 重力方向
    /// </summary>
    public enum GravityDirection
    {
        X,
        Y,
        Z
    }
    /// <summary>
    /// 能量方程
    /// </summary>
    public enum Energy
    {
        OFF,
        ON
    }
    /// <summary>
    /// 湍流模型
    /// </summary>
    public enum Viscous
    {
        Inviscid,
        Laminar,
        SpalartAllmaras,
        k_eStandard,
        k_eRNG,
        k_eRealizable,
        k_oStandard,
        k_oBSL,
        k_oSST
    }
    /// <summary>
    /// 辐射模型
    /// </summary>
    public enum Radiation
    {
        OFF,
        Rosseland,
        P1,
        S2S,
        DO
    }
    /// <summary>
    /// 组分模型
    /// </summary>
    public enum Species
    {
        OFF,
        ON
    }
    /// <summary>
    /// 材料库索引
    /// </summary>
    public enum Materials
    {
        nh3=457,
        o3=471,
        no2=462,
        so2 =559,
        so3=560,
        co=241,
        co2=242,
        h2s=327,
        h2o=322,
        o2=468,
        n2=438,
        cl2=200
    }
    /// <summary>
    /// 材料名全称
    /// </summary>
    public class MaterialsFullName
    {
        //一定要注意，下面全称由 英文全称 (简称) 组成（英文全称和简称之间有空格，一定要注意！！！我在这儿浪费好久呀）
        public static readonly string so2_full = "sulfur-dioxide (so2)";
        public static readonly string so3_full = "sulfur-trioxide (so3)";
        public static readonly string o3_full = "ozone (o3)";
        public static readonly string nh3_full = "ammonia-vapor (nh3)";
        public static readonly string no2_full = "nitrogen-dioxide (no2)";
        public static readonly string h2s_full = "hydrogen-sulfide (h2s)";
        public static readonly string co_full = "carbon-monoxide (co)";
        public static readonly string co2_full = "carbon-dioxide (co2)";
        public static readonly string air_full = "air";
        public static readonly string h2o_full = "water-vapor (h2o)";
        public static readonly string o2_full = "oxygen (o2)";
        public static readonly string n2_full = "nitrogen (n2)";
        public static readonly string cl2_full = "chlorine (cl2)";
    }

    /// <summary>
    /// 边界条件类型(英文)
    /// </summary>
    public class BoundaryTypeE
    {
        public static readonly string pressure_inlet = "pressure-inlet"; //简称PI
        public static readonly string velocity_inlet = "velocity-inlet"; //简称VI
        public static readonly string mass_flow_inlet = "mass-flow-inlet";//简称MI
        public static readonly string mass_flow_outlet = "mass-flow-outlet";//简称MO
        public static readonly string pressure_outlet = "pressure-outlet";//简称PO
        public static readonly string outflow = "outflow";
        public static readonly string wall = "wall";
    }
    /// <summary>
    /// 边界条件类型(中文)
    /// </summary>
    public class BoundaryTypeC
    {
        public static readonly string pressure_inlet = "压力入口";
        public static readonly string velocity_inlet = "速度入口";
        public static readonly string mass_flow_inlet = "质量流入口";
        public static readonly string mass_flow_outlet = "质量流出口";
        public static readonly string pressure_outlet = "压力出口";
        public static readonly string outflow = "出流 ";
        public static readonly string wall = "壁面";
    }

    /// <summary>
    /// 压强速度关联算法
    /// </summary>
    public enum Pressure_VelocityCoupling
    {
        SIMPLE,
        SIMPLEC,
        PISO, 
        Coupled
    }

    /// <summary>
    /// 初始化方法
    /// </summary>
    public enum IntializeMethods
    {
        Hybrid,
        Standard
    }

    /// <summary>
    /// 时间步方法
    /// </summary>
    public enum TimeStepingMethod
    {
        Fixed,
        Adaptive
    }

    /// <summary>
    /// 指定速度方法
    /// </summary>
    public enum VelocityMethod
    {
        /// <summary>
        /// 大小和方向
        /// </summary>
        MagnitudeAndDirection,
        /// <summary>
        /// 速度分量的矢量和
        /// </summary>
        Components,
        /// <summary>
        /// 大小和方向垂直于边界面
        /// </summary>
        Magnitude_NormalToBoundary
    }

    /// <summary>
    /// 参考框架
    /// </summary>
    public enum ReferenceFrame
    {
        /// <summary>
        /// 绝对
        /// </summary>
        Absolute,
        /// <summary>
        /// 相对于相邻单元区域
        /// </summary>
        Relative
    }

    /// <summary>
    /// 压力入口 指定方向方法
    /// </summary>
    public enum PI_DirectionMethond
    {
        /// <summary>
        /// 方向矢量
        /// </summary>
        DirectionVector,
        /// <summary>
        /// 垂直于边界
        /// </summary>
        NormalToBoundary
    }

    /// <summary>
    /// 质量流指定方法
    /// </summary>
    public enum MassFlowMethond
    {
        /// <summary>
        /// 质量流率
        /// </summary>
        MassFlowRate,
        /// <summary>
        /// 质量通量
        /// </summary>
        MassFlowFlux,
        /// <summary>
        /// 质量通量和平均质量通量
        /// </summary>
        MassFluxWithAverageMassFlux
    }

    /// <summary>
    /// 压力出口，回流方向方法
    /// </summary>
    public enum BackflowDirectionMethond
    {
        /// <summary>
        /// 方向矢量
        /// </summary>
        DirectionVector,
        /// <summary>
        /// 垂直于边界
        /// </summary>
        NormalToBoundary,
        /// <summary>
        /// 相邻单元格方向
        /// </summary>
        FromNeighboringCell
    }

    /// <summary>
    /// 指定回流压力
    /// </summary>
    public enum BackflowPressure
    {
        /// <summary>
        /// 总压
        /// </summary>
        TotalPressure,
        /// <summary>
        /// 静压
        /// </summary>
        StaticPressure
    }

    /// <summary>
    /// 压力出口 动量选项卡中的三项复选情况
    /// </summary>
    public class PO_MomentumCheck
    {
        /// <summary>
        /// 径向平衡压力分布
        /// </summary>
        public bool RadialEquilibriumPD = false;
        /// <summary>
        /// 指定平均压力
        /// </summary>
        public bool AverageP = false;
        /// <summary>
        /// 目标质量流量
        /// </summary>
        public bool TargetMassFlow = false;
    }

    /// <summary>
    /// 质量流出口 方向方法
    /// </summary>
    public enum MO_DirectionMethod
    {
        /// <summary>
        /// 方向矢量
        /// </summary>
        DirectionVector,
        /// <summary>
        /// 外法线
        /// </summary>
        OutwardNormal
    }

    /// <summary>
    /// 湍流阶数
    /// </summary>
    public enum TurbulenceOrder
    {
        /// <summary>
        /// 一阶
        /// </summary>
        FirstOrder,
        /// <summary>
        /// 二阶
        /// </summary>
        SecondOrder
    }

    /// <summary>
    /// 一阶湍流方法（SpalartAllmaras）； 质量出口没有一阶湍流项
    /// </summary>
    public enum FirstOrder_TurbulenceMethod
    {
        /// <summary>
        /// 修改湍流粘度
        /// </summary>
        ModifiedTurbulentViscosity,
        /// <summary>
        /// 湍流强度和湍流长度
        /// </summary>
        IntensityAndLengthScale,
        /// <summary>
        /// 湍流粘度比
        /// </summary>
        TurbulentViscosityRatio,
        /// <summary>
        /// 湍流强度和水分子直径
        /// </summary>
        IntensityAndHydraulicDiameter
    }

    /// <summary>
    /// 二阶湍流方法 （质量出口没有二阶湍流项）
    /// </summary>
    public enum SecondOrder_TurbulenceMethod
    {
        /// <summary>
        /// 湍流动能与湍流耗散率
        /// </summary>
        KAndEpsilon,
        /// <summary>
        /// 湍流强度与湍流长度
        /// </summary>
        IntensityAndLengthScale,
        /// <summary>
        /// 湍流强度与湍流粘度比
        /// </summary>
        IntensityAndViscosityRatio,
        /// <summary>
        /// 湍流强度与水力直径
        /// </summary>
        IntensityAndHydraulicDiameter
    }

    /// <summary>
    /// 湍流参数设置类
    /// </summary>
    public class TurbulenceSet
    {
        /// <summary>
        /// 湍流方法阶数
        /// </summary>
        public TurbulenceOrder turbulenceOrder;
        /// <summary>
        /// [一阶湍流方法] 
        /// turbulenceOrder为SecondOrder时不必设置
        /// </summary>
        public FirstOrder_TurbulenceMethod firstOrder_TurbulenceMethod;
        /// <summary>
        /// [二阶湍流方法] 
        /// turbulenceOrder为FirstOrder时不必设置
        /// </summary>
        public SecondOrder_TurbulenceMethod secondOrder_TurbulenceMethod;
        /// <summary>
        /// 湍流参数1
        /// </summary>
        public string TurbulenceP1;
        /// <summary>
        /// [湍流参数2] 
        /// 对于一阶湍流，如果firstOrder_TurbulenceMethod参数为ModifiedTurbulentViscosity或TurbulentViscosityRatio，不必设置
        /// </summary>
        public string TurbulenceP2 = null;

    }
}
