using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2023) www.fayelf.com All Rights Reserved.       *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@fayelf.com                                     *
*  Site : www.fayelf.com                                        *
*  Create Time : 2023-01-11 08:49:59                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Memcached.Protocol.Binary
{
    /// <summary>
    /// 命令码
    /// </summary>
    public enum OperationCode : byte
    {
        /// <summary>
        /// Get
        /// </summary>
        Get = 0x00,
        /// <summary>
        /// Set
        /// </summary>
        Set = 0x01,
        /// <summary>
        /// Add
        /// </summary>
        Add = 0x02,
        /// <summary>
        /// Replace
        /// </summary>
        Replace = 0x03,
        /// <summary>
        /// Delete
        /// </summary>
        Delete = 0x04,
        /// <summary>
        /// 递增
        /// </summary>
        Increment = 0x05,
        /// <summary>
        /// 递减
        /// </summary>
        Decrement = 0x06,
        /// <summary>
        /// 退出
        /// </summary>
        Quit = 0x07,
        /// <summary>
        /// Flush
        /// </summary>
        Flush = 0x08,
        /// <summary>
        /// GetQ
        /// </summary>
        GetQ = 0x09,
        /// <summary>
        /// No-op
        /// </summary>
        NoOp = 0x0A,
        /// <summary>
        /// 版本
        /// </summary>
        Version = 0x0B,
        /// <summary>
        /// GetK
        /// </summary>
        GetK = 0x0C,
        /// <summary>
        /// GetKQ
        /// </summary>
        GetKQ = 0x0D,
        /// <summary>
        /// 附加后边
        /// </summary>
        Append = 0x0E,
        /// <summary>
        /// 附加到前边
        /// </summary>
        Prepend = 0x0F,
        /// <summary>
        /// 统计
        /// </summary>
        Stat = 0x10,
        /// <summary>
        /// SetQ
        /// </summary>
        SetQ = 0x11,
        /// <summary>
        /// AddQ
        /// </summary>
        AddQ = 0x12,
        /// <summary>
        /// ReplaceQ
        /// </summary>
        ReplaceQ = 0x13,
        /// <summary>
        /// DeleteQ
        /// </summary>
        DeleteQ = 0x14,
        /// <summary>
        /// IncrementQ
        /// </summary>
        IncrementQ = 0x15,
        /// <summary>
        /// DecrementQ
        /// </summary>
        DecrementQ = 0x16,
        /// <summary>
        /// QuitQ
        /// </summary>
        QuitQ = 0x17,
        /// <summary>
        /// FlushQ
        /// </summary>
        FlushQ = 0x18,
        /// <summary>
        /// AppendQ
        /// </summary>
        AppendQ = 0x19,
        /// <summary>
        /// PrependQ
        /// </summary>
        PrependQ = 0x1A,
        /// <summary>
        /// SaslList
        /// </summary>
        SaslList = 0x20,
        /// <summary>
        /// SaslStart
        /// </summary>
        SaslStart = 0x21,
        /// <summary>
        /// SaslStep
        /// </summary>
        SaslStep = 0x22,
        /// <summary>
        /// Rget
        /// </summary>
        RGet = 0x30,
        /// <summary>
        /// RSet
        /// </summary>
        RSet = 0x31,
        /// <summary>
        /// RSetQ
        /// </summary>
        RSetQ = 0x32,
        /// <summary>
        /// RAppend
        /// </summary>
        RAppend = 0x33,
        /// <summary>
        /// RAppendQ
        /// </summary>
        RAppendQ = 0x34,
        /// <summary>
        /// RPrepend
        /// </summary>
        RPrepend = 0x35,
        /// <summary>
        /// RPrependQ
        /// </summary>
        RPrependQ = 0x36,
        /// <summary>
        /// RDelete
        /// </summary>
        RDelete = 0x37,
        /// <summary>
        /// RDeleteQ
        /// </summary>
        RDeleteQ = 0x38,
        /// <summary>
        /// RIncr
        /// </summary>
        RIncr = 0x39,
        /// <summary>
        /// RIncrQ
        /// </summary>
        RIncrQ= 0x3A,
        /// <summary>
        /// RDecr
        /// </summary>
        RDecr = 0x3B,
        /// <summary>
        /// RDecrQ
        /// </summary>
        RDecrQ = 0x3C
    }
}