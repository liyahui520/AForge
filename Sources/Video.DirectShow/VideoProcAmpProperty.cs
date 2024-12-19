using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AForge.Video.DirectShow
{
    /// <summary>
    /// From VideoProcAmpProperty
    /// </summary>
    public enum VideoProcAmpProperty
    {
        /// <summary>
        /// 亮度
        /// </summary>
        Brightness,
        /// <summary>
        /// 对比度
        /// </summary>
        Contrast,
        /// <summary>
        /// 色相
        /// </summary>
        Hue,
        /// <summary>
        /// 饱和度
        /// </summary>
        Saturation,
        /// <summary>
        /// 清晰度
        /// </summary>
        Sharpness,
        /// <summary>
        /// 伽马
        /// </summary>
        Gamma,
        /// <summary>
        /// 启用颜色
        /// </summary>
        ColorEnable,
        /// <summary>
        /// 白平衡
        /// </summary>
        WhiteBalance,
        /// <summary>
        /// 逆光对比
        /// </summary>
        BacklightCompensation,
        /// <summary>
        /// 增益
        /// </summary>
        Gain
    }

    /// <summary>
    /// From VideoProcAmpFlags
    /// </summary>
    [Flags]
    public enum VideoProcAmpFlags
    {
        /// <summary>
        /// 默认
        /// </summary>
        None = 0,
        /// <summary>
        /// 自动
        /// </summary>
        Auto = 0x0001,
        /// <summary>
        /// 手动
        /// </summary>
        Manual = 0x0002
    }
}
