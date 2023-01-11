using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/****************************************************************
*  Copyright © (2023) www.fayelf.com All Rights Reserved.       *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@fayelf.com                                     *
*  Site : www.fayelf.com                                        *
*  Create Time : 2023-01-11 09:08:09                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Memcached.Protocol.Binary
{
    /// <summary>
    /// 响应码
    /// </summary>
    public enum ResultStatus : byte
    {
        /// <summary>
        /// 正常
        /// </summary>
        [Description("no error")]
        NoError = 0x0000,
        /// <summary>
        /// Key不存在
        /// </summary>
        [Description("Key not found")]
        NotFound = 0x0001,
        /// <summary>
        /// Key已存在
        /// </summary>
        [Description("Key exists")]
        Exists = 0x0002,
        /// <summary>
        /// 值太长
        /// </summary>
        [Description("Value too large")]
        TooLarge = 0x0003,
        /// <summary>
        /// 参数无效
        /// </summary>
        [Description("Invalid arguments")]
        Invalid = 0x0004,
        /// <summary>
        /// 项没有存储
        /// </summary>
        [Description("Item not stored")]
        NotSored = 0x0005,
        /// <summary>
        /// 递增或递增值不是数字
        /// </summary>
        [Description("Incr/Decr on non-numeric value")]
        NonNumeric = 0x0006,
        /// <summary>
        /// 认证错误
        /// </summary>
        [Description("Authentication error")]
        AuthError = 0x0008,
        /// <summary>
        /// 认证继续
        /// </summary>
        [Description("Authentication continue")]
        AuthContinue = 0x009,
        /// <summary>
        /// 未知命令
        /// </summary>
        [Description("Unknown command")]
        Unknown = 0x0081,
        /// <summary>
        /// 内存溢出
        /// </summary>
        [Description("Out of memory")]
        OutMemory = 0x0082,
        /// <summary>
        /// 不支持
        /// </summary>
        [Description("No support")]
        NoSupport = 0x0083,
        /// <summary>
        /// 内部错误
        /// </summary>
        [Description("internal error")]
        InternalError = 0x0084,
        /// <summary>
        /// 忙
        /// </summary>
        [Description("Busy")]
        Busy = 0x0085,
        /// <summary>
        /// 暂时性错误
        /// </summary>
        [Description("Transient error")]
        TransientError = 0x0086
    }
}