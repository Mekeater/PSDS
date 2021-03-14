using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobeCode.DataStruct;
using System.Windows.Forms;

namespace GlobeCode.FluentClass
{
    /// <summary>
    /// 封装Fluent 边界条件设置的相关TUI命令 方法
    /// </summary>
    public class BoundaryConditionImp:IEnOFF_ViscousOFF,IEnOFF_ViscousON,IEnON_ViscousON_RadiationOFF_SpeciesON
    {

        private string m_boundaryConditionInitialTUI = "/define/boundary-conditions/";

        /// <summary>
        /// 修改边界类型
        /// </summary>
        /// <param name="BounaryName">待修改边界类型的边界名</param>
        /// <param name="BoundaryType">修改为的边界类型</param>
        /// <returns></returns>
        public string ModifyBoundaryType(string bounaryName, string boundaryType)
        {
            return m_boundaryConditionInitialTUI+"zone-type " + bounaryName + " " + boundaryType;
        }

        /// <summary>
        /// 修改边界名
        /// </summary>
        /// <param name="OldName">原始边界名</param>
        /// <param name="NewName">修改后边界名</param>
        /// <returns></returns>
        public string ModifyBoundaryName(string oldName,string newName)
        {
            return m_boundaryConditionInitialTUI + "zone-name " + oldName + " " + newName;
        }



        #region IEnOFF_ViscousOFF
        /// <summary>
        /// 设置速度入口边界条件
        /// </summary>
        /// <param name="boundaryType">边界类型</param>
        /// <param name="boundaryName">边界名</param>
        /// <param name="velocityMethod">速度方法</param>
        /// <param name="referenceFrame">参考框架</param>
        /// <param name="velocityMagnitude">速度大小</param>
        /// <param name="gaugePressure">初始表压</param>
        /// <param name="xyzDirctionOrComponent ">[xyz方向或者xyz速度分量](根据速度方法而定，如果速度方法选择：大小和方向则该参数代表速度方向；如果速度方法选择：速度分量的矢量和则该参数代表速度分量(m/s)，否则默认为null)</param>
        /// <returns>TUI命令</returns>
        string IEnOFF_ViscousOFF.VI(string boundaryName, VelocityMethod velocityMethod, ReferenceFrame referenceFrame, string velocityMagnitude, string gaugePressure, float[] xyzDirctionOrComponent = null)
        {
            string boundaryType = BoundaryTypeE.velocity_inlet.ToString();
            if ((int)velocityMethod == 0 || (int)velocityMethod == 1)
                if (xyzDirctionOrComponent == null)
                {
                    MessageBox.Show("当前速度方法，xyzDirctionOrComponent不可为null");
                    return null;
                }

            StringBuilder sb = new StringBuilder();
            sb.Append(m_boundaryConditionInitialTUI + boundaryType + " " + boundaryName + " ");

            if ((int)velocityMethod == 0)
                sb.Append("y ");
            else if ((int)velocityMethod == 1)
                sb.Append("n y");
            else
                sb.Append("n n y ");

            if ((int)referenceFrame == 0)
                sb.Append("y ");
            else
                sb.Append("n y ");

            if ((int)velocityMethod == 0 || (int)velocityMethod == 2)
                sb.Append("n " + velocityMagnitude + " n " + gaugePressure+" ");
            else
                sb.Append("n " + gaugePressure+" ");

            if ((int)velocityMethod == 0 || (int)velocityMethod == 1)
                sb.Append("y n " + xyzDirctionOrComponent[0].ToString() + " n " + xyzDirctionOrComponent[1].ToString() + " n " + xyzDirctionOrComponent[2].ToString()+" ");
            return sb.ToString();
        }

        /// <summary>
        /// 设置压力入口边界条件
        /// </summary>
        /// <param name="boundaryName">边界名</param>
        /// <param name="referenceFrame">参考框架</param>
        /// <param name="directionMethond">指定方向的方法</param>
        /// <param name="guageTotalPressure">总表压</param>
        /// <param name="guageInitialPressure">初始表压</param>
        /// <param name="xyzDirection">[xyz方向矢量] 指定方向方法为矢量时，此值不能为空</param>
        /// <returns>TUI命令</returns>
        string IEnOFF_ViscousOFF.PI(string boundaryName, ReferenceFrame referenceFrame, PI_DirectionMethond directionMethond, string guageTotalPressure, string guageInitialPressure, float[] xyzDirection = null)
        {
            string bounaryType = BoundaryTypeE.pressure_inlet.ToString();
            StringBuilder sb = new StringBuilder();
            if (directionMethond == PI_DirectionMethond.DirectionVector)
                if (xyzDirection == null)
                {
                    MessageBox.Show("当前指定方向的方法，xyzDirction不可为null");
                    return null;
                }

            sb.Append(m_boundaryConditionInitialTUI + bounaryType + " " + boundaryName + " ");
            if ((int)referenceFrame == 0)
                sb.Append("y ");
            else
                sb.Append("n y ");

            sb.Append("n " + guageTotalPressure + " n " + guageInitialPressure + " ");

            if ((int)directionMethond == 0)
                sb.Append("y y n " + xyzDirection[0].ToString() + " n " + xyzDirection[1].ToString() + " n " + xyzDirection[2].ToString()+" ");
            else
                sb.Append("n y ");

            return sb.ToString();
        }

        /// <summary>
        /// 质量流入口
        /// </summary>
        /// <param name="boundaryName">边界名</param>
        /// <param name="referenceFrame">参考框架</param>
        /// <param name="massFlowMethond">质量流方法</param>
        /// <param name="dirctionMethond">指定方向方法</param>
        /// <param name="massFlowRateOrFlux">质量流率或质量流量</param>
        /// <param name="initialGaugePress">初始表压</param>
        /// <param name="averageFlux">[平均质量流量]根据质量流方法确定该值是否为null</param>
        /// <param name="xyzDirection">[xyz方向矢量]根据指定方向方法确定确定该值是否为null</param>
        /// <returns></returns>
        string IEnOFF_ViscousOFF.MI(string boundaryName, ReferenceFrame referenceFrame, MassFlowMethond massFlowMethond, PI_DirectionMethond directionMethond, string massFlowRateOrFlux, string initialGaugePress, string averageFlux = null, float[] xyzDirection = null)
        {
            string bounaryType = BoundaryTypeE.mass_flow_inlet.ToString();
            StringBuilder sb = new StringBuilder();
            if(massFlowMethond==MassFlowMethond.MassFluxWithAverageMassFlux)
                if(averageFlux==null)
                {
                    MessageBox.Show("当前质量流方法，averageFlux不能为null");
                }
            if (directionMethond == PI_DirectionMethond.DirectionVector)
                if (xyzDirection == null)
                {
                    MessageBox.Show("当前指定方向的方法，xyzDirction不可为null");
                    return null;
                }
            sb.Append(m_boundaryConditionInitialTUI + bounaryType + " " + boundaryName + " ");
            if ((int)referenceFrame == 0)
                sb.Append("y ");
            else
                sb.Append("n y ");

            if ((int)massFlowMethond == 0)
                sb.Append("y "+"n "+massFlowRateOrFlux+" ");
            else if ((int)massFlowMethond == 1)
                sb.Append("n y " + "n " + massFlowRateOrFlux + " ");
            else
                sb.Append("n n y n "+massFlowRateOrFlux+" "+averageFlux+" ");


            sb.Append("n " + initialGaugePress+" ");

            if (directionMethond == 0)
                sb.Append("y y n "+xyzDirection[0].ToString()+" n "+xyzDirection[1].ToString()+" n "+xyzDirection[2].ToString()+" ");
            else
                sb.Append("n y ");

            return sb.ToString();
        }

        /// <summary>
        /// 压力出口
        /// </summary>
        /// <param name="boundaryName">边界名</param>
        /// <param name="referenceFrame">参考框架</param>
        /// <param name="bfDirectionM">回流方向方法</param>
        /// <param name="bfPressure">回流压力类型</param>
        /// <param name="gaugePressure">表压</param>
        /// <param name="isCheck">复选情况</param>
        /// <param name="xyzDirection">[xyz方向矢量],bfdm为DirectionVector时，需要在指定</param>
        /// <param name="massFlowParameter">[目标质量流率的参数],目标质量流率复选时，需要在指定</param>
        /// <returns>TUI命令</returns>
        string IEnOFF_ViscousOFF.PO(string boundaryName, ReferenceFrame referenceFrame, BackflowDirectionMethond bfDirectionM, BackflowPressure bfPressure, string gaugePressure, PO_MomentumCheck isCheck, float[] xyzDirection = null,float[] massFlowParameter=null)
        {
            string bounaryType = BoundaryTypeE.pressure_outlet.ToString();
            StringBuilder sb = new StringBuilder();

            if (bfDirectionM == BackflowDirectionMethond.DirectionVector)
                if (xyzDirection == null)
                {
                    MessageBox.Show("当前指定方向的方法，xyzDirction不可为null");
                    return null;
                }
            sb.Append(m_boundaryConditionInitialTUI + bounaryType + " " + boundaryName + " ");
            if ((int)referenceFrame == 0)
                sb.Append("y ");
            else
                sb.Append("n y ");

            sb.Append("n " + gaugePressure + " ");

            if ((int)bfDirectionM == 0)
                sb.Append("y y n "+xyzDirection[0].ToString()+" n "+xyzDirection[1].ToString()+" n "+xyzDirection[2].ToString()+" ");
            else if ((int)bfDirectionM == 1)
                sb.Append("n y ");
            else
                sb.Append("n n y ");

            if (bfPressure == 0)
                sb.Append("y ");
            else
                sb.Append("n y ");


            if (isCheck.RadialEquilibriumPD)
                sb.Append("y ");
            else
                sb.Append("n ");
            if (isCheck.AverageP)
                sb.Append("y ");
            else
                sb.Append("n ");
            if (isCheck.TargetMassFlow)
                sb.Append("y n "+massFlowParameter[0].ToString()+" n "+massFlowParameter[1].ToString()+" n "+massFlowParameter[2].ToString()+" ");
            else
                sb.Append("n ");

            return sb.ToString();
        }

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
        string IEnOFF_ViscousOFF.MO(string boundaryName, MassFlowMethond massFlowMethond, MO_DirectionMethod directionMethod, string massRateOrFlux, string averageMassFlux = null, float[] xyzDirection = null)
        {
            string bounaryType = BoundaryTypeE.mass_flow_outlet.ToString();
            StringBuilder sb = new StringBuilder();

            if (massFlowMethond == MassFlowMethond.MassFluxWithAverageMassFlux)
                if (averageMassFlux == null)
                {
                    MessageBox.Show("当前质量流方法，averageFlux不能为null");
                }
            if (directionMethod == MO_DirectionMethod.DirectionVector)
                if (xyzDirection == null)
                {
                    MessageBox.Show("当前指定方向的方法，xyzDirction不可为null");
                    return null;
                }

            sb.Append(m_boundaryConditionInitialTUI + bounaryType + " " + boundaryName + " ");

            sb.Append("y ");

            if ((int)massFlowMethond == 0)
                sb.Append("y n "+massRateOrFlux+" ");
            else if ((int)massFlowMethond == 1)
                sb.Append("n y n "+massRateOrFlux+" ");
            else
                sb.Append("n n y n "+massRateOrFlux+" "+averageMassFlux+" ");

            if ((int)directionMethod == 0)
                sb.Append("y y n " + xyzDirection[0].ToString() + " n " + xyzDirection[1].ToString() + " n " + xyzDirection[2].ToString() + " ");
            else
                sb.Append("n y ");

            return sb.ToString();
        }
        #endregion


        #region IEnOFF_ViscousON

        /// <summary>
        /// 湍流设置TUI
        /// </summary>
        /// <param name="turbulenceSet">湍流设置参数</param>
        /// <returns></returns>
        private string TurbulenceSetTUI(TurbulenceSet turbulenceSet)
        {
            StringBuilder sb = new StringBuilder();
            if (turbulenceSet.turbulenceOrder == TurbulenceOrder.SecondOrder)
            {
                if ((int)turbulenceSet.secondOrder_TurbulenceMethod == 0)
                    sb.Append("y n " + turbulenceSet.TurbulenceP1 + " n " + turbulenceSet.TurbulenceP2 + " ");
                else if ((int)turbulenceSet.secondOrder_TurbulenceMethod == 1)
                    sb.Append("n y n " + turbulenceSet.TurbulenceP1 + " n " + turbulenceSet.TurbulenceP2 + " ");
                else if ((int)turbulenceSet.secondOrder_TurbulenceMethod == 2)
                    sb.Append("n n y n " + turbulenceSet.TurbulenceP1 + " n " + turbulenceSet.TurbulenceP2 + " ");
                else
                    sb.Append("n n n y n " + turbulenceSet.TurbulenceP1 + " n " + turbulenceSet.TurbulenceP2 + " ");
            }
            else
            {
                if ((int)turbulenceSet.firstOrder_TurbulenceMethod == 0)
                    sb.Append("y n " + turbulenceSet.TurbulenceP1 + " ");
                else if ((int)turbulenceSet.firstOrder_TurbulenceMethod == 1)
                    sb.Append("n y " + turbulenceSet.TurbulenceP1 + " " + turbulenceSet.TurbulenceP2 + " ");
                else if ((int)turbulenceSet.firstOrder_TurbulenceMethod == 2)
                    sb.Append("n n y n " + turbulenceSet.TurbulenceP1 + " ");
                else
                    sb.Append("n n n y " + turbulenceSet.TurbulenceP1 + " " + turbulenceSet.TurbulenceP2 + " ");
            }
            return sb.ToString();
        }

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
        string IEnOFF_ViscousON.VI(string boundaryName, VelocityMethod velocityMethod, ReferenceFrame referenceFrame, string velocityMagnitude, string gaugePressure, TurbulenceSet turbulenceSet, float[] xyzDirctionOrComponent=null)
        {
            StringBuilder sb = new StringBuilder();

            BoundaryConditionImp BC = new BoundaryConditionImp();
            IEnOFF_ViscousOFF iEnOFF_ViscousOFF = BC;
            //动量TUI
            string TUI = iEnOFF_ViscousOFF.VI(boundaryName, velocityMethod, referenceFrame, velocityMagnitude, gaugePressure, xyzDirctionOrComponent);
            sb.Append(TUI);
            //湍流TUI
            TUI = TurbulenceSetTUI(turbulenceSet);
            sb.Append(TUI);

            return sb.ToString();
            
        }

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
        string IEnOFF_ViscousON.PI(string boundaryName, ReferenceFrame referenceFrame, PI_DirectionMethond directionMethond, string guageTotalPressure, string guageInitialPressure, TurbulenceSet turbulenceSet, float[] xyzDirection)
        {
            StringBuilder sb = new StringBuilder();

            BoundaryConditionImp BC = new BoundaryConditionImp();
            IEnOFF_ViscousOFF iEnOFF_ViscousOFF = BC;
            //动量TUI
            string TUI = iEnOFF_ViscousOFF.PI(boundaryName, referenceFrame, directionMethond, guageTotalPressure, guageInitialPressure, xyzDirection);
            sb.Append(TUI);
            //湍流TUI
            TUI = TurbulenceSetTUI(turbulenceSet);
            sb.Append(TUI);
            return sb.ToString();
        }

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
        string IEnOFF_ViscousON.MI(string boundaryName, ReferenceFrame referenceFrame, MassFlowMethond massFlowMethond, PI_DirectionMethond dirctionMethond, string massFlowRateOrFlux, string initialGaugePress, TurbulenceSet turbulenceSet, string averageFlux, float[] xyzDirection)
        {
            StringBuilder sb = new StringBuilder();

            BoundaryConditionImp BC = new BoundaryConditionImp();
            IEnOFF_ViscousOFF iEnOFF_ViscousOFF = BC;
            //动量TUI
            string TUI = iEnOFF_ViscousOFF.MI(boundaryName, referenceFrame, massFlowMethond, dirctionMethond, massFlowRateOrFlux, initialGaugePress, averageFlux, xyzDirection);
            sb.Append(TUI);
            //湍流TUI
            TUI = TurbulenceSetTUI(turbulenceSet);
            sb.Append(TUI);
            return sb.ToString();
        }

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
        string IEnOFF_ViscousON.PO(string boundaryName, ReferenceFrame referenceFrame, BackflowDirectionMethond bfDirectionM, BackflowPressure bfPressure, string gaugePressure, PO_MomentumCheck isCheck, TurbulenceSet turbulenceSet, float[] xyzDirection, float[] massFlowParameter)
        {
            string bounaryType = BoundaryTypeE.pressure_outlet.ToString();
            StringBuilder sb = new StringBuilder();

            if (bfDirectionM == BackflowDirectionMethond.DirectionVector)
                if (xyzDirection == null)
                {
                    MessageBox.Show("当前指定方向的方法，xyzDirction不可为null");
                    return null;
                }
            sb.Append(m_boundaryConditionInitialTUI + bounaryType + " " + boundaryName + " ");
            if ((int)referenceFrame == 0)
                sb.Append("y ");
            else
                sb.Append("n y ");

            sb.Append("n " + gaugePressure + " ");

            if ((int)bfDirectionM == 0)
                sb.Append("y y n " + xyzDirection[0].ToString() + " n " + xyzDirection[1].ToString() + " n " + xyzDirection[2].ToString() + " ");
            else if ((int)bfDirectionM == 1)
                sb.Append("n y ");
            else
                sb.Append("n n y ");

            //湍流TUI
            sb.Append(TurbulenceSetTUI(turbulenceSet));

            if (bfPressure == 0)
                sb.Append("y ");
            else
                sb.Append("n y ");


            if (isCheck.RadialEquilibriumPD)
                sb.Append("y ");
            else
                sb.Append("n ");
            if (isCheck.AverageP)
                sb.Append("y ");
            else
                sb.Append("n ");
            if (isCheck.TargetMassFlow)
                sb.Append("y n " + massFlowParameter[0].ToString() + " n " + massFlowParameter[1].ToString() + " n " + massFlowParameter[2].ToString() + " ");
            else
                sb.Append("n ");

            return sb.ToString();
        }

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
        string IEnOFF_ViscousON.MO(string boundaryName, MassFlowMethond massFlowMethond, MO_DirectionMethod directionMethod, string massRateOrFlux, string averageMassFlux, float[] xyzDirection)
        {
            //质量出口没有湍流项，因此和湍流没有打开的代码一样，直接调用即可。
            StringBuilder sb = new StringBuilder();
            BoundaryConditionImp BC = new BoundaryConditionImp();
            IEnOFF_ViscousOFF iEnOFF_ViscousOFF = BC;
            //动量TUI
            string TUI = iEnOFF_ViscousOFF.MO(boundaryName, massFlowMethond, directionMethod, massRateOrFlux, averageMassFlux, xyzDirection);
            sb.Append(TUI);
            return sb.ToString();
        }

        #endregion


        #region IEnON_ViscousON_RadiationOFF_SpeciesON

        /// <summary>
        /// 设置速度入口边界条件
        /// </summary>
        /// <param name="boundaryName">边界名</param>
        /// <param name="velocityMethod">速度方法</param>
        /// <param name="referenceFrame">参考框架</param>
        /// <param name="velocityMagnitude">速度大小</param>
        /// <param name="gaugePressure">初始表压</param>
        /// <param name="turbulenceSet">湍流设置</param>
        /// <param name="temperature">热量温度设置</param>
        /// <param name="speciesMassFractions">组分质量分数设置</param>
        /// <param name="xyzDirctionOrComponent ">[xyz方向或者xyz速度分量](根据速度方法而定，如果速度方法选择：大小和方向则该参数代表速度方向；如果速度方法选择：速度分量的矢量和则该参数代表速度分量(m/s)，否则默认为null)</param>
        /// <returns>TUI命令</returns>
        string IEnON_ViscousON_RadiationOFF_SpeciesON.VI(string boundaryName, VelocityMethod velocityMethod, ReferenceFrame referenceFrame, string velocityMagnitude, string gaugePressure, TurbulenceSet turbulenceSet, string temperature, List<string> speciesMassFractions, float[] xyzDirctionOrComponent)
        {
            StringBuilder sb = new StringBuilder();

            BoundaryConditionImp BC = new BoundaryConditionImp();
            IEnOFF_ViscousOFF iEnOFF_ViscousOFF = BC;
            //动量TUI
            string TUI = iEnOFF_ViscousOFF.VI(boundaryName, velocityMethod, referenceFrame, velocityMagnitude, gaugePressure, xyzDirctionOrComponent);
            sb.Append(TUI);

            //热量TUI
            sb.Append("n " + temperature + " ");

            //湍流TUI
            TUI = TurbulenceSetTUI(turbulenceSet);
            sb.Append(TUI);

            //组分TUI
            sb.Append("n ");
            foreach(string specieMassFractions in speciesMassFractions)
            {
                sb.Append("n " + specieMassFractions+" ");
            }

            return sb.ToString();
        }

        /// <summary>
        /// 设置压力入口边界条件
        /// </summary>
        /// <param name="boundaryName">边界名</param>
        /// <param name="referenceFrame">参考框架</param>
        /// <param name="directionMethond">指定方向的方法</param>
        /// <param name="guageTotalPressure">总表压</param>
        /// <param name="guageInitialPressure">初始表压</param>
        /// <param name="turbulenceSet">湍流设置</param>
        /// <param name="temperature">热量温度设置</param>
        /// <param name="speciesMassFractions">组分质量分数设置</param>
        /// <param name="xyzDirection">[xyz方向矢量] 指定方向方法为矢量时，此值不能为空</param>
        /// <returns>TUI命令</returns>
        string IEnON_ViscousON_RadiationOFF_SpeciesON.PI(string boundaryName, ReferenceFrame referenceFrame, PI_DirectionMethond directionMethond, string guageTotalPressure, string guageInitialPressure, TurbulenceSet turbulenceSet, string temperature, List<string> speciesMassFractions, float[] xyzDirection)
        {
            string bounaryType = BoundaryTypeE.pressure_inlet.ToString();
            StringBuilder sb = new StringBuilder();
            if (directionMethond == PI_DirectionMethond.DirectionVector)
                if (xyzDirection == null)
                {
                    MessageBox.Show("当前指定方向的方法，xyzDirction不可为null");
                    return null;
                }

            sb.Append(m_boundaryConditionInitialTUI + bounaryType + " " + boundaryName + " ");
            if ((int)referenceFrame == 0)
                sb.Append("y ");
            else
                sb.Append("n y ");

            sb.Append("n " + guageTotalPressure + " n " + guageInitialPressure + " ");

            //热量TUI
            sb.Append("n " + temperature + " ");

            if ((int)directionMethond == 0)
                sb.Append("y y n " + xyzDirection[0].ToString() + " n " + xyzDirection[1].ToString() + " n " + xyzDirection[2].ToString() + " ");
            else
                sb.Append("n y ");

            //湍流TUI
            string TUI = TurbulenceSetTUI(turbulenceSet);
            sb.Append(TUI);

            //组分TUI
            sb.Append("n ");
            foreach (string specieMassFractions in speciesMassFractions)
            {
                sb.Append("n " + specieMassFractions + " ");
            }

            return sb.ToString();
        }

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
        /// <param name="temperature">热量温度设置</param>
        /// <param name="speciesMassFractions">组分质量分数设置</param>
        /// <param name="averageFlux">[平均质量流量]根据质量流方法确定该值是否为null</param>
        /// <param name="xyzDirection">[xyz方向矢量]根据指定方向方法确定确定该值是否为null</param>
        /// <returns>TUI命令</returns>
        string IEnON_ViscousON_RadiationOFF_SpeciesON.MI(string boundaryName, ReferenceFrame referenceFrame, MassFlowMethond massFlowMethond, PI_DirectionMethond directionMethond, string massFlowRateOrFlux, string initialGaugePress, TurbulenceSet turbulenceSet, string temperature, List<string> speciesMassFractions, string averageFlux, float[] xyzDirection)
        {
            string bounaryType = BoundaryTypeE.mass_flow_inlet.ToString();
            StringBuilder sb = new StringBuilder();
            if (massFlowMethond == MassFlowMethond.MassFluxWithAverageMassFlux)
                if (averageFlux == null)
                {
                    MessageBox.Show("当前质量流方法，averageFlux不能为null");
                }
            if (directionMethond == PI_DirectionMethond.DirectionVector)
                if (xyzDirection == null)
                {
                    MessageBox.Show("当前指定方向的方法，xyzDirction不可为null");
                    return null;
                }
            sb.Append(m_boundaryConditionInitialTUI + bounaryType + " " + boundaryName + " ");
            if ((int)referenceFrame == 0)
                sb.Append("y ");
            else
                sb.Append("n y ");

            if ((int)massFlowMethond == 0)
                sb.Append("y " + "n " + massFlowRateOrFlux + " ");
            else if ((int)massFlowMethond == 1)
                sb.Append("n y " + "n " + massFlowRateOrFlux + " ");
            else
                sb.Append("n n y n " + massFlowRateOrFlux + " " + averageFlux + " ");

            //热量TUI
            sb.Append("n " + temperature + " ");

            sb.Append("n " + initialGaugePress + " ");

            if (directionMethond == 0)
                sb.Append("y y n " + xyzDirection[0].ToString() + " n " + xyzDirection[1].ToString() + " n " + xyzDirection[2].ToString() + " ");
            else
                sb.Append("n y ");

            //湍流TUI
            string TUI = TurbulenceSetTUI(turbulenceSet);
            sb.Append(TUI);

            //组分TUI
            sb.Append("n ");
            foreach (string specieMassFractions in speciesMassFractions)
            {
                sb.Append("n " + specieMassFractions + " ");
            }

            return sb.ToString();
        }

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
        /// <param name="temperature">热量温度设置</param>
        /// <param name="speciesMassFractions">组分质量分数设置</param>
        /// <param name="xyzDirection">[xyz方向矢量],bfdm为DirectionVector时，需要在指定</param>
        /// <param name="massFlowParameter">[目标质量流率的参数],目标质量流率复选时，需要在指定</param>
        /// <returns>TUI命令</returns>
        string IEnON_ViscousON_RadiationOFF_SpeciesON.PO(string boundaryName, ReferenceFrame referenceFrame, BackflowDirectionMethond bfDirectionM, BackflowPressure bfPressure, string gaugePressure, PO_MomentumCheck isCheck, TurbulenceSet turbulenceSet, string temperature, List<string> speciesMassFractions, float[] xyzDirection, float[] massFlowParameter)
        {
            string bounaryType = BoundaryTypeE.pressure_outlet.ToString();
            StringBuilder sb = new StringBuilder();

            if (bfDirectionM == BackflowDirectionMethond.DirectionVector)
                if (xyzDirection == null)
                {
                    MessageBox.Show("当前指定方向的方法，xyzDirction不可为null");
                    return null;
                }
            sb.Append(m_boundaryConditionInitialTUI + bounaryType + " " + boundaryName + " ");
            if ((int)referenceFrame == 0)
                sb.Append("y ");
            else
                sb.Append("n y ");

            sb.Append("n " + gaugePressure + " ");

            //热量TUI
            sb.Append("n " + temperature + " ");

            if ((int)bfDirectionM == 0)
                sb.Append("y y n " + xyzDirection[0].ToString() + " n " + xyzDirection[1].ToString() + " n " + xyzDirection[2].ToString() + " ");
            else if ((int)bfDirectionM == 1)
                sb.Append("n y ");
            else
                sb.Append("n n y ");

            //湍流TUI
            sb.Append(TurbulenceSetTUI(turbulenceSet));

            //组分TUI
            sb.Append("n ");
            foreach (string specieMassFractions in speciesMassFractions)
            {
                sb.Append("n " + specieMassFractions + " ");
            }

            if (bfPressure == 0)
                sb.Append("y ");
            else
                sb.Append("n y ");


            if (isCheck.RadialEquilibriumPD)
                sb.Append("y ");
            else
                sb.Append("n ");
            if (isCheck.AverageP)
                sb.Append("y ");
            else
                sb.Append("n ");
            if (isCheck.TargetMassFlow)
                sb.Append("y n " + massFlowParameter[0].ToString() + " n " + massFlowParameter[1].ToString() + " n " + massFlowParameter[2].ToString() + " ");
            else
                sb.Append("n ");

            return sb.ToString();
        }

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
        string IEnON_ViscousON_RadiationOFF_SpeciesON.MO(string boundaryName, MassFlowMethond massFlowMethond, MO_DirectionMethod directionMethod, string massRateOrFlux, string averageMassFlux, float[] xyzDirection)
        {
            StringBuilder sb = new StringBuilder();
            BoundaryConditionImp BC = new BoundaryConditionImp();
            IEnOFF_ViscousOFF iEnOFF_ViscousOFF = BC;
            //动量TUI
            string TUI = iEnOFF_ViscousOFF.MO(boundaryName, massFlowMethond, directionMethod, massRateOrFlux, averageMassFlux, xyzDirection);
            sb.Append(TUI);
            return sb.ToString();
        }

        #endregion



    }
}
