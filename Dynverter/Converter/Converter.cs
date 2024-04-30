using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynverter
{
    internal class Converter : StringUtils
    {
        string sql = "";
        List<string> sentences;
        int sentencesCount;
        Stack<string> stack = new Stack<string>();

        public Converter(string str)
        {
            sql = str;
            sentences = sql.Split('\n').ToList();
            sentencesCount = sentences.Count;
            ReplaceComments();
        }

        public void ReplaceComments()
        {
            for (int i = 0; i < sentencesCount; i++)
            {
                int commitIndex = GetValidSentence(sentences[i]).IndexOf(KEY_COMMENT);
                if (CheckPrefix(sentences[i], KEY_COMMENT) && !CheckPrefixInArray(sentences[i], BUILD_KEYS))
                {
                    if (retainAnnotations)
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder
                            .Append(COM_BEGIN_PRE)
                            .Append(sentences[i])
                            .Append(COM_END);
                        sentences[i] = stringBuilder.ToString();
                    }
                    else
                    {
                        sentences[i] = "";
                    }
                }
                else if (commitIndex > 0)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder
                        .Append(sentences[i].Substring(0, commitIndex))
                        .Append(COM_BEGIN_PRE)
                        .Append(sentences[i].Substring(commitIndex))
                        .Append(COM_END);
                    sentences[i] = stringBuilder.ToString();
                }
                // 区域注释替换
                sentences[i] = sentences[i]
                    .Replace(COMM_BEGIN, COM_BEGIN)
                    .Replace(COMM_END, COM_END);
            }
        }

        public void ReplaceSentence()
        {
            for (int i = 0; i < sentencesCount; i++)
            {
                if (CheckPrefix(sentences[i], KEY_COMMON))
                {
                    try
                    {
                        if (i + 1 >= sentencesCount)
                        {
                            throw new BusinessException(10001);
                        }
                        sentences[i + 1] = GetValidSentence(sentences[i]);
                        sentences[i] = "";
                    }
                    catch (Exception) { }
                }
            }
        }

        public void ReplaceIf()
        {
            for (int i = 0; i < sentencesCount; i++)
            {
                if (CheckPrefix(sentences[i], KEY_IF))
                {
                    try
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        // where检测
                        //if (stack.Count == 0 && !replaceWhere)
                        //{
                        //    stringBuilder.Append("1 = 1\n");
                        //}
                        string validSentence = GetValidSentence(sentences[i]);
                        if (validSentence.Contains(KEY_SPLITTER))
                        {
                            int splitterIndex = validSentence.IndexOf(KEY_SPLITTER);
                            stringBuilder.Append(
                                OutputCustomizedValues(
                                    VOC_IF,
                                    validSentence.Substring(0, splitterIndex),
                                    GetSentenceWithIndent(
                                        OperateIndent.ADD_INDENT,
                                        ReplaceParticularWords(validSentence.Substring(splitterIndex + 1))
                                        )
                                    )
                                );
                        }
                        else
                        {
                            stringBuilder
                                .Append(OutputCheckValues(VOC_IF, sentences[i]))
                                .Append(GetSentenceWithIndent(
                                    OperateIndent.ADD_INDENT,
                                    ReplaceParticularWords(validSentence)
                                    ));
                        }
                        // end检测
                        if (containsEnd)
                        {
                            for (int j = i + 1; j < sentencesCount; j++)
                            {
                                if (nestedIf)
                                {
                                    if (GetSentence(sentences[j]) == KEY_END_IF)
                                    {
                                        sentences[j] = GetSentenceWithIndent(OperateIndent.REMOVE_INDENT, LABEL_END_IF);
                                        break;
                                    }
                                    if (j == sentencesCount - 1)
                                    {
                                        throw new BusinessException(10002);
                                    }
                                }
                                else
                                {
                                    if (GetSentence(sentences[j]) == KEY_END || GetSentence(sentences[j]) == KEY_END_IF)
                                    {
                                        sentences[j] = GetSentenceWithIndent(OperateIndent.REMOVE_INDENT, LABEL_END_IF);
                                        break;
                                    }
                                    if (j == sentencesCount - 1)
                                    {
                                        throw new BusinessException(10001);
                                    }
                                    sentences[j] = "";
                                }
                            }
                        }
                        // if替换
                        stack.Push(VOC_IF);
                        if (i + 1 >= sentencesCount)
                        {
                            throw new BusinessException(10003);
                        }
                        sentences[i + 1] = containsEnd ? stringBuilder.ToString() : stringBuilder.Append(GetSentenceWithIndent(OperateIndent.REMOVE_INDENT, LABEL_NEXT_END_IF)).ToString();
                        sentences[i] = "";
                    }
                    catch (Exception) { }
                }
            }
        }

        public void ReplaceChoose()
        {
            for (int i = 0; i < sentencesCount; i++)
            {
                if (CheckPrefix(sentences[i], KEY_CHOOSE))
                {
                    try
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        // where检测
                        //if (stack.Count == 0 && !replaceWhere)
                        //{
                        //    stringBuilder.Append("1 = 1\n");
                        //}
                        stringBuilder.Append(LABEL_CHOOSE);
                        // otherwise检测
                        bool containsOtherwise = GetValidSentence(sentences[i]).Last() == KEY_SPLITTER;
                        sentences[i] = containsOtherwise ? sentences[i].Substring(0, sentences[i].Length - 1) : sentences[i];
                        string[] subSentences = GetValidSentence(sentences[i]).Split(KEY_SPLITTER);
                        // end检测
                        if (containsEnd)
                        {
                            for (int j = i + 1; j < sentencesCount; j++)
                            {
                                if (GetSentence(sentences[j]) == KEY_END)
                                {
                                    sentences[j] = LABEL_END_CHOOSE;
                                    break;
                                }
                                if (j == sentencesCount - 1)
                                {
                                    throw new BusinessException(10001);
                                }
                                sentences[j] = "";
                            }
                        }
                        // when/otherwise生成
                        int m = subSentences.Length;
                        // 根据是否包含otherwise判断合法参数数量
                        if (!simplifyChoose && ((containsOtherwise && (m & 1) == 0) || (!containsOtherwise && (m & 1) == 1)))
                        {
                            throw new BusinessException(10005);
                        }
                        for (int j = 0; j < m; j++)
                        {
                            if (j > 0)
                            {
                                stringBuilder.AppendLine();
                            }
                            // <when test=?> / <otherwise>
                            if (containsOtherwise && j == m - 1)
                            {
                                stringBuilder.Append(LABEL_OTHERWISE);
                            }
                            else
                            {
                                if (simplifyChoose)
                                {
                                    stringBuilder.Append(OutputCheckValues(
                                        VOC_WHEN, 
                                        ReplaceParticularWords(subSentences[j])
                                        ));
                                }
                                else if (!simplifyChoose && subSentences[j] == "")
                                {
                                    stringBuilder.Append(OutputCheckValues(
                                        VOC_WHEN,
                                        ReplaceParticularWords(subSentences[++j])
                                        ));
                                }
                                else
                                {
                                    stringBuilder.Append(OutputCustomizedValues(
                                        VOC_WHEN,
                                        subSentences[j++]
                                        ));
                                }
                            }
                            stringBuilder
                                .Append(GetSentenceWithIndent(
                                    OperateIndent.ADD_INDENT,
                                    ReplaceParticularWords(subSentences[j])
                                    ))
                                // </when> / </otherwise>
                                .Append(GetSentenceWithIndent(
                                    OperateIndent.REMOVE_INDENT,
                                    containsOtherwise && j == m - 1 ? LABEL_NEXT_END_OTHERWISE : LABEL_NEXT_END_WHEN
                                    ));
                        }
                        // choose生成
                        stack.Push(VOC_CHOOSE);
                        if (i + 1 >= sentencesCount)
                        {
                            throw new BusinessException(10004);
                        }
                        sentences[i + 1] = containsEnd ? stringBuilder.ToString() : stringBuilder.Append(LABEL_NEXT_END_CHOOSE).ToString();
                        sentences[i] = "";
                    }
                    catch (Exception) { }
                }
            }
        }

        public void ReplaceWhere()
        {
            for (int i = 0; i < sentencesCount; i++)
            {
                if (CheckPrefix(sentences[i], "where"))
                {
                    string t = sentences[i].Substring(5);
                    StringBuilder stringBuilder = new StringBuilder();
                    sentences[i] = stringBuilder
                        .Append("<where>")
                        .Append(t)
                        .ToString();
                    stack.Push("where");
                }
            }
        }

        private string CombineSql(List<string> sentences)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string s in sentences)
            {
                if (s != "")
                {
                    stringBuilder
                        .Append(s)
                        .AppendLine();
                }
            }
            return stringBuilder.ToString();
        }

        public string GetResult()
        {
            return CombineSql(sentences);
        }
    }
}
