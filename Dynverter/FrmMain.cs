using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace Dynverter
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public static List<string> exceptions = new List<string>();
        public static List<string> warnings = new List<string>();
        public static string source;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 初始化控件
            RtxSourceSql.LanguageOption = RtxConvertedSql.LanguageOption = RtxOutput.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
            SplitContainerRtxs.Panel2Collapsed = SplitContainerOutput.Panel2Collapsed = true;
            // 导入配置文件
            Config config = new Config();
            config.LoadConfig();
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            RtxSourceSql.Focus();
        }

        private void DisplayRtxConvertedSql(bool value = true)
        {
            转换语句视图CToolStripMenuItem.Checked = !(SplitContainerRtxs.Panel2Collapsed = !value);
            SplitContainerRtxs.SplitterDistance = SplitContainerRtxs.Width / 2;
        }

        // 转换语句
        private void ConvertSql()
        {
            Converter converter = new Converter(RtxSourceSql.Text);
            if (Base.replaceCommon)
            {
                converter.ReplaceSentence();
            }
            //if (Base.replaceWhere)
            //{
            //    converter.ReplaceWhere();
            //}
            if (Base.replaceIf)
            {
                converter.ReplaceIf();
            }
            if (Base.replaceChoose)
            {
                converter.ReplaceChoose();
            }
            DisplayConvertedResult(converter.GetResult());
        }

        // 还原语句
        private void RConvertSql()
        {
            RConverter rConverter = new RConverter(RtxSourceSql.Text);
            if (Base.restoreIf)
            {
                rConverter.RestoreIf();
            }
            if (Base.restoreChoose)
            {
                rConverter.RestoreChoose();
            }
            if (Base.replaceCommon)
            {
                rConverter.RestoreCommon();
            }
            DisplayConvertedResult(rConverter.GetResult());
        }

        // 匹配参数
        private void ShowMatchParametersForm()
        {
            source = RtxSourceSql.Text;
            FrmParameters frmParameters = new FrmParameters();
            frmParameters.ShowDialog();
            if (FrmParameters.matched)
            {
                DisplayConvertedResult(FrmParameters.matchedResult);
            }
        }

        public void DisplayConvertedResult(string result)
        {
            // 显示转换语句窗口
            DisplayRtxConvertedSql();
            RtxConvertedSql.Text = result;
            // 显示输出窗口
            DisplayRtxOutput();
            RtxOutput.Text += GetOutput();
            RtxOutput.SelectionStart = RtxOutput.TextLength;
            RtxOutput.ScrollToCaret();
        }

        private void DisplayRtxOutput(bool value = true)
        {
            输出OToolStripMenuItem.Checked = !(SplitContainerOutput.Panel2Collapsed = !value);
            SplitContainerOutput.SplitterDistance = SplitContainerOutput.Height * 3 / 4;
        }

        private string GetOutput()
        {
            if (RtxOutput.Text != "")
            {
                RtxOutput.Text += '\n';
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string warning in warnings)
            {
                stringBuilder.AppendLine(warning);
            }
            if (exceptions.Count == 0)
            {
                if (warnings.Count > 0)
                {
                    RtxOutput.ForeColor = Color.Orange;
                    warnings.Clear();
                }
                else
                {
                    RtxOutput.ForeColor = Color.Black;
                }
                RtxConvertedSql.BackColor = SystemColors.Window;
                return stringBuilder
                    .Append('[')
                    .Append(DateTime.Now)
                    .Append("] 成功转换语句\n")
                    .ToString();
            }
            foreach (string exception in exceptions)
            {
                stringBuilder.AppendLine(exception);
            }
            RtxOutput.ForeColor = Color.Red;
            RtxConvertedSql.BackColor = SystemColors.Info;
            exceptions.Clear();
            return stringBuilder.ToString();
        }

        private void RtxSource_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                IDataObject dataObject = Clipboard.GetDataObject();
                if (dataObject.GetDataPresent(DataFormats.StringFormat))
                {
                    e.Handled = true;
                    var content = (string)Clipboard.GetData(DataFormats.StringFormat);
                    Clipboard.Clear();
                    Clipboard.SetData(DataFormats.StringFormat, content);
                    RtxSourceSql.Paste();
                }
            }
        }

        /*
         * 工具栏
         */
        private void BtnConvert_Click(object sender, EventArgs e)
        {
            ConvertSql();
        }

        private void BtnRConvert_Click(object sender, EventArgs e)
        {
            RConvertSql();
        }

        private void BtnMatchParameters_Click(object sender, EventArgs e)
        {
            ShowMatchParametersForm();
        }

        /*
         * 菜单-文件
         */
        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
         * 菜单-编辑
         */
        private void 转换CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertSql();
        }

        private void 逆向转换RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RConvertSql();
        }

        private void 匹配参数MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMatchParametersForm();
        }

        /*
         * 菜单-视图
         */
        private void 转换语句视图CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayRtxConvertedSql(!转换语句视图CToolStripMenuItem.Checked);
        }

        private void 输出OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayRtxOutput(!输出OToolStripMenuItem.Checked);
        }

        /*
         * 菜单-格式
         */
        private void 自动换行WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtxSourceSql.WordWrap = RtxConvertedSql.WordWrap = 自动换行WToolStripMenuItem.Checked = !自动换行WToolStripMenuItem.Checked;
        }

        /*
         * 菜单-工具
         */
        private void 选项OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOption frmOption = new FrmOption();
            frmOption.ShowDialog();
        }

        /*
         * 菜单-帮助
         */
        private void 关于DynverterAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }

        /*
         * 右键菜单-RtxSourceSql
         */
        private void PasteToRtx(RichTextBox richTextBox)
        {
            richTextBox.Clear();
            IDataObject dataObject = Clipboard.GetDataObject();
            if (dataObject.GetDataPresent(DataFormats.StringFormat))
            {
                var content = (string)Clipboard.GetData(DataFormats.StringFormat);
                Clipboard.Clear();
                Clipboard.SetData(DataFormats.StringFormat, content);
                richTextBox.Paste();
            }
        }

        private void 粘贴并转换PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteToRtx(RtxSourceSql);
            ConvertSql();
        }

        private void 粘贴并逆向转换RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteToRtx(RtxSourceSql);
            RConvertSql();
        }


        private void 粘贴并匹配参数MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteToRtx(RtxSourceSql);
            ShowMatchParametersForm();
        }

        private void 清空CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtxSourceSql.Clear();
        }

        /*
         * 右键菜单-RtxConvertedSql
         */
        private void 复制内容到剪切板CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RtxConvertedSql.Text != null && RtxConvertedSql.Text != "")
            {
                Clipboard.SetText(RtxConvertedSql.Text);
            }
        }

        /*
         * 右键菜单-RtxOutput
         */
        private void 清空内容CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtxOutput.Clear();
        }

        private void 隐藏输出窗口HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayRtxOutput(false);
        }
    }
}
