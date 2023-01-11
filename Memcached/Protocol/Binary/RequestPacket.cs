using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2023) www.fayelf.com All Rights Reserved.       *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@fayelf.com                                     *
*  Site : www.fayelf.com                                        *
*  Create Time : 2023-01-11 08:42:07                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Memcached.Protocol.Binary
{
    /*
     Request header:

     Byte/     0       |       1       |       2       |       3       |
        /              |               |               |               |
       |0 1 2 3 4 5 6 7|0 1 2 3 4 5 6 7|0 1 2 3 4 5 6 7|0 1 2 3 4 5 6 7|
       +---------------+---------------+---------------+---------------+
      0| Magic         | Opcode        | Key length                    |
       +---------------+---------------+---------------+---------------+
      4| Extras length | Data type     | Reserved                      |
       +---------------+---------------+---------------+---------------+
      8| Total body length                                             |
       +---------------+---------------+---------------+---------------+
     12| Opaque                                                        |
       +---------------+---------------+---------------+---------------+
     16| CAS                                                           |
       |                                                               |
       +---------------+---------------+---------------+---------------+
       Total 24 bytes

   Header fields:

   Magic               Magic number.    协议版本号
   Opcode              Command code.    命令码
   Key length          Length in bytes of the text key that follows the
                       command extras.  以字节为单位文本长度
   Status              Status of the response (non-zero on error).  响应的状态（出错时为非零）。
   Extras length       Length in bytes of the command extras.   额外命令的字节长度。
   Data type           Reserved for future use (Sean is using this soon).   保留供将来使用（Sean很快就会使用）。
   Reserved            Really reserved for future use (up for grabs).  留作将来使用
   Total body length   Length in bytes of extra + key + value.  额外+键+值的字节长度。
   Opaque              Will be copied back to you in the response.  将在响应中复制回您。
   CAS                 Data version check.  数据版本检查。
     */
    /// <summary>
    /// 请求包
    /// </summary>
    public class RequestPacket
    {
        #region 构造器
        /// <summary>
        /// 设置命令
        /// </summary>
        /// <param name="commandType">请求类型</param>
        public RequestPacket(CommandType commandType)
        {
            CommandType = commandType;
            var dval = "";
            switch(commandType.Flags)
            {
                case CommandFlags.Get:
                    var get = commandType.Index.ToEnum<GetCommand>();
                    dval = get.GetDefaultValue();
                    break;
                case CommandFlags.Store:
                    var store = commandType.Index.ToEnum<StoreCommand>();
                    dval = store.GetDefaultValue();
                    break;
                case CommandFlags.Stats:
                    var stats = commandType.Index.ToEnum<StatsCommand>();
                    dval = stats.GetDefaultValue();
                    break;
            }
            if(dval.IsNullOrEmpty()) throw new MemcachedException("暂不支持当前命令.");
            this.OpCode = dval.ToCast<byte>().ToEnum<OperationCode>();
        }
        /// <summary>
        /// 设置请求码
        /// </summary>
        /// <param name="opCode">请求码</param>
        public RequestPacket(OperationCode opCode)
        {
            this.OpCode = opCode;
        }
        #endregion

        #region 属性
        /// <summary>
        /// 请求头
        /// </summary>
        private byte[] Header { get; set; } = new byte[24];
        /// <summary>
        /// 协议版本
        /// </summary>
        private byte Magic { get; set; } = 0x80;
        /// <summary>
        /// 命令类型
        /// </summary>
        private CommandType CommandType { get; set; }
        /// <summary>
        /// 操作码
        /// </summary>
        private OperationCode OpCode { get; set; }
        #endregion

        #region 方法
        /// <summary>
        /// 创建请求包
        /// </summary>
        /// <returns></returns>
        public byte[] CreateBuffer()
        {

            return null;
        }
        #endregion
    }
}