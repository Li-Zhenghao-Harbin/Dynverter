using System;
using System.Collections.Generic;
using System.Text;

namespace Dynverter
{
    internal class BusinessException : ApplicationException
    {
        readonly private Dictionary<int, string> exceptionMessage = new Dictionary<int, string>()
        {
            { 10000, "未检测到替换内容"},
            { 10001, "end缺失"},
            { 10002, "endif缺失"},
            { 10003, "if后未检测到替换内容" },
            { 10004, "choose后未检测到替换内容"},
            { 10005, "choose参数数量错误"},
            { 20000, "sql语句不合法"},
            { 30000, "自动匹配内容格式不正确"},
            { 99999, "系统异常" },
        };

        public BusinessException(int errorCode) : base(errorCode.ToString())
        {
            FrmMain.exceptions.Add(new StringBuilder()
                .Append('[')
                .Append(DateTime.Now)
                .Append("] 错误")
                //.Append(errorCode)
                .Append(": ")
                .Append(GetExceptionMessageByErrorCode(errorCode))
                .ToString());
        }

        private string GetExceptionMessageByErrorCode(int errCode)
        {
            return exceptionMessage[errCode];
        }
    }
}
