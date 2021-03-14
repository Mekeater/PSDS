using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobeCode.DataStruct
{
    public interface IJournal
    {
        //写入journal文件的各个部分的接口
        void write_Solver();
        void write_Model();
        void write_Materials();
        void write_Boundary();
        void write_Method();
        void write_Initiallization();
        void write_Calculation();
        void write_ResultDataExport();
    }
}
