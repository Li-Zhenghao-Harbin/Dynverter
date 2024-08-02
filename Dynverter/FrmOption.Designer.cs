namespace Dynverter
{
    partial class FrmOption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnBtns = new System.Windows.Forms.Panel();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Tp_Replace = new System.Windows.Forms.TabPage();
            this.Gb_Character = new System.Windows.Forms.GroupBox();
            this.Ck_RetainAnnotations = new System.Windows.Forms.CheckBox();
            this.Ck_ReplaceEscape = new System.Windows.Forms.CheckBox();
            this.Gb_RConvert = new System.Windows.Forms.GroupBox();
            this.Ck_RestoreChoose = new System.Windows.Forms.CheckBox();
            this.Ck_RestoreIf = new System.Windows.Forms.CheckBox();
            this.Ck_RetainReplacedSentence = new System.Windows.Forms.CheckBox();
            this.Ck_RestoreCommon = new System.Windows.Forms.CheckBox();
            this.Gb_Convert = new System.Windows.Forms.GroupBox();
            this.Ck_ReplaceChoose = new System.Windows.Forms.CheckBox();
            this.Ck_ReplaceIf = new System.Windows.Forms.CheckBox();
            this.Ck_ReplaceCommon = new System.Windows.Forms.CheckBox();
            this.Tp_Indent = new System.Windows.Forms.TabPage();
            this.Gb_Annotation = new System.Windows.Forms.GroupBox();
            this.Ck_GenerateIndent = new System.Windows.Forms.CheckBox();
            this.Tp_Advance = new System.Windows.Forms.TabPage();
            this.Gb_Area = new System.Windows.Forms.GroupBox();
            this.Ck_NestedIf = new System.Windows.Forms.CheckBox();
            this.Ck_ContainsEnd = new System.Windows.Forms.CheckBox();
            this.Gb_Simplify = new System.Windows.Forms.GroupBox();
            this.Ck_SimplifyChoose = new System.Windows.Forms.CheckBox();
            this.Gb_Advance_Attention = new System.Windows.Forms.GroupBox();
            this.Lbl_Advance_Attention = new System.Windows.Forms.Label();
            this.PnBtns.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.Tp_Replace.SuspendLayout();
            this.Gb_Character.SuspendLayout();
            this.Gb_RConvert.SuspendLayout();
            this.Gb_Convert.SuspendLayout();
            this.Tp_Indent.SuspendLayout();
            this.Gb_Annotation.SuspendLayout();
            this.Tp_Advance.SuspendLayout();
            this.Gb_Area.SuspendLayout();
            this.Gb_Simplify.SuspendLayout();
            this.Gb_Advance_Attention.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnBtns
            // 
            this.PnBtns.Controls.Add(this.BtnConfirm);
            this.PnBtns.Controls.Add(this.BtnCancel);
            this.PnBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnBtns.Location = new System.Drawing.Point(0, 424);
            this.PnBtns.Name = "PnBtns";
            this.PnBtns.Padding = new System.Windows.Forms.Padding(10);
            this.PnBtns.Size = new System.Drawing.Size(459, 50);
            this.PnBtns.TabIndex = 0;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnConfirm.Location = new System.Drawing.Point(249, 10);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(100, 30);
            this.BtnConfirm.TabIndex = 1;
            this.BtnConfirm.Text = "确认";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCancel.Location = new System.Drawing.Point(349, 10);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 30);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Tp_Replace);
            this.TabControl.Controls.Add(this.Tp_Indent);
            this.TabControl.Controls.Add(this.Tp_Advance);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(459, 424);
            this.TabControl.TabIndex = 3;
            this.TabControl.TabStop = false;
            // 
            // Tp_Replace
            // 
            this.Tp_Replace.BackColor = System.Drawing.Color.Transparent;
            this.Tp_Replace.Controls.Add(this.Gb_Character);
            this.Tp_Replace.Controls.Add(this.Gb_RConvert);
            this.Tp_Replace.Controls.Add(this.Gb_Convert);
            this.Tp_Replace.Location = new System.Drawing.Point(4, 28);
            this.Tp_Replace.Name = "Tp_Replace";
            this.Tp_Replace.Padding = new System.Windows.Forms.Padding(10);
            this.Tp_Replace.Size = new System.Drawing.Size(451, 392);
            this.Tp_Replace.TabIndex = 0;
            this.Tp_Replace.Text = "转换";
            // 
            // Gb_Character
            // 
            this.Gb_Character.AutoSize = true;
            this.Gb_Character.Controls.Add(this.Ck_RetainAnnotations);
            this.Gb_Character.Controls.Add(this.Ck_ReplaceEscape);
            this.Gb_Character.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gb_Character.Location = new System.Drawing.Point(10, 288);
            this.Gb_Character.Name = "Gb_Character";
            this.Gb_Character.Padding = new System.Windows.Forms.Padding(10);
            this.Gb_Character.Size = new System.Drawing.Size(431, 97);
            this.Gb_Character.TabIndex = 8;
            this.Gb_Character.TabStop = false;
            this.Gb_Character.Text = "字符和注释";
            // 
            // Ck_RetainAnnotations
            // 
            this.Ck_RetainAnnotations.AutoSize = true;
            this.Ck_RetainAnnotations.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ck_RetainAnnotations.Location = new System.Drawing.Point(10, 59);
            this.Ck_RetainAnnotations.Name = "Ck_RetainAnnotations";
            this.Ck_RetainAnnotations.Padding = new System.Windows.Forms.Padding(3);
            this.Ck_RetainAnnotations.Size = new System.Drawing.Size(411, 28);
            this.Ck_RetainAnnotations.TabIndex = 9;
            this.Ck_RetainAnnotations.Text = "保留行注释";
            this.Ck_RetainAnnotations.UseVisualStyleBackColor = true;
            // 
            // Ck_ReplaceEscape
            // 
            this.Ck_ReplaceEscape.AutoSize = true;
            this.Ck_ReplaceEscape.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ck_ReplaceEscape.Location = new System.Drawing.Point(10, 31);
            this.Ck_ReplaceEscape.Name = "Ck_ReplaceEscape";
            this.Ck_ReplaceEscape.Padding = new System.Windows.Forms.Padding(3);
            this.Ck_ReplaceEscape.Size = new System.Drawing.Size(411, 28);
            this.Ck_ReplaceEscape.TabIndex = 8;
            this.Ck_ReplaceEscape.Text = "替换转义符";
            this.Ck_ReplaceEscape.UseVisualStyleBackColor = true;
            // 
            // Gb_RConvert
            // 
            this.Gb_RConvert.AutoSize = true;
            this.Gb_RConvert.Controls.Add(this.Ck_RestoreChoose);
            this.Gb_RConvert.Controls.Add(this.Ck_RestoreIf);
            this.Gb_RConvert.Controls.Add(this.Ck_RetainReplacedSentence);
            this.Gb_RConvert.Controls.Add(this.Ck_RestoreCommon);
            this.Gb_RConvert.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gb_RConvert.Location = new System.Drawing.Point(10, 135);
            this.Gb_RConvert.Name = "Gb_RConvert";
            this.Gb_RConvert.Padding = new System.Windows.Forms.Padding(10);
            this.Gb_RConvert.Size = new System.Drawing.Size(431, 153);
            this.Gb_RConvert.TabIndex = 9;
            this.Gb_RConvert.TabStop = false;
            this.Gb_RConvert.Text = "逆向转换语句";
            // 
            // Ck_RestoreChoose
            // 
            this.Ck_RestoreChoose.AutoSize = true;
            this.Ck_RestoreChoose.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ck_RestoreChoose.Location = new System.Drawing.Point(10, 115);
            this.Ck_RestoreChoose.Name = "Ck_RestoreChoose";
            this.Ck_RestoreChoose.Padding = new System.Windows.Forms.Padding(3);
            this.Ck_RestoreChoose.Size = new System.Drawing.Size(411, 28);
            this.Ck_RestoreChoose.TabIndex = 7;
            this.Ck_RestoreChoose.Text = "还原choose语句";
            this.Ck_RestoreChoose.UseVisualStyleBackColor = true;
            // 
            // Ck_RestoreIf
            // 
            this.Ck_RestoreIf.AutoSize = true;
            this.Ck_RestoreIf.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ck_RestoreIf.Location = new System.Drawing.Point(10, 87);
            this.Ck_RestoreIf.Name = "Ck_RestoreIf";
            this.Ck_RestoreIf.Padding = new System.Windows.Forms.Padding(3);
            this.Ck_RestoreIf.Size = new System.Drawing.Size(411, 28);
            this.Ck_RestoreIf.TabIndex = 6;
            this.Ck_RestoreIf.Text = "还原if语句";
            this.Ck_RestoreIf.UseVisualStyleBackColor = true;
            // 
            // Ck_RetainReplacedSentence
            // 
            this.Ck_RetainReplacedSentence.AutoSize = true;
            this.Ck_RetainReplacedSentence.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ck_RetainReplacedSentence.Location = new System.Drawing.Point(10, 59);
            this.Ck_RetainReplacedSentence.Name = "Ck_RetainReplacedSentence";
            this.Ck_RetainReplacedSentence.Padding = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.Ck_RetainReplacedSentence.Size = new System.Drawing.Size(411, 28);
            this.Ck_RetainReplacedSentence.TabIndex = 8;
            this.Ck_RetainReplacedSentence.Text = "保留被还原的语句";
            this.Ck_RetainReplacedSentence.UseVisualStyleBackColor = true;
            // 
            // Ck_RestoreCommon
            // 
            this.Ck_RestoreCommon.AutoSize = true;
            this.Ck_RestoreCommon.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ck_RestoreCommon.Location = new System.Drawing.Point(10, 31);
            this.Ck_RestoreCommon.Name = "Ck_RestoreCommon";
            this.Ck_RestoreCommon.Padding = new System.Windows.Forms.Padding(3);
            this.Ck_RestoreCommon.Size = new System.Drawing.Size(411, 28);
            this.Ck_RestoreCommon.TabIndex = 5;
            this.Ck_RestoreCommon.Text = "还原普通语句";
            this.Ck_RestoreCommon.UseVisualStyleBackColor = true;
            // 
            // Gb_Convert
            // 
            this.Gb_Convert.AutoSize = true;
            this.Gb_Convert.Controls.Add(this.Ck_ReplaceChoose);
            this.Gb_Convert.Controls.Add(this.Ck_ReplaceIf);
            this.Gb_Convert.Controls.Add(this.Ck_ReplaceCommon);
            this.Gb_Convert.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gb_Convert.Location = new System.Drawing.Point(10, 10);
            this.Gb_Convert.Name = "Gb_Convert";
            this.Gb_Convert.Padding = new System.Windows.Forms.Padding(10);
            this.Gb_Convert.Size = new System.Drawing.Size(431, 125);
            this.Gb_Convert.TabIndex = 0;
            this.Gb_Convert.TabStop = false;
            this.Gb_Convert.Text = "转换语句";
            // 
            // Ck_ReplaceChoose
            // 
            this.Ck_ReplaceChoose.AutoSize = true;
            this.Ck_ReplaceChoose.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ck_ReplaceChoose.Location = new System.Drawing.Point(10, 87);
            this.Ck_ReplaceChoose.Name = "Ck_ReplaceChoose";
            this.Ck_ReplaceChoose.Padding = new System.Windows.Forms.Padding(3);
            this.Ck_ReplaceChoose.Size = new System.Drawing.Size(411, 28);
            this.Ck_ReplaceChoose.TabIndex = 7;
            this.Ck_ReplaceChoose.Text = "替换choose语句";
            this.Ck_ReplaceChoose.UseVisualStyleBackColor = true;
            // 
            // Ck_ReplaceIf
            // 
            this.Ck_ReplaceIf.AutoSize = true;
            this.Ck_ReplaceIf.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ck_ReplaceIf.Location = new System.Drawing.Point(10, 59);
            this.Ck_ReplaceIf.Name = "Ck_ReplaceIf";
            this.Ck_ReplaceIf.Padding = new System.Windows.Forms.Padding(3);
            this.Ck_ReplaceIf.Size = new System.Drawing.Size(411, 28);
            this.Ck_ReplaceIf.TabIndex = 6;
            this.Ck_ReplaceIf.Text = "替换if语句";
            this.Ck_ReplaceIf.UseVisualStyleBackColor = true;
            // 
            // Ck_ReplaceCommon
            // 
            this.Ck_ReplaceCommon.AutoSize = true;
            this.Ck_ReplaceCommon.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ck_ReplaceCommon.Location = new System.Drawing.Point(10, 31);
            this.Ck_ReplaceCommon.Name = "Ck_ReplaceCommon";
            this.Ck_ReplaceCommon.Padding = new System.Windows.Forms.Padding(3);
            this.Ck_ReplaceCommon.Size = new System.Drawing.Size(411, 28);
            this.Ck_ReplaceCommon.TabIndex = 5;
            this.Ck_ReplaceCommon.Text = "替换普通语句";
            this.Ck_ReplaceCommon.UseVisualStyleBackColor = true;
            // 
            // Tp_Indent
            // 
            this.Tp_Indent.BackColor = System.Drawing.Color.Transparent;
            this.Tp_Indent.Controls.Add(this.Gb_Annotation);
            this.Tp_Indent.Location = new System.Drawing.Point(4, 28);
            this.Tp_Indent.Name = "Tp_Indent";
            this.Tp_Indent.Padding = new System.Windows.Forms.Padding(10);
            this.Tp_Indent.Size = new System.Drawing.Size(451, 364);
            this.Tp_Indent.TabIndex = 1;
            this.Tp_Indent.Text = "缩进";
            // 
            // Gb_Annotation
            // 
            this.Gb_Annotation.AutoSize = true;
            this.Gb_Annotation.Controls.Add(this.Ck_GenerateIndent);
            this.Gb_Annotation.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gb_Annotation.Location = new System.Drawing.Point(10, 10);
            this.Gb_Annotation.Name = "Gb_Annotation";
            this.Gb_Annotation.Padding = new System.Windows.Forms.Padding(10);
            this.Gb_Annotation.Size = new System.Drawing.Size(431, 69);
            this.Gb_Annotation.TabIndex = 8;
            this.Gb_Annotation.TabStop = false;
            this.Gb_Annotation.Text = "缩进";
            // 
            // Ck_GenerateIndent
            // 
            this.Ck_GenerateIndent.AutoSize = true;
            this.Ck_GenerateIndent.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ck_GenerateIndent.Location = new System.Drawing.Point(10, 31);
            this.Ck_GenerateIndent.Name = "Ck_GenerateIndent";
            this.Ck_GenerateIndent.Padding = new System.Windows.Forms.Padding(3);
            this.Ck_GenerateIndent.Size = new System.Drawing.Size(411, 28);
            this.Ck_GenerateIndent.TabIndex = 8;
            this.Ck_GenerateIndent.Text = "生成缩进";
            this.Ck_GenerateIndent.UseVisualStyleBackColor = true;
            // 
            // Tp_Advance
            // 
            this.Tp_Advance.BackColor = System.Drawing.Color.Transparent;
            this.Tp_Advance.Controls.Add(this.Gb_Area);
            this.Tp_Advance.Controls.Add(this.Gb_Simplify);
            this.Tp_Advance.Controls.Add(this.Gb_Advance_Attention);
            this.Tp_Advance.Location = new System.Drawing.Point(4, 28);
            this.Tp_Advance.Name = "Tp_Advance";
            this.Tp_Advance.Padding = new System.Windows.Forms.Padding(10);
            this.Tp_Advance.Size = new System.Drawing.Size(451, 364);
            this.Tp_Advance.TabIndex = 2;
            this.Tp_Advance.Text = "高级语法";
            // 
            // Gb_Area
            // 
            this.Gb_Area.AutoSize = true;
            this.Gb_Area.Controls.Add(this.Ck_NestedIf);
            this.Gb_Area.Controls.Add(this.Ck_ContainsEnd);
            this.Gb_Area.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gb_Area.Location = new System.Drawing.Point(10, 158);
            this.Gb_Area.Name = "Gb_Area";
            this.Gb_Area.Padding = new System.Windows.Forms.Padding(10);
            this.Gb_Area.Size = new System.Drawing.Size(431, 97);
            this.Gb_Area.TabIndex = 2;
            this.Gb_Area.TabStop = false;
            this.Gb_Area.Text = "域";
            // 
            // Ck_NestedIf
            // 
            this.Ck_NestedIf.AutoSize = true;
            this.Ck_NestedIf.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ck_NestedIf.Location = new System.Drawing.Point(10, 59);
            this.Ck_NestedIf.Name = "Ck_NestedIf";
            this.Ck_NestedIf.Padding = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.Ck_NestedIf.Size = new System.Drawing.Size(411, 28);
            this.Ck_NestedIf.TabIndex = 10;
            this.Ck_NestedIf.Text = "允许嵌套if语句";
            this.Ck_NestedIf.UseVisualStyleBackColor = true;
            // 
            // Ck_ContainsEnd
            // 
            this.Ck_ContainsEnd.AutoSize = true;
            this.Ck_ContainsEnd.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ck_ContainsEnd.Location = new System.Drawing.Point(10, 31);
            this.Ck_ContainsEnd.Name = "Ck_ContainsEnd";
            this.Ck_ContainsEnd.Padding = new System.Windows.Forms.Padding(3);
            this.Ck_ContainsEnd.Size = new System.Drawing.Size(411, 28);
            this.Ck_ContainsEnd.TabIndex = 9;
            this.Ck_ContainsEnd.Text = "包含end语句";
            this.Ck_ContainsEnd.UseVisualStyleBackColor = true;
            // 
            // Gb_Simplify
            // 
            this.Gb_Simplify.AutoSize = true;
            this.Gb_Simplify.Controls.Add(this.Ck_SimplifyChoose);
            this.Gb_Simplify.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gb_Simplify.Location = new System.Drawing.Point(10, 89);
            this.Gb_Simplify.Name = "Gb_Simplify";
            this.Gb_Simplify.Padding = new System.Windows.Forms.Padding(10);
            this.Gb_Simplify.Size = new System.Drawing.Size(431, 69);
            this.Gb_Simplify.TabIndex = 1;
            this.Gb_Simplify.TabStop = false;
            this.Gb_Simplify.Text = "简化语句";
            // 
            // Ck_SimplifyChoose
            // 
            this.Ck_SimplifyChoose.AutoSize = true;
            this.Ck_SimplifyChoose.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ck_SimplifyChoose.Location = new System.Drawing.Point(10, 31);
            this.Ck_SimplifyChoose.Name = "Ck_SimplifyChoose";
            this.Ck_SimplifyChoose.Padding = new System.Windows.Forms.Padding(3);
            this.Ck_SimplifyChoose.Size = new System.Drawing.Size(411, 28);
            this.Ck_SimplifyChoose.TabIndex = 8;
            this.Ck_SimplifyChoose.Text = "简化choose语句";
            this.Ck_SimplifyChoose.UseVisualStyleBackColor = true;
            // 
            // Gb_Advance_Attention
            // 
            this.Gb_Advance_Attention.AutoSize = true;
            this.Gb_Advance_Attention.Controls.Add(this.Lbl_Advance_Attention);
            this.Gb_Advance_Attention.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gb_Advance_Attention.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Gb_Advance_Attention.ForeColor = System.Drawing.Color.Brown;
            this.Gb_Advance_Attention.Location = new System.Drawing.Point(10, 10);
            this.Gb_Advance_Attention.Name = "Gb_Advance_Attention";
            this.Gb_Advance_Attention.Padding = new System.Windows.Forms.Padding(10);
            this.Gb_Advance_Attention.Size = new System.Drawing.Size(431, 79);
            this.Gb_Advance_Attention.TabIndex = 3;
            this.Gb_Advance_Attention.TabStop = false;
            this.Gb_Advance_Attention.Text = "说明";
            // 
            // Lbl_Advance_Attention
            // 
            this.Lbl_Advance_Attention.AutoSize = true;
            this.Lbl_Advance_Attention.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Advance_Attention.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Advance_Attention.Location = new System.Drawing.Point(10, 31);
            this.Lbl_Advance_Attention.Name = "Lbl_Advance_Attention";
            this.Lbl_Advance_Attention.Padding = new System.Windows.Forms.Padding(10);
            this.Lbl_Advance_Attention.Size = new System.Drawing.Size(419, 38);
            this.Lbl_Advance_Attention.TabIndex = 9;
            this.Lbl_Advance_Attention.Text = "改变本菜单下的选项可能需要修改原始sql语句";
            // 
            // FrmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 474);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.PnBtns);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOption";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选项";
            this.Load += new System.EventHandler(this.FrmOption_Load);
            this.PnBtns.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.Tp_Replace.ResumeLayout(false);
            this.Tp_Replace.PerformLayout();
            this.Gb_Character.ResumeLayout(false);
            this.Gb_Character.PerformLayout();
            this.Gb_RConvert.ResumeLayout(false);
            this.Gb_RConvert.PerformLayout();
            this.Gb_Convert.ResumeLayout(false);
            this.Gb_Convert.PerformLayout();
            this.Tp_Indent.ResumeLayout(false);
            this.Tp_Indent.PerformLayout();
            this.Gb_Annotation.ResumeLayout(false);
            this.Gb_Annotation.PerformLayout();
            this.Tp_Advance.ResumeLayout(false);
            this.Tp_Advance.PerformLayout();
            this.Gb_Area.ResumeLayout(false);
            this.Gb_Area.PerformLayout();
            this.Gb_Simplify.ResumeLayout(false);
            this.Gb_Simplify.PerformLayout();
            this.Gb_Advance_Attention.ResumeLayout(false);
            this.Gb_Advance_Attention.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnBtns;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Tp_Replace;
        private System.Windows.Forms.TabPage Tp_Indent;
        private System.Windows.Forms.GroupBox Gb_Convert;
        private System.Windows.Forms.TabPage Tp_Advance;
        private System.Windows.Forms.GroupBox Gb_Advance_Attention;
        private System.Windows.Forms.GroupBox Gb_Simplify;
        private System.Windows.Forms.GroupBox Gb_Area;
        private System.Windows.Forms.CheckBox Ck_ReplaceChoose;
        private System.Windows.Forms.CheckBox Ck_ReplaceIf;
        private System.Windows.Forms.CheckBox Ck_ReplaceCommon;
        private System.Windows.Forms.CheckBox Ck_SimplifyChoose;
        private System.Windows.Forms.CheckBox Ck_ContainsEnd;
        private System.Windows.Forms.CheckBox Ck_NestedIf;
        private System.Windows.Forms.GroupBox Gb_Character;
        private System.Windows.Forms.CheckBox Ck_RetainAnnotations;
        private System.Windows.Forms.CheckBox Ck_ReplaceEscape;
        private System.Windows.Forms.GroupBox Gb_Annotation;
        private System.Windows.Forms.CheckBox Ck_GenerateIndent;
        private System.Windows.Forms.Label Lbl_Advance_Attention;
        private System.Windows.Forms.GroupBox Gb_RConvert;
        private System.Windows.Forms.CheckBox Ck_RestoreChoose;
        private System.Windows.Forms.CheckBox Ck_RestoreIf;
        private System.Windows.Forms.CheckBox Ck_RestoreCommon;
        private System.Windows.Forms.CheckBox Ck_RetainReplacedSentence;
    }
}