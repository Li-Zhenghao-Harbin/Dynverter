using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dynverter
{
    public partial class FrmOption : Form
    {
        public FrmOption()
        {
            InitializeComponent();
        }

        // 一级checkbox和二级checkbox的映射
        Dictionary<CheckBox, CheckBox> checkBoxLinks;

        private void FrmOption_Load(object sender, EventArgs e)
        {
            // 初始化checkbox映射
            checkBoxLinks = new Dictionary<CheckBox, CheckBox>()
            {
                { Ck_NestedIf, Ck_ContainsEnd },
                { Ck_RetainReplacedSentence, Ck_RestoreCommon }
            };
            foreach (CheckBox checkBox in checkBoxLinks.Values)
            {
                checkBox.CheckedChanged += CheckBoxLinks_CheckChanged;
            }
            // 加载选项
            LoadOptions();
        }

        private void LinkCheckBox()
        {
            foreach (KeyValuePair<CheckBox, CheckBox> link in checkBoxLinks)
            {
                link.Key.Enabled = link.Value.Checked;
            }
        }

        private void CheckBoxLinks_CheckChanged(object sender, EventArgs e)
        {
            LinkCheckBox();
        }

        private void LoadOptions()
        {
            Ck_ReplaceCommon.Checked = Base.replaceCommon;
            Ck_ReplaceIf.Checked = Base.replaceIf;
            Ck_ReplaceChoose.Checked = Base.replaceChoose;

            Ck_RestoreCommon.Checked = Base.restoreCommon;
            Ck_RetainReplacedSentence.Checked = Base.retainReplacedSentence;
            Ck_RestoreIf.Checked = Base.restoreIf;
            Ck_RestoreChoose.Checked = Base.restoreChoose;

            Ck_ReplaceEscape.Checked = Base.replaceEscape;
            Ck_RetainAnnotations.Checked = Base.retainAnnotations;

            Ck_GenerateIndent.Checked = Base.generateIndent;

            Ck_SimplifyChoose.Checked = Base.simplifyChoose;
            Ck_ContainsEnd.Checked = Base.containsEnd;
            Ck_NestedIf.Checked = Base.nestedIf;
            LinkCheckBox();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Base.replaceCommon = Ck_ReplaceCommon.Checked;
            Base.replaceIf = Ck_ReplaceIf.Checked;
            Base.replaceChoose = Ck_ReplaceChoose.Checked;

            Base.restoreCommon = Ck_RestoreCommon.Checked;
            Base.retainReplacedSentence = Ck_RetainReplacedSentence.Checked;
            Base.restoreIf = Ck_RestoreIf.Checked;
            Base.restoreChoose = Ck_RestoreChoose.Checked;

            Base.replaceEscape = Ck_ReplaceEscape.Checked;
            Base.retainAnnotations = Ck_RetainAnnotations.Checked;

            Base.generateIndent = Ck_GenerateIndent.Checked;

            Base.simplifyChoose = Ck_SimplifyChoose.Checked;
            Base.containsEnd = Ck_ContainsEnd.Checked;
            Base.nestedIf = Ck_NestedIf.Checked;
            Config config = new Config();
            config.SaveConfig();
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
