using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynverter.Matcher
{
    internal class ParameterMatcher : StringUtils
    {
        string sql;
        List<string> parameters = new List<string>();

        public ParameterMatcher(string sql, string parameterString)
        {
            this.sql = sql;
            parameters = GetParametersFromString(parameterString);
            Match();
        }

        private List<string> GetParametersFromString(string parameterString)
        {
            parameterString = parameterString
                .Replace("(String)", "")
                .Replace("(Integer)", "")
                .Replace("(BigDecimal)", "")
                .Replace("(Timestamp)", "");
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
            return parameters;
        }

        private void Match()
        {
            foreach (string parameter in parameters)
            {
                sql = sql.Replace("?", parameter.Trim());
            }
        }

        public string GetResult()
        {
            return sql;
        }
    }
}
