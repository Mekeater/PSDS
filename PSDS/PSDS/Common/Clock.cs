using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobeCode.Common
{
    /// <summary>
    /// 计时器类
    /// </summary>
    public class Clock
    {
        private Stopwatch clock;

        public Clock()
        {
            this.clock = new Stopwatch();
        }

        //开启计时器
        public void StartClock()
        {
            this.clock.Start();
        }

        //终止计时器
        public void StopClock()
        {
            this.clock.Stop();
        }

        //重启计时器
        public void ReStartClock()
        {
            this.clock.Restart();
        }

        //重置计时器
        public void ResetClock()
        {
            this.clock.Reset();
        }

        //获取计时器秒数
        public string RunTime()
        {
            return (this.clock.ElapsedMilliseconds / 1000.0).ToString();
        }
    }
}
