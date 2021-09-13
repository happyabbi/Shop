using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Infrastucture.Model
{
    public enum SystemCommandEnum
    {
        /// <summary>
        /// 关闭
        /// </summary>
        Close,
        /// <summary>
        /// 最大化
        /// </summary>
        Max,
        /// <summary>
        /// 最小化
        /// </summary>
        Min,
        /// <summary>
        /// 还原
        /// </summary>
        Restore,
        /// <summary>
        /// 收起菜单
        /// </summary>
        ShrinkMenu,
        /// <summary>
        /// 展开菜单
        /// </summary>
        SpreadMenu,
    }
}
