using GlobeCode.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobeCode.FluentClass
{
    //能量关闭；湍流开启
    interface IEnOFF_ViscousON
    {
        /// <summary>
        /// 设置速度入口边界条件
        /// </summary>
        /// <param name="boundaryName">边界名</param>
        /// <param name="velocityMethod">速度方法</param>
        /// <param name="referenceFrame">参考框架</param>
        /// <param name="velocityMagnitude">速度大小</param>
        /// <param name="gaugePressure">初始表压</param>
        /// <param name="turbulenceSet">湍流设置</param>
        /// <param name="xyzDirctionOrComponent ">[xyz方向或者xyz速度分量](根据速度方法而定，如果速度方法选择：大小和方向则该参数代表速度方向；如果速度方法选择：速度分量的矢量和则该参数代表速度分量(m/s)，否则默认为null)</param>
        /// <returns>TUI命令</returns>
        string VI(string boundaryName, VelocityMethod velocityMethod, ReferenceFrame referenceFrame, string velocityMagnitude, string gaugePressure, TurbulenceSet turbulenceSet, float[] xyzDirctionOrComponent = null);

        /// <summary>
        /// 设置压力入口边界条件
        /// </summary>
        /// <param name="boundaryName">边界名</param>
        /// <param name="referenceFrame">参考框架</param>
        /// <param name="directionMethond">指定方向的方法</param>
        /// <param name="guageTotalPressure">总表压</param>
        /// <param name="guageInitialPressure">初始表压</param>
        /// <param name="turbulenceSet">湍流设置</param>
        /// <param name="xyzDirection">[xyz方向矢量] 指定方向方法为矢量时，此值不能为空</param>
        /// <returns>TUI命令</returns>
        string PI(string boundaryName, ReferenceFrame referenceFrame, PI_DirectionMethond directionMethond, string guageTotalPressure, string guageInitialPressure, TurbulenceSet turbulenceSet, float[] xyzDirection = null);

        /// <summary>
        /// 质量流入口
        /// </summary>
        /// <param name="boundaryName">边界名</param>
        /// <param name="referenceFrame">参考框架</param>
        /// <param name="massFlowMethond">质量流方法</param>
        /// <param name="dirctionMethond">指定方向方法</param>
        /// <param name="massFlowRateOrFlux">质量流率或质量流量</param>
        /// <param name="initialGaugePress">初始表压</param>
        /// <param name="turbulenceSet">湍流设置</param>
        /// <param name="averageFlux">[平均质量流量]根据质量流方法确定该值是否为null</param>
        /// <param name="xyzDirection">[xyz方向矢量]根据指定方向方法确定确定该值是否为null</param>
        /// <returns>TUI命令</returns>
        string MI(string boundaryName, ReferenceFrame referenceFrame, MassFlowMethond massFlowMethond, PI_DirectionMethond dirctionMethond, string massFlowRateOrFlux, string initialGaugePress, TurbulenceSet turbulenceSet, string averageFlux = null, float[] xyzDirection = null);

        /// <summary>
        /// 压力出口
        /// </summary>
        /// <param name="boundaryName">边界名</param>
        /// <param name="referenceFrame">参考框架</param>
        /// <param name="bfDirectionM">回流方向方法</param>
        /// <param name="bfPressure">回流压力类型</param>
        /// <param name="gaugePressure">表压</param>
        /// <param name="isCheck">复选情况</param>
        /// <param name="turbulenceSet">湍流设置</param>
        /// <param name="xyzDirection">[xyz方向矢量],bfdm为DirectionVector时，需要在指定</param>
        /// <param name="massFlowParameter">[目标质量流率的参数],目标质量流率复选时，需要在指定</param>
        /// <returns>TUI命令</returns>
        string PO(string boundaryName, ReferenceFrame referenceFrame, BackflowDirectionMethond bfDirectionM, BackflowPressure bfPressure, string gaugePressure, PO_MomentumCheck isCheck, TurbulenceSet turbulenceSet, float[] xyzDirection = null, float[] massFlowParameter = null);

        /// <summary>
        /// 质量出口
        /// </summary>
        /// <param name="boundaryName">边界名</param>
        /// <param name="massFlowMethond">指定质量流方法</param>
        /// <param name="directionMethod">指定方向方法</param>
        /// <param name="massRateOrFlux">质量流率或者质量流通量(根据massFlowMethond参数值确定)</param>
        /// <param name="averageMassFlux">[平均质量流通量]massFlowMethond为MassFluxWithAverageMassFlux时 指定</param>
        /// <param name="xyzDirection">[方向分量] directionMethod为DirectionVector时指定</param>
        /// <returns>TUI命令</returns>
        string MO(string boundaryName, MassFlowMethond massFlowMethond, MO_DirectionMethod directionMethod, string massRateOrFlux, string averageMassFlux = null, float[] xyzDirection = null);
    }
}
