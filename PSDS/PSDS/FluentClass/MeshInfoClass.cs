using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobeCode.FluentClass
{
    /// <summary>
    /// 通过格网文件获取相关信息的类
    /// </summary>
    public class MeshInfoClass
    {
        /// <summary>
        /// 获取边界条件
        /// </summary>
        /// <param name="meshFilePath">mesh文件路径</param>
        /// <returns>[边界类型，边界名]</returns>
        public static List<string[]> GetBoundarys(string meshFilePath)
        {
            List<string[]> boundarys = new List<string[]>();
            string[] boundary;
            using (StreamReader sr = new StreamReader(meshFilePath))
            {

                string line;
                string[] lineSplit;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Length > 3 && line.Substring(0, 3).Equals("(45"))
                    {
                        lineSplit = line.Split(' ');
                        if (lineSplit[2].Equals("fluid") || lineSplit[2].Equals("solid"))
                            continue;
                        boundary = new string[2];
                        boundary[0] = lineSplit[2];
                        boundary[1] = lineSplit[3].Substring(0, lineSplit[3].IndexOf(')'));
                        boundarys.Add(boundary);
                    }
                }
            }
            return boundarys.OrderBy(o => o[0]).ToList();
        }
    }
}
