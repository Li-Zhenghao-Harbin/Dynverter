using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynverter
{
    internal class StringUtils : Base
    {
        protected string GetRealSentence(string str)
        {
            return str.TrimStart(new char[] { ' ', '\t' });
        }

        protected string ReplaceByCaseInsensitive(string origin, string match, string replacement = "")
        {
            int position = origin.ToUpper().IndexOf(match);
            return position != -1 ? origin.Remove(position).Insert(position, replacement) : origin;
        }

        /*
         * 前缀
         */
        protected bool CheckPrefix(string str, string prefix)
        {
            str = GetRealSentence(str);
            if (str.Length < prefix.Length)
            {
                return false;
            }
            return str.Substring(0, prefix.Length).Equals(prefix);
        }

        protected bool CheckPrefixInArray(string str, string[] prefixs)
        {
            str = GetRealSentence(str);
            foreach (string prefix in prefixs)
            {
                int length = prefix.Length;
                if (str.Length < length)
                {
                    continue;
                }
                if (str.Substring(0, length).Equals(prefix))
                {
                    return true;
                }
            }
            return false;
        }

        /*
         * 语句
         */
        protected string GetSentence(string str)
        {
            int idx = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ' && str[i] != '\t')
                {
                    idx = i; 
                    break;
                }
            }
            return str.Substring(idx);
        }

        protected string GetValidSentence(string str)
        {
            return str.Substring(str.IndexOf(KEY_SPLITTER) + 1);
        }

        /*
         * 缩进
         */
        protected string GetSentenceWithIndent(OperateIndent operateIndent, string str = null)
        {
            if (!generateIndent)
            {
                return str;
            }
            StringBuilder stringBuilder = new StringBuilder();
            if (operateIndent == OperateIndent.ADD_INDENT)
            {
                indentLevel++;
            }
            else if (operateIndent == OperateIndent.REMOVE_INDENT)
            {
                indentLevel--;
            }
            int level = indentLevel;
            while (level-- > 0)
            {
                stringBuilder.Append(indent);
            }
            if (str != null)
            {
                stringBuilder.Append(str);
            }
            return stringBuilder.ToString();
        }

        /*
         * 关键词
         */
        protected string ReplaceParticularWords(string str)
        {
            if (replaceEscape)
            {
                str = str
                    .Replace(">", "&gt;")
                    .Replace("<", "&lt;");
                    //.Replace("&", "&amp;")
                    //.Replace("\'", "&apos;")
                    //.Replace("\"", "&quot;");
            }
            return str;
        }

        protected bool ContainsValues(string str)
        {
            int left = str.IndexOf("#{"), right = str.IndexOf('}');
            return left != -1 && right != -1 && right >= left - 1;
        }

        // debug
        private List<string> GetValues(string str)
        {
            List<string> keys = new List<string>();
            int left = 0, right;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '{')
                {
                    left = i + 1;
                }
                else if (str[i] == '}')
                {
                    right = i;
                    keys.Add(str.Substring(left, right - left));
                }
            }
            return keys;
        }

        protected string OutputCheckValues(string key, string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            List<string> keys = GetValues(str);
            stringBuilder
                .Append("<")
                .Append(key)
                .Append(keys.Count == 0 ? ">" : " test = \"") ;
            for (int i = 0; i < keys.Count; i++)
            {
                if (i > 0)
                {
                    stringBuilder.Append(" and ");
                }
                stringBuilder
                    .Append(keys[i])
                    .Append(" != null and ")
                    .Append(keys[i])
                    .Append(" != \'\'");
            }
            stringBuilder.Append(keys.Count == 0 ? "\n" : "\">\n");
            return stringBuilder.ToString();
        }

        protected string OutputCustomizedValues(string key, string condition, string str = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder
                .Append("<")
                .Append(key)
                .Append(" test = \"")
                .Append(condition)
                .Append("\">\n");
            if (str != null)
            {
                stringBuilder.Append(ReplaceParticularWords(str));
            }
            return stringBuilder.ToString();
        }

        /*
         * 标签
         */
        // 如果str的前缀prefix存在，则返回双引号中的内容content。例：<if test="XX">返回XX
        protected bool GetLabelContentFromGivenPrefix(string str, string prefix, out string content)
        {
            content = "";
            if (CheckPrefix(str, prefix) && str.Last() == '>')
            {
                int beginIndex = str.IndexOf('\"');
                int contentLength = str.LastIndexOf('\"') - beginIndex - 1;
                content = contentLength > 0 ? str.Substring(beginIndex + 1, contentLength) : "";
                return true;
            }
            return false;
        }
    }
}
