using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Dynverter
{
    internal class RConverter : StringUtils
    {
        string target = "";
        List<string> sentences;
        int sentencesCount;

        public RConverter(string str)
        {
            target = str;
            RestoreSuffix();
            RestoreComments();
            sentences = target.Split('\n').ToList();
            sentencesCount = sentences.Count;
            FormateKeys();
        }

        // 移除构造词前的空格
        private void FormateKeys()
        {
            for (int i = 0; i < sentencesCount; i++)
            {
                if (END_KEYS.Contains(GetRealSentence(sentences[i])))
                {
                    sentences[i] = GetRealSentence(sentences[i]);
                }
            }
        }

        public void RestoreComments()
        {
            target = target
                .Replace(COM_BEGIN, COMM_BEGIN)
                .Replace(COM_END, COMM_END);
        }

        public void RestoreSuffix()
        {
            if (restoreIf)
            {
                target = target.Replace(LABEL_END_IF, KEY_END_IF);
            }
            if (restoreChoose)
            {
                target = target.Replace(LABEL_END_CHOOSE, KEY_END);
            }
            target = target
                .Replace(LABEL_END_WHEN, "")
                .Replace(LABEL_END_OTHERWISE, "");
        }

        public void RestoreCommon()
        {
            for (int i = 0; i < sentencesCount; i++)
            {
                if (!CheckPrefixInArray(sentences[i], BUILD_KEYS) && ContainsValues(sentences[i]))
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder
                        .Append(KEY_COMMON)
                        .Append(GetRealSentence(sentences[i]))
                        .AppendLine();
                    if (retainReplacedSentence)
                    {
                        stringBuilder.Append(sentences[i]);
                    }
                    sentences[i] = stringBuilder.ToString();
                }
            }
        }

        public void RestoreIf()
        {
            for (int i = 0; i < sentencesCount; i++)
            {
                if (GetLabelContentFromGivenPrefix(sentences[i], LABEL_IF_PRE, out string content))
                {
                    try
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder
                            .Append(KEY_IF)
                            .Append(content)
                            .Append(KEY_SPLITTER);

                        if (i + 1 < sentencesCount)
                        {
                            string preSentence = GetRealSentence(sentences[i + 1]);
                            if (CheckPrefix(preSentence, COMM_BEGIN)) // 还原时跳过注释词（或生成词）
                            {
                                stringBuilder
                                    .AppendLine()
                                    .AppendLine()
                                    .Append(GetRealSentence(sentences[i + 1]));
                                sentences[i + 1] = "";
                            }
                            else
                            {
                                stringBuilder.Append(GetRealSentence(sentences[i + 1]));
                                sentences[i + 1] = indent;
                            }
                        }
                        else
                        {
                            throw new BusinessException(20000);
                        }
                        sentences[i++] = stringBuilder.ToString();
                        // 删除<if>后直到</if>的内容
                        if (GetLineIndexOfNextStr(sentences, KEY_END_IF, i + 1, out List<int> nextEndIfIndexArray))
                        {
                            int nestedIfCount = 0;
                            for (int j = i + 1; j < nextEndIfIndexArray[nestedIfCount]; j++)
                            {
                                // 避开删除嵌套的<if>
                                if (!CheckPrefix(sentences[j], LABEL_IF_PRE))
                                {
                                    // 保留</if>
                                    if (!CheckPrefix(sentences[j], KEY_END_IF))
                                    {
                                        sentences[j] = "";
                                    }
                                }
                                else
                                {
                                    nestedIfCount++; // 检测到嵌套的<if>标签，需要继续处理
                                }
                            }
                        }
                    }
                    catch (Exception) { }
                }
            }
        }

        public void RestoreChoose()
        {
            for (int i = 0; i < sentencesCount; i++)
            {
                if (GetRealSentence(sentences[i]) == "<choose>")
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append(KEY_CHOOSE);
                    bool containsOtherwise = false;
                    for (int j = i + 1; j < sentencesCount; j++)
                    {
                        try
                        {
                            if (GetLabelContentFromGivenPrefix(sentences[j], "<when", out string content))
                            {
                                stringBuilder
                                    .Append(content)
                                    .Append(KEY_SPLITTER);
                                ProcessChooseLabelContent(j + 1, ref stringBuilder, ref sentences);
                            }
                            else if (GetRealSentence(sentences[j]) == "<otherwise>")
                            {
                                containsOtherwise = true;
                                ProcessChooseLabelContent(j + 1, ref stringBuilder, ref sentences);
                            }
                        }
                        catch (Exception) { }
                    }
                    if (!containsOtherwise)
                    {
                        stringBuilder = stringBuilder.Remove(stringBuilder.Length - 1, 1);
                    }
                    stringBuilder.Append("\n\t");
                    sentences[i] = stringBuilder.ToString();
                }
            }
        }

        private void ProcessChooseLabelContent(int index, ref StringBuilder stringBuilder, ref List<string> sentences) 
        {
            if (index < sentencesCount)
            {
                stringBuilder
                    .Append(GetRealSentence(sentences[index]))
                    .Append(KEY_SPLITTER);
                sentences[index - 1] = sentences[index] = string.Empty;
            }
            else
            {
                throw new BusinessException(20000);
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
