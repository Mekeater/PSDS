using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobeCode.DataStruct;

namespace GlobeCode.FluentClass
{
    /*
    边界条件参数类 BCParametersClass 简称BCP
     */

    /// <summary>
    /// 能量关，湍流关
    /// </summary>
    public class BCP_OFFOFF
    {
        /// <summary>
        /// 设置速度入口边界条件 参数类
        /// </summary>
        public class VI
        {
            /// <summary>
            /// 边界名
            /// </summary>
            public string boundaryName;
            /// <summary>
            /// 速度方法
            /// </summary>
            public VelocityMethod velocityMethod;
            /// <summary>
            /// 参考框架
            /// </summary>
            public ReferenceFrame referenceFrame;
            /// <summary>
            /// 速度大小
            /// </summary>
            public string velocityMagnitude;
            /// <summary>
            /// 初始表压
            /// </summary>
            public string gaugePressure;
            /// <summary>
            /// [xyz方向或者xyz速度分量](根据速度方法而定，如果速度方法选择：大小和方向则该参数代表速度方向；如果速度方法选择：速度分量的矢量和则该参数代表速度分量(m/s)，否则默认为null)
            /// </summary>
            public float[] xyzDirctionOrComponent = null;
        }
        /// <summary>
        /// 设置压力入口边界条件 参数类
        /// </summary>
        public class PI
        {
            /// <summary>
            /// 边界名
            /// </summary>
            public string boundaryName;
            /// <summary>
            /// 参考框架
            /// </summary>
            public ReferenceFrame referenceFrame;
            /// <summary>
            /// 指定方向的方法
            /// </summary>
            public PI_DirectionMethond directionMethond;
            /// <summary>
            /// 总表压
            /// </summary>
            public string guageTotalPressure;
            /// <summary>
            /// 初始表压
            /// </summary>
            public string guageInitialPressure;
            /// <summary>
            /// [xyz方向矢量] 指定方向方法为矢量时，此值不能为空
            /// </summary>
            public float[] xyzDirection = null;
        }
        /// <summary>
        /// 质量流入口 参数类
        /// </summary>
        public class MI
        {
            /// <summary>
            /// 边界名
            /// </summary>
            public string boundaryName;
            /// <summary>
            /// 参考框架
            /// </summary>
            public ReferenceFrame referenceFrame;
            /// <summary>
            /// 质量流方法
            /// </summary>
            public MassFlowMethond massFlowMethond;
            /// <summary>
            /// 指定方向方法
            /// </summary>
            public PI_DirectionMethond dirctionMethond;
            /// <summary>
            /// 质量流率或质量流量
            /// </summary>
            public string massFlowRateOrFlux;
            /// <summary>
            /// 初始表压
            /// </summary>
            public string initialGaugePress;
            /// <summary>
            /// [平均质量流量]根据质量流方法确定该值是否为null
            /// </summary>
            public string averageFlux = null;
            /// <summary>
            /// [xyz方向矢量]根据指定方向方法确定确定该值是否为null
            /// </summary>
            public float[] xyzDirection = null;
        }
        /// <summary>
        /// 压力出口 参数类
        /// </summary>
        public class PO
        {
            /// <summary>
            /// 边界名
            /// </summary>
            public string boundaryName;
            /// <summary>
            /// 参考框架
            /// </summary>
            public ReferenceFrame referenceFrame;
            /// <summary>
            /// 回流方向方法
            /// </summary>
            public BackflowDirectionMethond bfDirectionM;
            /// <summary>
            /// 回流压力类型
            /// </summary>
            public BackflowPressure bfPressure;
            /// <summary>
            /// 表压
            /// </summary>
            public string gaugePressure;
            /// <summary>
            /// 复选情况
            /// </summary>
            public PO_MomentumCheck isCheck;
            /// <summary>
            /// [xyz方向矢量],bfdm为DirectionVector时，需要在指定
            /// </summary>
            public float[] xyzDirection = null;
            /// <summary>
            /// [目标质量流率的参数],目标质量流率复选时，需要在指定
            /// </summary>
            public float[] massFlowParameter = null;
        }
        /// <summary>
        /// 质量出口
        /// </summary>
        public class MO
        {
            /// <summary>
            /// 边界名
            /// </summary>
            public string boundaryName;
            /// <summary>
            /// 指定质量流方法
            /// </summary>
            public MassFlowMethond massFlowMethond;
            /// <summary>
            /// 指定方向方法
            /// </summary>
            public MO_DirectionMethod directionMethod;
            /// <summary>
            /// 质量流率或者质量流通量(根据massFlowMethond参数值确定)
            /// </summary>
            public string massRateOrFlux;
            /// <summary>
            /// [平均质量流通量]massFlowMethond为MassFluxWithAverageMassFlux时 指定
            /// </summary>
            public string averageMassFlux = null;
            /// <summary>
            /// [方向分量] directionMethod为DirectionVector时指定
            /// </summary>
            public float[] xyzDirection = null;
        }
    }
    /// <summary>
    /// 能量关，湍流开
    /// </summary>
    public class BCP_OFFON
    {
        /// <summary>
        /// 设置速度入口边界条件 参数类
        /// </summary>
        public class VI
        {
            /// <summary>
            /// 边界名
            /// </summary>
            public string boundaryName;
            /// <summary>
            /// 速度方法
            /// </summary>
            public VelocityMethod velocityMethod;
            /// <summary>
            /// 参考框架
            /// </summary>
            public ReferenceFrame referenceFrame;
            /// <summary>
            /// 速度大小
            /// </summary>
            public string velocityMagnitude;
            /// <summary>
            /// 初始表压
            /// </summary>
            public string gaugePressure;
            /// <summary>
            /// 湍流设置
            /// </summary>
            public TurbulenceSet turbulenceSet;
            /// <summary>
            /// [xyz方向或者xyz速度分量](根据速度方法而定，如果速度方法选择：大小和方向则该参数代表速度方向；如果速度方法选择：速度分量的矢量和则该参数代表速度分量(m/s)，否则默认为null)
            /// </summary>
            public float[] xyzDirctionOrComponent = null;
        }
        /// <summary>
        /// 设置压力入口边界条件 参数类
        /// </summary>
        public class PI
        {
            /// <summary>
            /// 边界名
            /// </summary>
            public string boundaryName;
            /// <summary>
            /// 参考框架
            /// </summary>
            public ReferenceFrame referenceFrame;
            /// <summary>
            /// 指定方向的方法
            /// </summary>
            public PI_DirectionMethond directionMethond;
            /// <summary>
            /// 总表压
            /// </summary>
            public string guageTotalPressure;
            /// <summary>
            /// 初始表压
            /// </summary>
            public string guageInitialPressure;
            /// <summary>
            /// 湍流设置
            /// </summary>
            public TurbulenceSet turbulenceSet;
            /// <summary>
            /// [xyz方向矢量] 指定方向方法为矢量时，此值不能为空
            /// </summary>
            public float[] xyzDirection = null;
        }
        /// <summary>
        /// 质量流入口 参数类
        /// </summary>
        public class MI
        {
            /// <summary>
            /// 边界名
            /// </summary>
            public string boundaryName;
            /// <summary>
            /// 参考框架
            /// </summary>
            public ReferenceFrame referenceFrame;
            /// <summary>
            /// 质量流方法
            /// </summary>
            public MassFlowMethond massFlowMethond;
            /// <summary>
            /// 指定方向方法
            /// </summary>
            public PI_DirectionMethond dirctionMethond;
            /// <summary>
            /// 质量流率或质量流量
            /// </summary>
            public string massFlowRateOrFlux;
            /// <summary>
            /// 初始表压
            /// </summary>
            public string initialGaugePress;
            /// <summary>
            /// 湍流设置
            /// </summary>
            public TurbulenceSet turbulenceSet;
            /// <summary>
            /// [平均质量流量]根据质量流方法确定该值是否为null
            /// </summary>
            public string averageFlux = null;
            /// <summary>
            /// [xyz方向矢量]根据指定方向方法确定确定该值是否为null
            /// </summary>
            public float[] xyzDirection = null;
        }
        /// <summary>
        /// 压力出口 参数类
        /// </summary>
        public class PO
        {
            /// <summary>
            /// 边界名
            /// </summary>
            public string boundaryName;
            /// <summary>
            /// 参考框架
            /// </summary>
            public ReferenceFrame referenceFrame;
            /// <summary>
            /// 回流方向方法
            /// </summary>
            public BackflowDirectionMethond bfDirectionM;
            /// <summary>
            /// 回流压力类型
            /// </summary>
            public BackflowPressure bfPressure;
            /// <summary>
            /// 表压
            /// </summary>
            public string gaugePressure;
            /// <summary>
            /// 复选情况
            /// </summary>
            public PO_MomentumCheck isCheck;
            /// <summary>
            /// 湍流设置
            /// </summary>
            public TurbulenceSet turbulenceSet;
            /// <summary>
            /// [xyz方向矢量],bfdm为DirectionVector时，需要在指定
            /// </summary>
            public float[] xyzDirection = null;
            /// <summary>
            /// [目标质量流率的参数],目标质量流率复选时，需要在指定
            /// </summary>
            public float[] massFlowParameter = null;
        }
        /// <summary>
        /// 质量出口
        /// </summary>
        public class MO
        {
            /// <summary>
            /// 边界名
            /// </summary>
            public string boundaryName;
            /// <summary>
            /// 指定质量流方法
            /// </summary>
            public MassFlowMethond massFlowMethond;
            /// <summary>
            /// 指定方向方法
            /// </summary>
            public MO_DirectionMethod directionMethod;
            /// <summary>
            /// 质量流率或者质量流通量(根据massFlowMethond参数值确定)
            /// </summary>
            public string massRateOrFlux;
            /// <summary>
            /// [平均质量流通量]massFlowMethond为MassFluxWithAverageMassFlux时 指定
            /// </summary>
            public string averageMassFlux = null;
            /// <summary>
            /// [方向分量] directionMethod为DirectionVector时指定
            /// </summary>
            public float[] xyzDirection = null;
        }
    }

    /// <summary>
    /// 能量开，湍流开，辐射关，组分开边界参数
    /// </summary>
    public class BCP_ONONOFFON 
    {
        /// <summary>
        /// 设置速度入口边界条件参数类
        /// </summary>
        public class VI
        {
            /// <summary>
            /// 边界名
            /// </summary>
            public string boundaryName;
            /// <summary>
            /// 速度方法
            /// </summary>
            public VelocityMethod velocityMethod;
            /// <summary>
            /// 参考框架
            /// </summary>
            public ReferenceFrame referenceFrame;
            /// <summary>
            /// 速度大小
            /// </summary>
            public string velocityMagnitude;
            /// <summary>
            /// 初始表压
            /// </summary>
            public string gaugePressure;
            /// <summary>
            /// 湍流设置
            /// </summary>
            public TurbulenceSet turbulenceSet;
            /// <summary>
            /// 热量温度设置
            /// </summary>
            public string temperature;
            /// <summary>
            /// 组分质量分数设置
            /// </summary>
            public List<string> speciesMassFractions;
            /// <summary>
            /// [xyz方向或者xyz速度分量](根据速度方法而定，如果速度方法选择：大小和方向则该参数代表速度方向；如果速度方法选择：速度分量的矢量和则该参数代表速度分量(m/s)，否则默认为null)
            /// </summary>
            public float[] xyzDirctionOrComponent = null;
        }
        /// <summary>
        /// 设置压力入口边界条件参数类
        /// </summary>
        public class PI
        {
            /// <summary>
            /// 边界名
            /// </summary>
            public string boundaryName;
            /// <summary>
            /// 参考框架
            /// </summary>
            public ReferenceFrame referenceFrame;
            /// <summary>
            /// 指定方向的方法
            /// </summary>
            public PI_DirectionMethond directionMethond;
            /// <summary>
            /// 总表压
            /// </summary>
            public string guageTotalPressure;
            /// <summary>
            /// 初始表压
            /// </summary>
            public string guageInitialPressure;
            /// <summary>
            /// 湍流设置
            /// </summary>
            public TurbulenceSet turbulenceSet;
            /// <summary>
            /// 热量温度设置
            /// </summary>
            public string temperature;
            /// <summary>
            /// 组分质量分数设置
            /// </summary>
            public List<string> speciesMassFractions;
            /// <summary>
            /// [xyz方向矢量] 指定方向方法为矢量时，此值不能为空
            /// </summary>
            public float[] xyzDirection = null;
        }

        /// <summary>
        /// 质量流入口参数类
        /// </summary>
        public class MI
        {
            /// <summary>
            /// 边界名
            /// </summary>
            public string boundaryName;
            /// <summary>
            /// 参考框架
            /// </summary>
            public ReferenceFrame referenceFrame;
            /// <summary>
            /// 质量流方法
            /// </summary>
            public MassFlowMethond massFlowMethond;
            /// <summary>
            /// 指定方向方法
            /// </summary>
            public PI_DirectionMethond dirctionMethond;
            /// <summary>
            /// 质量流率或质量流量
            /// </summary>
            public string massFlowRateOrFlux;
            /// <summary>
            /// 初始表压
            /// </summary>
            public string initialGaugePress;
            /// <summary>
            /// 湍流设置
            /// </summary>
            public TurbulenceSet turbulenceSet;
            /// <summary>
            /// 热量温度设置
            /// </summary>
            public string temperature;
            /// <summary>
            /// 组分质量分数设置
            /// </summary>
            public List<string> speciesMassFractions;
            /// <summary>
            /// [平均质量流量]根据质量流方法确定该值是否为null
            /// </summary>
            public string averageFlux = null;
            /// <summary>
            /// [xyz方向矢量]根据指定方向方法确定确定该值是否为null
            /// </summary>
            public float[] xyzDirection = null;
        }

        /// <summary>
        /// 压力出口参数类
        /// </summary>
        public class PO
        {
            /// <summary>
            /// 边界名
            /// </summary>
            public string boundaryName;
            /// <summary>
            /// 参考框架
            /// </summary>
            public ReferenceFrame referenceFrame;
            /// <summary>
            /// 回流方向方法
            /// </summary>
            public BackflowDirectionMethond bfDirectionM;
            /// <summary>
            /// 回流压力类型
            /// </summary>
            public BackflowPressure bfPressure;
            /// <summary>
            /// 表压
            /// </summary>
            public string gaugePressure;
            /// <summary>
            /// 复选情况
            /// </summary>
            public PO_MomentumCheck isCheck;
            /// <summary>
            /// 湍流设置
            /// </summary>
            public TurbulenceSet turbulenceSet;
            /// <summary>
            /// 热量温度设置
            /// </summary>
            public string temperature;
            /// <summary>
            /// 组分质量分数设置
            /// </summary>
            public List<string> speciesMassFractions;
            /// <summary>
            /// [xyz方向矢量],bfdm为DirectionVector时，需要在指定
            /// </summary>
            public float[] xyzDirection = null;
            /// <summary>
            /// [目标质量流率的参数],目标质量流率复选时，需要在指定
            /// </summary>
            public float[] massFlowParameter = null;
        }
        /// <summary>
        /// 质量出口 参数设置类
        /// </summary>
        public class MO
        {
            /// <summary>
            /// 边界名
            /// </summary>
            public string boundaryName;
            /// <summary>
            /// 指定质量流方法
            /// </summary>
            public MassFlowMethond massFlowMethond;
            /// <summary>
            /// 指定方向方法
            /// </summary>
            public MO_DirectionMethod directionMethod;
            /// <summary>
            /// 质量流率或者质量流通量(根据massFlowMethond参数值确定)
            /// </summary>
            public string massRateOrFlux;
            /// <summary>
            /// [平均质量流通量]massFlowMethond为MassFluxWithAverageMassFlux时 指定
            /// </summary>
            public string averageMassFlux = null;
            /// <summary>
            /// [方向分量] directionMethod为DirectionVector时指定
            /// </summary>
            public float[] xyzDirection = null;
        }
    }

    /// <summary>
    /// 模型选择组合情况
    /// 能量方程；湍流模型；辐射模型；组分模型
    /// </summary>
    public enum ModelsSelect
    {
        /// <summary>
        /// 能量方程关闭；湍流模型关闭；
        /// </summary>
        OFFOFF,
        /// <summary>
        /// 能量方程关闭；湍流模型开启
        /// </summary>
        OFFON,
        /// <summary>
        /// 能量方程开启；湍流模型关闭；辐射模型开启；组分模型开启
        /// </summary>
        ONOFFONON,
        /// <summary>
        /// 能量方程开启；湍流模型关闭；辐射模型开启；组分模型关闭
        /// </summary>
        ONOFFONOFF,
        /// <summary>
        /// 能量方程开启；湍流模型关闭；辐射模型关闭；组分模型开启
        /// </summary>
        ONOFFOFFON,
        /// <summary>
        /// 能量方程开启；湍流模型关闭；辐射模型关闭；组分模型关闭
        /// </summary>
        ONOFFOFFOFF,
        /// <summary>
        /// 能量方程开启；湍流模型开启；辐射模型关闭；组分模型开启
        /// </summary>
        ONONOFFON,
        /// <summary>
        /// 能量方程开启；湍流模型开启；辐射模型关闭；组分模型关闭
        /// </summary>
        ONONOFFOFF,
        /// <summary>
        /// 能量方程开启；湍流模型开启；辐射模型开启；组分模型开启
        /// </summary>
        ONONONON,
        /// <summary>
        /// 能量方程开启；湍流模型开启；辐射模型开启；组分模型关闭
        /// </summary>
        ONONONOFF
    }


}
