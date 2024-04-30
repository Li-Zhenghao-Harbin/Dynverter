using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynverter.Matcher
{
    internal class ParameterMatcher : StringUtils
    {
        string sql;
        List<string> parameters = new List<string>();

        public ParameterMatcher(string sql, string parameterString)
        {
            this.sql = sql;
            parameters = GetParameters(parameterString);
            Match();
        }

        private List<string> GetParameters(string parameterString)
        {
            parameterString = parameterString.Replace(" ", "");
            List<string> parameters = new List<string>();
            const char splitter = ',';
            if (parameterString != null)
            {
                if (parameterString.Contains(splitter))
                {
                    parameters = parameterString.Split(splitter).ToList();
                }
                else
                {
                    parameters.Add(parameterString);
                }
            }
            // 参数转换成字符串类型
            string[] particularParameterType = new string[] { "(STRING)", "(TIMESTAMP)" };
            string[] commomPararmeterType = new string[] { "(BIGDECIMAL)", "(INTEGER)" };
            for (int i = 0; i < parameters.Count; i++)
            {
                for (int j = 0; j < particularParameterType.Length; j++)
                {
                    int parameterTypePosition = parameters[i].Length - particularParameterType[j].Length; // 获取参数位置
                    if (parameters[i].Length >= particularParameterType[j].Length &&
                        parameters[i].Substring(parameterTypePosition).ToUpper() == particularParameterType[j])
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder
                            .Append("\"")
                            .Append(ReplaceByCaseInsensitive(parameters[i], particularParameterType[j]))
                            .Append("\"");
                        parameters[i] = stringBuilder.ToString();
                    }
                    else
                    {
                        foreach (string p in commomPararmeterType)
                        {
                            parameters[i] = ReplaceByCaseInsensitive(parameters[i], p);
                        }
                    }
                }
            }
            return parameters;
        }

        private int GetTargetParametersCount()
        {
            int targetCount = 0;
            for (int i = 0; i < sql.Length; i++)
            {
                if (sql[i] == '?')
                {
                    targetCount++;
                }
            }
            return targetCount;
        }

        private string SetWarningContent()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder
                .Append("期望参数：")
                .Append(GetTargetParametersCount())
                .Append("；实际参数：")
                .Append(parameters.Count);
            return stringBuilder.ToString();
        }

        private void Match()
        {
            int targetParmetersCount = GetTargetParametersCount();
            int actualParametersCount = parameters.Count();
            if (targetParmetersCount > actualParametersCount)
            {
                new BusinessWarning(10001, SetWarningContent());
            }
            else if (targetParmetersCount < actualParametersCount)
            {
                new BusinessWarning(10002, SetWarningContent());
            }
            Regex regex = new Regex("[?]");
            foreach (string parameter in parameters)
            {
                sql = regex.Replace(sql, parameter.Trim(), 1);
            }
        }

        public string GetResult()
        {
            return sql;
        }
    }
}
