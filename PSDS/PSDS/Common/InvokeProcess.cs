using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobeCode.Common
{
    /// <summary>
    /// 进程调用类
    /// </summary>
    public class InvokeProcess
    {
        /// <summary>
        /// 启动指定进程
        /// </summary>
        /// <param name="processPath">进程绝对路径</param>
        /// <param name="command">进程执行命令</param>
        public static Process startProcess(string processPath, string command)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = processPath;
                p.StartInfo.Arguments = command;

                //辅助设置
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true; //不创建窗口
                p.Start();
                Console.WriteLine(p.StandardOutput.ReadToEnd());
                return p;
            }
            catch(Exception ex)
            {
                MessageBox.Show("进程启动失败\n"+ex.Message.ToString(),"提示");
                return null;
            }
            
        }
    }
}
