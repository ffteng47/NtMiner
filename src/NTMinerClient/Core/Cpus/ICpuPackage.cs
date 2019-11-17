﻿using System;

namespace NTMiner.Core.Cpus {
    /// <summary>
    /// 指的是整个CPU包，而不是单个CPU核。
    /// </summary>
    public interface ICpuPackage {
        void Start();
        /// <summary>
        /// CPU使用率百分比。百分号前面的部分
        /// </summary>
        int Performance { get; }
        int Temperature { get; }

        DateTime LowPerformanceOn { get; set; }

        DateTime HighTemperatureOn { get; set; }
        DateTime LowTemperatureOn { get; set; }
    }
}
