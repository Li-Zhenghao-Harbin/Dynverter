using System;
using System.Collections.Generic;
using System.Text;

namespace Dynverter
{
    internal class BusinessWarning// : ApplicationException
    {
        readonly private Dictionary<int, string> warningMessage = new Dictionary<int, string>()
        {
            { 10001, "匹配参数过少" },
            { 10002, "匹配参数过多" }
        };

        public BusinessWarning(int warningCode, string content = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder
                .Append("[")
                .Append(DateTime.Now)
                .Append("] 警告")
                //.Append(warningCode)
                .Append(": ")
                .Append(GetWarningMessageByErrorCode(warningCode));
            if (content != null)
            {
                stringBuilder
                    .Append("。")
                    .Append(content);
            }
            FrmMain.warnings.Add(stringBuilder.ToString());
        }

        private string GetWarningMessageByErrorCode(int warningCode)
        {
            return warningMessage[warningCode];
        }
    }
}
