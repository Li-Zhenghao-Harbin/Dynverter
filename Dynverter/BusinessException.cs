using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynverter
{
    internal class BusinessException : ApplicationException
    {
        public enum ExceptionMessage
        {
            未检测到替换内容,
            end缺失,
            endif缺失,
            if后未检测到替换内容,
            choose后未检测到替换内容,
            choose参数数量错误,
            sql语句不合法
        }

        public BusinessException() { }

        public BusinessException(string message) : base(message)
        {
            FrmMain.exceptions.Add(new StringBuilder()
                .Append('[')
                .Append(DateTime.Now)
                .Append("] 错误：")
                .Append(message)
                .ToString());
        }

        public static string GetExceptionMessage(ExceptionMessage message) 
        { 
            return message.ToString();
        }
    }
}
