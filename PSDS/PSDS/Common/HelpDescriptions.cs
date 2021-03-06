using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobeCode.Common
{
    /// <summary>
    /// 帮助说明类：主要解释说明Fluent中相关选择的意义。
    /// </summary>
    public class HelpDescriptions
    {
        public static string PressureBase = "基于压力法的求解器，使用的是压力修正算法，"+
            "求解的控制方程是标量形式的，擅长求解不可压缩流，对于"+
            "可压缩流也可以求解";
        public static string DensityBase = "基于密度法的求解器，求解的控制方程是矢量形式。该方法的初衷是让Fluent具有较好的求解可压缩流动能力"+
            ",但目前格式没有添加任何限制器，因此还不太完善；它只有Couple的算法";
        public static string VAbsolute = "指定计算时速度是绝对速度";
        public static string VRelative = "指定计算时速度是相对速度";
        public static string Stready = "稳态问题，计算结果不随时间的变化而变化";
        public static string Transient = "瞬态问题，计算结果随时间的变化而变化";

        public static string Energy_ON = "进行能量方程计算";
        public static string Energy_OFF = "不进行能量方程计算";

        public static string Viscous = "湍流模型：湍流出现在速度变动的地方。这种波动使得流体介质之间交互动量、能量和浓度变化，" +
                                       "而且引起数量的波动。由于这种波动是小尺度且是高频率的，所以在实际工程计算中模拟的话对计算机的要求" +
                                       "会很高。实际上瞬时控制方程可能在时间上、空间上是均匀的，或者可以认为的改变尺度，这样修改后的方程耗费较少。" +
                                       "但是，修改后的方程可能包含我们所不知的变量，湍流模型需要已知变量来确定这些变量。";
        public static string Viscous_Inviscid = "进行无粘计算";
        public static string Viscous_Laminar = "用层流模型进行流动模拟";
        public static string Viscous_SpalartAllmaras = "Spalart-Allmaras模型是一种新出现的湍流模型，在工程应用问题中还没有多少成功的算例" +
                                                       "。和其他一方程模型一样，它的稳定性比较差";
        public static string Viscous_k_eStandard = "标准k-ε模型，本身具有的稳定性、经济型和比较高的计算精度使之成为湍流模型中应用范围最广、" +
                                                  "也最为人熟知的一个模型。标准k-ε模型通过求解湍流动能(k)方程和湍流耗散率(ε)方程，得到k和" +
                                                  "ε的解，然后利用k和ε的值计算湍流粘度，最终通过Boussinesq假设得到雷诺应力的解。";

        public static string Viscous_k_eRNG = "标准k-ε模型的改进，计算功能上强于标准k-ε模型";
        public static string Viscous_k_eRealizable = "标准k-ε模型的改进，它满足对雷诺应力的约束条件，因此可以在雷诺应力上保持与真实湍流的一致。这一点是标准k-ε模型和RNG k-ε模型" +
                                                      "都无法做到的。这个特点在计算中的好处是，可以更精确地模拟平面和圆形射流的扩散速度，同时在旋转流计算，带方向压强梯度的边界层计算" +
                                                      "和分离流计算等问题中，计算结果更符合真实情况。";
        public static string Viscous_k_oStandard = "k-omega模型也是二方程模型。标准k-omega模型中包含了低雷诺数影响、可压缩性影响和剪切流扩散，因此适用于尾迹流动计算、"+
                                                    "混合层计算、射流计算，以及受到壁面限制的流动计算和自由剪切运算。";
        public static string Viscous_k_oBSL = "待更新...";
        public static string Viscous_k_oSST = "SST k-omega模型(剪切应力运输k-omega模型)综合了k-omega模型在近壁区计算的优点和k-omega模型在远场计算的优点，将k-omega模型和标准"+
                                              "k-omega模型都乘以一个混合函数后再相加就得到这个模型。在近壁区，混合函数的值等于1，因此在近壁区等价于k-omega模型。在远离壁面的区域，"+
                                              "混合函数的值则等于0，因此自动转为标准k-omega模型。\n相比标准k-omega模型，SST k-omega模型适用范围更广，比如可以用于带逆压梯度的流动计算、"+
                                              "翼型计算、跨音速激波计算等。";
        public static string Radiation = "用户在其传热计算中可以使用这些辐射模型，使用辐射模型后，用户就可以在其计算中考虑壁面由于辐射而引起的加热或冷却以及流体相由辐射引起的热量或汇";
        public static string Radiation_OFF = "不开启辐射模型";
        public static string Radiation_Rosseland = "同P-1模型相比，Rosseland模型的优点是不用像P-1模型那样计算额外的运输方程，因此，Rosseland模型计算速度更快，需要的内存更少。Rosseland的"+
                                                   "缺点是仅能用于光学厚度大于3的问题，同时计算中只能采用分离求解器进行计算。";
        public static string Radiation_P1 = "P-1模型中辐射换热方程(RTE)是一个容易求解的扩散方程，同时模型中包含了散射效应。在燃烧等光学厚度很大的计算问题中，P-1模型的计算效果都比较好。";
        public static string Radiation_S2S = "表面辐射模型（S2S）适用于计算没有介入辐射介质的封闭空间内的辐射换热计算，比如太阳能集热器、辐射式加热器和汽车机箱内的冷却过程等。";
        public static string Radiation_DO = "DO模型是适用范围最大的模型，它可以计算所有光学厚度的辐射问题，并且计算范围涵盖了从表面辐射、半透明介质辐射到燃烧问题中出现的介入辐射在内的各种"+
                                            "辐射问题。DO模型采用灰带模型进行计算，因此既可以计算灰体辐射，也可以计算非灰体辐射。如果格网划分不过分精细的话，计算中所占用的系统资源也不大，因此，"+
                                            "DO模型成为辐射计算中被经常使用的一个模型。";
        public static string Species = "可以模拟具有或者不具有组分运输的化学反应，Fluent提供了4种模拟反应的方法：通用有限速度模型、非预混合燃烧模型、预混和燃烧模型、部分预混和燃烧模型。本系统仅提供"+
                                      "通用有限速度模型，其它模型待更新...";
        public static string Species_OFF = "不开启组分运输模型";
        public static string Species_ON = "通用有限速度模型,该方法基于组分质量分数的运输方程，采用你所定义的化学反应机制，对化学反应进行模拟。反应速度在这种方法中是以源项的形式出现在组分运输方程中的，"+
                                          "计算反应速度有几种方法：从Arrhenius速度表达式计算，从Magnussen和Hjertager的漩涡耗散模型计算或者从EDC模型计算。这些模型的应用范围是非常广泛的，其中包括预混"+
                                           "和部分预混和以及非预混和燃烧。";
        public static string DiscretePhase = "离散相模型可以计算散布在流场中的粒子的运动和轨迹，例如在油气混合汽中，空气是连续相，而散布在空气中的细小的油滴则是离散相。连续相的计算可以用求解流场控制方程"+
                                             "的方式完成，而离散相的运动和轨迹则需要离散相模型进行计算。离散相模型实际上连续相和离散相物质相互作用的模型。在带有离散相模型的计算过程中，通常是先计算连续相流场，"+
                                             "再用流场变量通过离散相模型计算离散相粒子受到的作用力，并确定其运动轨迹。离散相计算是在拉格朗日观点下进行的；连续相计算是在欧拉观点下进行的。";
        public static string Materials = "在建立数学模型中非常关键的一步便是正确设定所研究物质的物性参数。设置物质参数包括：密度和分子量；粘度；比热；热传导系数；质量扩散系数；标准状态下的焓；分子动力论参数；"+
                                         "热力学条件和其他相关参数等。本系统提供一些常用的污染源物质等，占未提供自定义物质。";
        public static string BoundaryConditions = "边界条件就是流场变量在计算边界上应该满足的数学物理条件，边界条件与初始条件一起并称为定解条件，只有在边界条件和初始条件确定后，流场的解才存在，并且是唯一的。";
        public static string PressureInlet = "压力入口边界条件用于定义流场入口处的压强及其它标量函数。这种边界条件既适用于可压缩流计算也适用于不可压缩流计算。通常在入口处压强已知，而速度和流量未知时，就可以使用压强入口条件。"+
                                             "压力入口边界条件还可以用于具有自由边界的流场计算。";
        public static string VelocityInlet = "速度入口边界条件用入口处流场速度及其相关流动变量作为边界条件。在速度入口边界条件中，流场入口边界的驻点参数是不固定的。为了满足入口处的速度条件，驻点参数将在一定范围内波动。"+
                                             "\n速度入口条件仅适用于不可压缩流，如果用于可压缩流则可能导致非物流解。同时注意不要让速度入口条件过于靠近入口内侧的固体障碍物，这样会使驻点参数的不均匀程度大大增加。";
        public static string Mass_FlowInlet = "质量流入口边界条件，在已知流场入口处的流量时，可以通过定义质量流量或者质量通量分布的形式定义边界条件。这样定义的边界条件叫做质量流入口边界条件。在质量流量被设定的情况下，总压将随流场内部"+
                                              "压强场的变化而变化。\n如果流场在入口处的主要流动特征是质量流量保持不变，则适合采用质量流入口边界条件。但是因为流场入口总压的变化将直接影响计算的稳定性，所以在计算中应该尽量避免在流场的主要入口"+
                                              "处使用质量流边界条件。";
        public static string Mass_FlowOutlet = "质量流出口边界条件";
        public static string PressureOutlet = "压力出口边界条件在流场出口边界上定义静压，而金静压的值仅在流场为亚音速时使用。如果在出口边界上流场达到超音速，则边界上的压力将从流场内部通过插值得到,其它流场变量均从流场内部插值得到。\n"+
                                              "在压力出口边界上还需要定义\"回流(backflow)\"条件。回流条件是在压力出口边界上出现回流时使用的边界条件。推荐使用真实流场中的数据做回流条件，这样计算将更容易收敛。";

        public static string OutFlow = "出流边界条件。如果在流场求解前，流场出口处的流动速度和压强是未知的，就可以使用出流边界条件。除非计算中包含辐射换热、弥散相等问题，在出流边界条件上不需要定义任何参数，它使用流场内部变量通过插值得到出流边界上的变量值。"+
                                       "\n出流边界条件服从充分发展流动假设，即所有流动变量的扩散通量在出口边界的法向等于零。在出流边界存在很大的法向梯度，或者出现回流时不应使用出流边界条件。";

        public static string Wall = "壁面边界条件。使用无滑移条件作为缺省设置。";

        public static string FluidZone = "流体条件。流体区域是格网单元的集合，所有需要求解的方程都要在流体区域上被求解。流体区域上需要输入的唯一信息是流体的材料性质，即在计算之前必须指定流体区域中包含何种流体。在计算组分传输或燃烧问题时不需要选择材料，因为在组元计算中流体是由多种组元组成的。本系统中这些组元会在材料性质设定的同时进行设置。";

        public static string SolidZone = "固体条件。固体区域是这样一类格网的集合，在这个区域上只有热传导问题被求解，与流场相关的方程则无需在此求解。被设定为\"固体\"的区域实际上可能是流体，只是这个流体上被假定没有对流过程发生。在固体区域上需要输入的信息只有固体的材料性质。"+
                                         "必须指明固体的材料性质，以便计算中可以使用正确的材料信息。";
    }
}
