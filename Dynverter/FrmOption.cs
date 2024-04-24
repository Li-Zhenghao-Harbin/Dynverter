using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void FrmOption_Load(object sender, EventArgs e)
        {
            // 加载选项
            LoadOptions();
        }

        private void LinkedCheckBox()
        {
            Ck_NestedIf.Enabled = Ck_ContainsEnd.Checked;
        }

        private void LoadOptions()
        {
            Ck_ReplaceCommon.Checked = Base.replaceCommon;
            Ck_ReplaceIf.Checked = Base.replaceIf;
            Ck_ReplaceChoose.Checked = Base.replaceChoose;

            Ck_RestoreCommon.Checked = Base.restoreCommon;
            Ck_RestoreIf.Checked = Base.restoreIf;
            Ck_RestoreChoose.Checked = Base.restoreChoose;

            Ck_ReplaceEscape.Checked = Base.replaceEscape;
            Ck_RetainAnnotations.Checked = Base.retainAnnotations;

            Ck_GenerateIndent.Checked = Base.generateIndent;

            Ck_SimplifyChoose.Checked = Base.simplifyChoose;
            Ck_ContainsEnd.Checked = Base.containsEnd;
            Ck_NestedIf.Checked = Base.nestedIf;
            LinkedCheckBox();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Base.replaceCommon = Ck_ReplaceCommon.Checked;
            Base.replaceIf = Ck_ReplaceIf.Checked;
            Base.replaceChoose = Ck_ReplaceChoose.Checked;

            Base.restoreCommon = Ck_RestoreCommon.Checked;
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

        private void Ck_ContainsEnd_CheckedChanged(object sender, EventArgs e)
        {
            LinkedCheckBox();
        }
    }
}
