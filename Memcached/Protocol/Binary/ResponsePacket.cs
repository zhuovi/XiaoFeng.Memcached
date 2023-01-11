using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2023) www.fayelf.com All Rights Reserved.       *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@fayelf.com                                     *
*  Site : www.fayelf.com                                        *
*  Create Time : 2023-01-11 08:44:02                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Memcached.Memcached.Protocol.Binary
{
    /*
     Response header:

     Byte/     0       |       1       |       2       |       3       |
        /              |               |               |               |
       |0 1 2 3 4 5 6 7|0 1 2 3 4 5 6 7|0 1 2 3 4 5 6 7|0 1 2 3 4 5 6 7|
       +---------------+---------------+---------------+---------------+
      0| Magic         | Opcode        | Key Length                    |
       +---------------+---------------+---------------+---------------+
      4| Extras length | Data type     | Status                        |
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
    /// 响应包
    /// </summary>
    public class ResponsePacket
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public ResponsePacket()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 响应头数据
        /// </summary>
        private byte[] Header { get; set; } = new byte[24];
        /// <summary>
        /// 协议版本
        /// </summary>
        private byte Magic { get; set; } = 0x80;
        #endregion

        #region 方法

        #endregion
    }
}