using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Dynverter
{
    internal class Config : Base
    {

        public void LoadConfig()
        {
            try
            {
                replaceCommon = Convert.ToBoolean(ConfigurationManager.AppSettings["ReplaceCommon"]);
                replaceIf = Convert.ToBoolean(ConfigurationManager.AppSettings["ReplaceIF"]);
                replaceChoose = Convert.ToBoolean(ConfigurationManager.AppSettings["ReplaceCHOOSE"]);
                //replaceWhere = Convert.ToBoolean(ConfigurationManager.AppSettings["ReplaceWHERE"]);
                restoreCommon = Convert.ToBoolean(ConfigurationManager.AppSettings["RestoreCommon"]);
                restoreIf = Convert.ToBoolean(ConfigurationManager.AppSettings["RestoreIF"]);
                restoreChoose = Convert.ToBoolean(ConfigurationManager.AppSettings["RestoreCHOOSE"]);
                replaceEscape = Convert.ToBoolean(ConfigurationManager.AppSettings["ReplaceEscape"]);
                retainAnnotations = Convert.ToBoolean(ConfigurationManager.AppSettings["RetainAnnotations"]);
                generateIndent = Convert.ToBoolean(ConfigurationManager.AppSettings["GenerateIndent"]);
                simplifyChoose = Convert.ToBoolean(ConfigurationManager.AppSettings["SimplifyChoose"]);
                containsEnd = Convert.ToBoolean(ConfigurationManager.AppSettings["ContainsEnd"]);
                nestedIf = Convert.ToBoolean(ConfigurationManager.AppSettings["NestedIf"]);
            }
            catch
            {
                MessageBox.Show("配置文件异常");
            }
        }

        public void SaveConfig()
        {
            XmlDocument doc = new XmlDocument();
            string strFileName = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            doc.Load(strFileName);
            XmlNodeList nodes = doc.GetElementsByTagName("add");
            for (int i = 1; i < nodes.Count; i++)
            {
                XmlAttribute att = nodes[i].Attributes["key"];
                switch (att.Value)
                {
                    case "ReplaceCommon":
                        att = nodes[i].Attributes["value"];
                        att.Value = replaceCommon.ToString();
                        break;
                    case "ReplaceIF":
                        att = nodes[i].Attributes["value"];
                        att.Value = replaceIf.ToString();
                        break;
                    case "ReplaceCHOOSE":
                        att = nodes[i].Attributes["value"];
                        att.Value = replaceChoose.ToString();
                        break;
                    //case "ReplaceWHERE":
                    //    att = nodes[i].Attributes["value"];
                    //    att.Value = replaceWhere.ToString();
                    //    break;
                    case "RestoreCommon":
                        att = nodes[i].Attributes["value"];
                        att.Value = restoreCommon.ToString();
                        break;
                    case "RestoreIF":
                        att = nodes[i].Attributes["value"];
                        att.Value = restoreIf.ToString();
                        break;
                    case "RestoreCHOOSE":
                        att = nodes[i].Attributes["value"];
                        att.Value = restoreChoose.ToString();
                        break;
                    case "ReplaceEscape":
                        att = nodes[i].Attributes["value"];
                        att.Value = replaceEscape.ToString();
                        break;
                    case "RetainAnnotations":
                        att = nodes[i].Attributes["value"];
                        att.Value = retainAnnotations.ToString();
                        break;
                    case "GenerateIndent":
                        att = nodes[i].Attributes["value"];
                        att.Value = generateIndent.ToString();
                        break;
                    case "SimplifyChoose":
                        att = nodes[i].Attributes["value"];
                        att.Value = simplifyChoose.ToString();
                        break;
                    case "ContainsEnd":
                        att = nodes[i].Attributes["value"];
                        att.Value = containsEnd.ToString();
                        break;
                    case "NestedIf":
                        att = nodes[i].Attributes["value"];
                        att.Value = nestedIf.ToString();
                        break;
                }
            }
            doc.Save(strFileName);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
