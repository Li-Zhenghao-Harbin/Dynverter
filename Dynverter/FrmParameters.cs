﻿using Dynverter.Matcher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynverter
{
    public partial class FrmParameters : Form
    {
        public FrmParameters()
        {
            InitializeComponent();
        }

        public static bool matched = false;
        public static string matchedResult;

        private void FrmParameters_Load(object sender, EventArgs e)
        {
            RtxParameters.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            ConfirmParamters();
        }

        private void ConfirmParamters()
        {
            ParameterMatcher parameterMatcher = new ParameterMatcher(
                FrmMain.source,
                RtxParameters.Text);
            matchedResult = parameterMatcher.GetResult();
            matched = true;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmParameters_Activated(object sender, EventArgs e)
        {
            RtxParameters.Focus();
        }

        private void 粘贴并确认PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMain.PasteToRtx(RtxParameters);
            ConfirmParamters();
        }
    }
}
