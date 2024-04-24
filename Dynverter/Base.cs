using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynverter
{
    internal class Base
    {
        // 缩进
        public string indent = "\t";
        public int indentLevel = 0;
        public enum OperateIndent
        {
            ADD_INDENT,
            REMOVE_INDENT
        }

        // 关键词
        public const char KEY_SPLITTER = '@';
        public const string KEY_COMMENT = "--";
        //public const string KEY_NONE = "---";

        // 构造词
        public const string KEY_COMMON = "--@";
        public const string KEY_IF = "--if@";
        public const string KEY_CHOOSE = "--choose@";
        public const string KEY_END = "--end@";
        public const string KEY_END_IF = "--end@if";

        public string[] END_KEYS = { KEY_END, KEY_END_IF };
        public string[] BUILD_KEYS = { KEY_COMMON, KEY_IF, KEY_CHOOSE, KEY_END, KEY_END_IF };

        // 生成词
        public const string VOC_IF = "if";
        public const string LABEL_IF_PRE = "<if";
        public const string LABEL_END_IF = "</if>";
        public const string LABEL_NEXT_END_IF = "\n</if>";

        public const string VOC_CHOOSE = "choose";
        public const string LABEL_CHOOSE_PRE = "<choose";
        public const string LABEL_CHOOSE = "<choose>\n";
        public const string LABEL_END_CHOOSE = "</choose>";
        public const string LABEL_NEXT_END_CHOOSE = "\n</choose>";

        public const string VOC_WHEN = "when";
        public const string LABEL_WHEN_PRE = "<when";
        public const string LABEL_END_WHEN = "</when>";
        public const string LABEL_NEXT_END_WHEN = "\n</when>";

        public const string VOC_OTHERWISE = "otherwise";
        public const string LABEL_OTHERWISE = "<otherwise>\n";
        public const string LABEL_END_OTHERWISE = "</otherwise>";
        public const string LABEL_NEXT_END_OTHERWISE = "\n</otherwise>";

        // 注释词
        public const string COM_BEGIN_PRE = "<!";
        public const string COM_BEGIN = "<!--";
        public const string COM_END = "-->";
        public const string COMM_BEGIN = "/*";
        public const string COMM_END = "*/";

        /*
         * 正向替换
         */
        // 是否替换关键词
        public static bool replaceCommon = true;
        public static bool replaceIf = true;
        public static bool replaceChoose = true;
        //public static bool replaceWhere = false;

        // 是否替换转义符
        public static bool replaceEscape = true;

        // 是否保留行注释
        public static bool retainAnnotations = true;

        // 是否生成缩进
        public static bool generateIndent = true;

        // 是否简化choose语句
        public static bool simplifyChoose = true;

        // 是否使用语法词'--end@'
        public static bool containsEnd = false;

        // 是否允许嵌套if语句（必须勾选"使用语法词'--end@'"）
        public static bool nestedIf = false;

        /*
         * 逆向替换
         */
        // 是否还原语句
        public static bool restoreCommon = true;
        public static bool restoreIf = true;
        public static bool restoreChoose = true;
    }
}
