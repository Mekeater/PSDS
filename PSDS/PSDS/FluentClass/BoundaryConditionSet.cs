using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GlobeCode.DataStruct;

namespace GlobeCode.FluentClass
{
    /// <summary>
    /// 边界条件设置类
    /// </summary>
    public class BoundaryConditionSet:BoundaryConditionImp
    {

        /// <summary>
        /// 能量开；湍流开；辐射关；组分开 模型情况下，边界条件设置
        /// 调用该方法时采用 命名参数调用 
        /// 例如： void  func(int x, int y=2) { Console.WrinteLine(x+y);}     func（y:3,x:2;
        /// 因为该方法的参数都要默认值，每次调用只有一个参数参与计算，因此只需给一个指定的参数传值即可
        /// </summary>
        /// <param name="vi">速度入口参数</param>
        /// <param name="pi">压力入口参数</param>
        /// <param name="mi">质量流入口参数</param>
        /// <param name="po">压力出口参数</param>
        /// <param name="mo">质量流出口参数</param>
        /// <returns>TUI命令</returns>
        public string Set_ONONOFFON(BCP_ONONOFFON.VI vi = null, BCP_ONONOFFON.PI pi = null, BCP_ONONOFFON.MI mi = null, BCP_ONONOFFON.PO po = null, BCP_ONONOFFON.MO mo = null)
        {
            string TUI = null;
            BoundaryConditionImp BC = new BoundaryConditionImp();
            IEnON_ViscousON_RadiationOFF_SpeciesON iBCSet = BC;
            if (vi != null)
                TUI = iBCSet.VI(vi.boundaryName, vi.velocityMethod, vi.referenceFrame, vi.velocityMagnitude, vi.gaugePressure, vi.turbulenceSet, vi.temperature, vi.speciesMassFractions, vi.xyzDirctionOrComponent);
            else if (pi != null)
                TUI = iBCSet.PI(pi.boundaryName, pi.referenceFrame, pi.directionMethond, pi.guageTotalPressure, pi.guageInitialPressure, pi.turbulenceSet, pi.temperature, pi.speciesMassFractions, pi.xyzDirection);
            else if (mi != null)
                TUI = iBCSet.MI(mi.boundaryName, mi.referenceFrame, mi.massFlowMethond, mi.dirctionMethond, mi.massFlowRateOrFlux, mi.initialGaugePress, mi.turbulenceSet, mi.temperature, mi.speciesMassFractions, mi.averageFlux, mi.xyzDirection);
            else if (po != null)
                TUI = iBCSet.PO(po.boundaryName, po.referenceFrame, po.bfDirectionM, po.bfPressure, po.gaugePressure, po.isCheck, po.turbulenceSet, po.temperature, po.speciesMassFractions, po.xyzDirection, po.massFlowParameter);
            else if (mo != null)
                TUI = iBCSet.MO(mo.boundaryName, mo.massFlowMethond, mo.directionMethod, mo.massRateOrFlux, mo.averageMassFlux, mo.xyzDirection);

            return TUI;
        }

        /// <summary>
        /// 能量关；湍流关；边界条件设置
        /// 调用该方法时采用 命名参数调用 
        /// 例如： void  func(int x, int y=2) { Console.WrinteLine(x+y);}     func（y:3,x:2;
        /// 因为该方法的参数都要默认值，每次调用只有一个参数参与计算，因此只需给一个指定的参数传值即可
        /// </summary>
        /// <param name="vi">速度入口参数</param>
        /// <param name="pi">压力入口参数</param>
        /// <param name="mi">质量流入口参数</param>
        /// <param name="po">压力出口参数</param>
        /// <param name="mo">质量流出口参数</param>
        /// <returns>TUI命令</returns>
        public string Set_OFFOFF(BCP_OFFOFF.VI vi=null,BCP_OFFOFF.PI pi=null,BCP_OFFOFF.MI mi=null,BCP_OFFOFF.PO po=null,BCP_OFFOFF.MO mo=null)
        {
            string TUI = null;
            BoundaryConditionImp BC = new BoundaryConditionImp();
            IEnOFF_ViscousOFF iBCSet = BC;
            if (vi != null)
                TUI = iBCSet.VI(vi.boundaryName, vi.velocityMethod, vi.referenceFrame, vi.velocityMagnitude, vi.gaugePressure, vi.xyzDirctionOrComponent);
            else if (pi != null)
                TUI = iBCSet.PI(pi.boundaryName, pi.referenceFrame, pi.directionMethond, pi.guageTotalPressure, pi.guageInitialPressure, pi.xyzDirection);
            else if (mi != null)
                TUI = iBCSet.MI(mi.boundaryName, mi.referenceFrame, mi.massFlowMethond, mi.dirctionMethond, mi.massFlowRateOrFlux, mi.initialGaugePress, mi.averageFlux, mi.xyzDirection);
            else if (po != null)
                TUI = iBCSet.PO(po.boundaryName, po.referenceFrame, po.bfDirectionM, po.bfPressure, po.gaugePressure, po.isCheck, po.xyzDirection, po.massFlowParameter);
            else if (mo != null)
                TUI = iBCSet.MO(mo.boundaryName, mo.massFlowMethond, mo.directionMethod, mo.massRateOrFlux, mo.averageMassFlux, mo.xyzDirection);
            return TUI;
        }

        /// <summary>
        /// 能量关；湍流开；边界条件设置
        /// 调用该方法时采用 命名参数调用 
        /// 例如： void  func(int x, int y=2) { Console.WrinteLine(x+y);}     func（y:3,x:2;
        /// 因为该方法的参数都要默认值，每次调用只有一个参数参与计算，因此只需给一个指定的参数传值即可
        /// </summary>
        /// <param name="vi">速度入口参数</param>
        /// <param name="pi">压力入口参数</param>
        /// <param name="mi">质量流入口参数</param>
        /// <param name="po">压力出口参数</param>
        /// <param name="mo">质量流出口参数</param>
        /// <returns>TUI命令</returns>
        public string Set_OFFON(BCP_OFFON.VI vi=null,BCP_OFFON.PI pi=null,BCP_OFFON.MI mi=null,BCP_OFFON.PO po=null,BCP_OFFON.MO mo=null)
        {
            string TUI = null;
            BoundaryConditionImp BC = new BoundaryConditionImp();
            IEnOFF_ViscousON iBCSet = BC;
            if (vi != null)
                TUI = iBCSet.VI(vi.boundaryName, vi.velocityMethod, vi.referenceFrame, vi.velocityMagnitude, vi.gaugePressure, vi.turbulenceSet, vi.xyzDirctionOrComponent);
            else if (pi != null)
                TUI = iBCSet.PI(pi.boundaryName, pi.referenceFrame, pi.directionMethond, pi.guageTotalPressure, pi.guageInitialPressure, pi.turbulenceSet, pi.xyzDirection);
            else if (mi != null)
                TUI = iBCSet.MI(mi.boundaryName, mi.referenceFrame, mi.massFlowMethond, mi.dirctionMethond, mi.massFlowRateOrFlux, mi.initialGaugePress, mi.turbulenceSet, mi.averageFlux, mi.xyzDirection);
            else if (po != null)
                TUI = iBCSet.PO(po.boundaryName, po.referenceFrame, po.bfDirectionM, po.bfPressure, po.gaugePressure, po.isCheck, po.turbulenceSet, po.xyzDirection, po.massFlowParameter);
            else if (mo != null)
                TUI = iBCSet.MO(mo.boundaryName, mo.massFlowMethond, mo.directionMethod, mo.massRateOrFlux, mo.averageMassFlux, mo.xyzDirection);
            return TUI;
        }







        #region 废弃的测试代码
        //List<string> TUIs = new List<string>();
        //string TUI = null;
        //BoundaryConditionImp BC = new BoundaryConditionImp();
        //IEnOFF_ViscousOFF iEnOFF_ViscousOFF = BC;
        //TUI=ModifyBoundaryType("inlet1", BoundaryTypeE.mass_flow_inlet.ToString());
        //TUIs.Add(TUI);
        //TUI =iEnOFF_ViscousOFF.MI("inlet1", ReferenceFrame.Absolute, MassFlowMethond.MassFlowRate, PI_DirectionMethond.NormalToBoundary,"10","101325");
        //TUIs.Add(TUI);
        //PO_MomentumCheck pO_MomentumCheck = new PO_MomentumCheck();
        //pO_MomentumCheck.TargetMassFlow = true;
        //TUI = iEnOFF_ViscousOFF.PO("outlet1", ReferenceFrame.Relative, BackflowDirectionMethond.DirectionVector, BackflowPressure.TotalPressure, "101325", pO_MomentumCheck, new float[] { 1,2,3},new float[] { 1,600000,1});
        //TUI = ModifyBoundaryType("outlet1", BoundaryTypeE.mass_flow_outlet.ToString());
        //TUIs.Add(TUI);

        //TUI = iEnOFF_ViscousOFF.MO("outlet1", MassFlowMethond.MassFlowFlux, MO_DirectionMethod.OutwardNormal, "10");

        //TUIs.Add(TUI);

        //IEnOFF_ViscousON iEnOFF_ViscousON = BC;
        //TurbulenceSet turbulenceSet = new TurbulenceSet();
        //turbulenceSet.turbulenceOrder = TurbulenceOrder.FirstOrder;
        //turbulenceSet.firstOrder_TurbulenceMethod = FirstOrder_TurbulenceMethod.IntensityAndLengthScale;
        //turbulenceSet.TurbulenceP1 = "6";
        //turbulenceSet.TurbulenceP2 = "6";
        //TUI = iEnOFF_ViscousON.VI("inlet1", VelocityMethod.Magnitude_NormalToBoundary, ReferenceFrame.Relative, "10", "101325", turbulenceSet);
        //TUIs.Add(TUI);

        //TUI = ModifyBoundaryType("inlet1", BoundaryTypeE.pressure_inlet.ToString());
        //TUIs.Add(TUI);
        //IEnOFF_ViscousON iEnOFF_ViscousON = BC;
        //TurbulenceSet turbulenceSet = new TurbulenceSet();
        //turbulenceSet.turbulenceOrder = TurbulenceOrder.SecondOrder;
        //turbulenceSet.secondOrder_TurbulenceMethod = SecondOrder_TurbulenceMethod.IntensityAndLengthScale;
        //turbulenceSet.TurbulenceP1 = "6";
        //turbulenceSet.TurbulenceP2 = "6";
        //TUI = iEnOFF_ViscousON.PI("inlet1", ReferenceFrame.Absolute, PI_DirectionMethond.DirectionVector, "101325", "1", turbulenceSet, new float[] { 1, 2, 3 });
        //TUIs.Add(TUI);

        //TUI = ModifyBoundaryType("inlet1", BoundaryTypeE.mass_flow_inlet.ToString());
        //TUIs.Add(TUI);
        //IEnOFF_ViscousON iEnOFF_ViscousON = BC;
        //TurbulenceSet turbulenceSet = new TurbulenceSet();
        //turbulenceSet.turbulenceOrder = TurbulenceOrder.SecondOrder;
        //turbulenceSet.secondOrder_TurbulenceMethod = SecondOrder_TurbulenceMethod.IntensityAndHydraulicDiameter;
        //turbulenceSet.TurbulenceP1 = "6";
        //turbulenceSet.TurbulenceP2 = "6";
        //TUI = iEnOFF_ViscousON.MI("inlet1", ReferenceFrame.Relative, MassFlowMethond.MassFlowFlux, PI_DirectionMethond.NormalToBoundary, "10", "101325", turbulenceSet);
        //TUIs.Add(TUI);

        //IEnOFF_ViscousON iEnOFF_ViscousON = BC;
        //TurbulenceSet turbulenceSet = new TurbulenceSet();
        //turbulenceSet.turbulenceOrder = TurbulenceOrder.SecondOrder;
        //turbulenceSet.secondOrder_TurbulenceMethod = SecondOrder_TurbulenceMethod.KAndEpsilon;
        //turbulenceSet.TurbulenceP1 = "6";
        //turbulenceSet.TurbulenceP2 = "6";
        //TUI = iEnOFF_ViscousON.PO("outlet1", ReferenceFrame.Absolute, BackflowDirectionMethond.DirectionVector, BackflowPressure.TotalPressure, "101325", new PO_MomentumCheck(), turbulenceSet,new float[] { 1,2,3});
        //TUIs.Add(TUI);

        //IEnON_ViscousON_RadiationOFF_SpeciesON iONONOFFON = BC;
        //TurbulenceSet turbulenceSet = new TurbulenceSet();
        //turbulenceSet.turbulenceOrder = TurbulenceOrder.SecondOrder;
        //turbulenceSet.secondOrder_TurbulenceMethod = SecondOrder_TurbulenceMethod.KAndEpsilon;
        //turbulenceSet.TurbulenceP1 = "6";
        //turbulenceSet.TurbulenceP2 = "6";
        //TUI = iONONOFFON.VI("inlet1", VelocityMethod.Magnitude_NormalToBoundary, ReferenceFrame.Relative, "10", "101325", turbulenceSet,"266",new List<string> {"0.5","0.3" });
        //TUIs.Add(TUI);

        //TUI = ModifyBoundaryType("inlet1", BoundaryTypeE.mass_flow_inlet.ToString());
        //TUIs.Add(TUI);
        //IEnON_ViscousON_RadiationOFF_SpeciesON iONONOFFON = BC;
        //TurbulenceSet turbulenceSet = new TurbulenceSet();
        //turbulenceSet.turbulenceOrder = TurbulenceOrder.SecondOrder;
        //turbulenceSet.secondOrder_TurbulenceMethod = SecondOrder_TurbulenceMethod.IntensityAndLengthScale;
        //turbulenceSet.TurbulenceP1 = "6";
        //turbulenceSet.TurbulenceP2 = "6";
        //TUI = iONONOFFON.PO("outlet1", ReferenceFrame.Absolute, BackflowDirectionMethond.DirectionVector, BackflowPressure.TotalPressure, "101325", new PO_MomentumCheck(), turbulenceSet,"266",new List<string> {"0.3","0.06" }, new float[] { 1, 2, 3 });
        //TUIs.Add(TUI);

        //TUI = ModifyBoundaryType("inlet1", BoundaryTypeE.mass_flow_outlet.ToString());
        //TUIs.Add(TUI);
        //IEnON_ViscousON_RadiationOFF_SpeciesON iONONOFFON = BC;
        //TUI=iONONOFFON.MO("inlet1", MassFlowMethond.MassFluxWithAverageMassFlux, MO_DirectionMethod.DirectionVector, "10", "5", new float[] { 1, 2, 3 });
        //TUIs.Add(TUI);
        #endregion
    }


}
