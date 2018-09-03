using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eblcu.Bi
{
    public class ResultJsonObj
    {

        /// <summary>
        /// 接口返回数据
        /// </summary>
        /// <param name="responseNum"> -1失败，0：成功</param>
        public ResultJsonObj(int responseNum)
        {
            ResponseNum = responseNum;
        }

        /// <summary>
        /// 接口返回数据
        /// </summary>
        /// <param name="resultObj">数据</param>
        public ResultJsonObj(object resultObj)
        {
            ResponseNum = 0;
            ResultObj = resultObj;
        }

        /// <summary>
        /// 接口返回数据
        /// </summary>
        /// <param name="responseNum"> -1失败，0：成功</param>
        /// <param name="message"> 消息</param>
        public ResultJsonObj(int responseNum, string message)
        {
            ResponseNum = responseNum;
            Message = message;
        }


        /// <summary>
        /// 接口返回数据
        /// </summary>
        /// <param name="responseNum"> -1失败，0：成功</param>
        /// <param name="errorCode"> 错误代码</param>
        /// <param name="message">消息</param>
        /// <param name="resultObj">数据</param>
        public ResultJsonObj(int responseNum, string errorCode, string message, object resultObj)
        {
            ResponseNum = responseNum;
            ErrorCode = errorCode;
            Message = message;
            ResultObj = resultObj;
        }

        /// <summary>
        ///  -1失败，0：成功
        /// </summary>
        public int ResponseNum { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        public string ErrorCode { get; set; }

        public string Message { get; set; }

        public object ResultObj { get; set; }

        public ResultJsonObj()
        {
            ResultObj = new object();
        }
    }
}
