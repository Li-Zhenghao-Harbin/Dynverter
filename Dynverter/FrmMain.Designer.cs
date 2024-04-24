namespace Dynverter
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转换CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.逆向转换RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转换语句视图CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输出OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于DynverterAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.BtnConvert = new System.Windows.Forms.ToolStripButton();
            this.BtnRConvert = new System.Windows.Forms.ToolStripButton();
            this.SplitContainerRtxs = new System.Windows.Forms.SplitContainer();
            this.TabSourceSql = new System.Windows.Forms.TabControl();
            this.TabPageSourceSql = new System.Windows.Forms.TabPage();
            this.RtxSourceSql = new System.Windows.Forms.RichTextBox();
            this.ConMenuStripRtxSourceSql = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.粘贴并转换PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴并逆向转换RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStripRtxSourceSql = new System.Windows.Forms.StatusStrip();
            this.TabConvertedSql = new System.Windows.Forms.TabControl();
            this.TabPageConvertedSql = new System.Windows.Forms.TabPage();
            this.RtxConvertedSql = new System.Windows.Forms.RichTextBox();
            this.ConMenuStripRtxConvertedSql = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制内容到剪切板CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStripRtxConvertedSql = new System.Windows.Forms.StatusStrip();
            this.SplitContainerOutput = new System.Windows.Forms.SplitContainer();
            this.TabOutput = new System.Windows.Forms.TabControl();
            this.TabPageOutput = new System.Windows.Forms.TabPage();
            this.RtxOutput = new System.Windows.Forms.RichTextBox();
            this.ConMenuStripRtxOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清空内容CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏输出窗口HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerRtxs)).BeginInit();
            this.SplitContainerRtxs.Panel1.SuspendLayout();
            this.SplitContainerRtxs.Panel2.SuspendLayout();
            this.SplitContainerRtxs.SuspendLayout();
            this.TabSourceSql.SuspendLayout();
            this.TabPageSourceSql.SuspendLayout();
            this.ConMenuStripRtxSourceSql.SuspendLayout();
            this.TabConvertedSql.SuspendLayout();
            this.TabPageConvertedSql.SuspendLayout();
            this.ConMenuStripRtxConvertedSql.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerOutput)).BeginInit();
            this.SplitContainerOutput.Panel1.SuspendLayout();
            this.SplitContainerOutput.Panel2.SuspendLayout();
            this.SplitContainerOutput.SuspendLayout();
            this.TabOutput.SuspendLayout();
            this.TabPageOutput.SuspendLayout();
            this.ConMenuStripRtxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.视图VToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(1, 1);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1233, 32);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.退出XToolStripMenuItem.Text = "退出（&X）";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.转换CToolStripMenuItem,
            this.逆向转换RToolStripMenuItem});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 转换CToolStripMenuItem
            // 
            this.转换CToolStripMenuItem.Image = global::Dynverter.Properties.Resources.convert;
            this.转换CToolStripMenuItem.Name = "转换CToolStripMenuItem";
            this.转换CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.转换CToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.转换CToolStripMenuItem.Text = "转换(&C)";
            this.转换CToolStripMenuItem.Click += new System.EventHandler(this.转换CToolStripMenuItem_Click);
            // 
            // 逆向转换RToolStripMenuItem
            // 
            this.逆向转换RToolStripMenuItem.Image = global::Dynverter.Properties.Resources.rconvert;
            this.逆向转换RToolStripMenuItem.Name = "逆向转换RToolStripMenuItem";
            this.逆向转换RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.逆向转换RToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.逆向转换RToolStripMenuItem.Text = "逆向转换(&R)";
            this.逆向转换RToolStripMenuItem.Click += new System.EventHandler(this.逆向转换RToolStripMenuItem_Click);
            // 
            // 视图VToolStripMenuItem
            // 
            this.视图VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.转换语句视图CToolStripMenuItem,
            this.输出OToolStripMenuItem});
            this.视图VToolStripMenuItem.Name = "视图VToolStripMenuItem";
            this.视图VToolStripMenuItem.Size = new System.Drawing.Size(86, 28);
            this.视图VToolStripMenuItem.Text = "视图(&V)";
            // 
            // 转换语句视图CToolStripMenuItem
            // 
            this.转换语句视图CToolStripMenuItem.Name = "转换语句视图CToolStripMenuItem";
            this.转换语句视图CToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.转换语句视图CToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.转换语句视图CToolStripMenuItem.Text = "转换语句视图(&C)";
            this.转换语句视图CToolStripMenuItem.Click += new System.EventHandler(this.转换语句视图CToolStripMenuItem_Click);
            // 
            // 输出OToolStripMenuItem
            // 
            this.输出OToolStripMenuItem.Name = "输出OToolStripMenuItem";
            this.输出OToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.输出OToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.输出OToolStripMenuItem.Text = "输出(&O)";
            this.输出OToolStripMenuItem.Click += new System.EventHandler(this.输出OToolStripMenuItem_Click);
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项OToolStripMenuItem});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // 选项OToolStripMenuItem
            // 
            this.选项OToolStripMenuItem.Name = "选项OToolStripMenuItem";
            this.选项OToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.选项OToolStripMenuItem.Text = "选项(&O)...";
            this.选项OToolStripMenuItem.Click += new System.EventHandler(this.选项OToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于DynverterAToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(88, 28);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于DynverterAToolStripMenuItem
            // 
            this.关于DynverterAToolStripMenuItem.Name = "关于DynverterAToolStripMenuItem";
            this.关于DynverterAToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.关于DynverterAToolStripMenuItem.Text = "关于Dynverter(&A)...";
            this.关于DynverterAToolStripMenuItem.Click += new System.EventHandler(this.关于DynverterAToolStripMenuItem_Click);
            // 
            // ToolStrip
            // 
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnConvert,
            this.BtnRConvert});
            this.ToolStrip.Location = new System.Drawing.Point(1, 33);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip.Size = new System.Drawing.Size(1233, 33);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // BtnConvert
            // 
            this.BtnConvert.Image = global::Dynverter.Properties.Resources.convert;
            this.BtnConvert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(74, 28);
            this.BtnConvert.Text = "转换";
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // BtnRConvert
            // 
            this.BtnRConvert.Image = global::Dynverter.Properties.Resources.rconvert;
            this.BtnRConvert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRConvert.Name = "BtnRConvert";
            this.BtnRConvert.Size = new System.Drawing.Size(110, 28);
            this.BtnRConvert.Text = "逆向转换";
            this.BtnRConvert.Click += new System.EventHandler(this.BtnRConvert_Click);
            // 
            // SplitContainerRtxs
            // 
            this.SplitContainerRtxs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerRtxs.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerRtxs.Name = "SplitContainerRtxs";
            // 
            // SplitContainerRtxs.Panel1
            // 
            this.SplitContainerRtxs.Panel1.Controls.Add(this.TabSourceSql);
            this.SplitContainerRtxs.Panel1.Controls.Add(this.StatusStripRtxSourceSql);
            // 
            // SplitContainerRtxs.Panel2
            // 
            this.SplitContainerRtxs.Panel2.Controls.Add(this.TabConvertedSql);
            this.SplitContainerRtxs.Panel2.Controls.Add(this.StatusStripRtxConvertedSql);
            this.SplitContainerRtxs.Size = new System.Drawing.Size(1233, 227);
            this.SplitContainerRtxs.SplitterDistance = 495;
            this.SplitContainerRtxs.TabIndex = 2;
            // 
            // TabSourceSql
            // 
            this.TabSourceSql.Controls.Add(this.TabPageSourceSql);
            this.TabSourceSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabSourceSql.Location = new System.Drawing.Point(0, 0);
            this.TabSourceSql.Name = "TabSourceSql";
            this.TabSourceSql.SelectedIndex = 0;
            this.TabSourceSql.Size = new System.Drawing.Size(495, 227);
            this.TabSourceSql.TabIndex = 2;
            // 
            // TabPageSourceSql
            // 
            this.TabPageSourceSql.Controls.Add(this.RtxSourceSql);
            this.TabPageSourceSql.Location = new System.Drawing.Point(4, 28);
            this.TabPageSourceSql.Name = "TabPageSourceSql";
            this.TabPageSourceSql.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSourceSql.Size = new System.Drawing.Size(487, 195);
            this.TabPageSourceSql.TabIndex = 0;
            this.TabPageSourceSql.Text = "原始语句";
            this.TabPageSourceSql.UseVisualStyleBackColor = true;
            // 
            // RtxSourceSql
            // 
            this.RtxSourceSql.AcceptsTab = true;
            this.RtxSourceSql.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtxSourceSql.ContextMenuStrip = this.ConMenuStripRtxSourceSql;
            this.RtxSourceSql.DetectUrls = false;
            this.RtxSourceSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxSourceSql.Font = new System.Drawing.Font("宋体", 10.5F);
            this.RtxSourceSql.Location = new System.Drawing.Point(3, 3);
            this.RtxSourceSql.Name = "RtxSourceSql";
            this.RtxSourceSql.Size = new System.Drawing.Size(481, 189);
            this.RtxSourceSql.TabIndex = 1;
            this.RtxSourceSql.TabStop = false;
            this.RtxSourceSql.Text = "";
            this.RtxSourceSql.WordWrap = false;
            this.RtxSourceSql.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RtxSource_KeyDown);
            // 
            // ConMenuStripRtxSourceSql
            // 
            this.ConMenuStripRtxSourceSql.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ConMenuStripRtxSourceSql.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.粘贴并转换PToolStripMenuItem,
            this.粘贴并逆向转换RToolStripMenuItem,
            this.清空CToolStripMenuItem});
            this.ConMenuStripRtxSourceSql.Name = "ConMenuStripRtxSourceSql";
            this.ConMenuStripRtxSourceSql.Size = new System.Drawing.Size(239, 100);
            // 
            // 粘贴并转换PToolStripMenuItem
            // 
            this.粘贴并转换PToolStripMenuItem.Image = global::Dynverter.Properties.Resources.convert;
            this.粘贴并转换PToolStripMenuItem.Name = "粘贴并转换PToolStripMenuItem";
            this.粘贴并转换PToolStripMenuItem.Size = new System.Drawing.Size(238, 32);
            this.粘贴并转换PToolStripMenuItem.Text = "粘贴并转换(&P)";
            this.粘贴并转换PToolStripMenuItem.Click += new System.EventHandler(this.粘贴并转换PToolStripMenuItem_Click);
            // 
            // 粘贴并逆向转换RToolStripMenuItem
            // 
            this.粘贴并逆向转换RToolStripMenuItem.Image = global::Dynverter.Properties.Resources.rconvert;
            this.粘贴并逆向转换RToolStripMenuItem.Name = "粘贴并逆向转换RToolStripMenuItem";
            this.粘贴并逆向转换RToolStripMenuItem.Size = new System.Drawing.Size(238, 32);
            this.粘贴并逆向转换RToolStripMenuItem.Text = "粘贴并逆向转换(&R)";
            this.粘贴并逆向转换RToolStripMenuItem.Click += new System.EventHandler(this.粘贴并逆向转换RToolStripMenuItem_Click);
            // 
            // 清空CToolStripMenuItem
            // 
            this.清空CToolStripMenuItem.Name = "清空CToolStripMenuItem";
            this.清空CToolStripMenuItem.Size = new System.Drawing.Size(238, 32);
            this.清空CToolStripMenuItem.Text = "清空(&C)";
            this.清空CToolStripMenuItem.Click += new System.EventHandler(this.清空CToolStripMenuItem_Click);
            // 
            // StatusStripRtxSourceSql
            // 
            this.StatusStripRtxSourceSql.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStripRtxSourceSql.Location = new System.Drawing.Point(0, 200);
            this.StatusStripRtxSourceSql.Name = "StatusStripRtxSourceSql";
            this.StatusStripRtxSourceSql.Size = new System.Drawing.Size(495, 28);
            this.StatusStripRtxSourceSql.SizingGrip = false;
            this.StatusStripRtxSourceSql.TabIndex = 0;
            this.StatusStripRtxSourceSql.Text = "statusStrip1";
            this.StatusStripRtxSourceSql.Visible = false;
            // 
            // TabConvertedSql
            // 
            this.TabConvertedSql.Controls.Add(this.TabPageConvertedSql);
            this.TabConvertedSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabConvertedSql.Location = new System.Drawing.Point(0, 0);
            this.TabConvertedSql.Name = "TabConvertedSql";
            this.TabConvertedSql.SelectedIndex = 0;
            this.TabConvertedSql.Size = new System.Drawing.Size(734, 227);
            this.TabConvertedSql.TabIndex = 3;
            // 
            // TabPageConvertedSql
            // 
            this.TabPageConvertedSql.Controls.Add(this.RtxConvertedSql);
            this.TabPageConvertedSql.Location = new System.Drawing.Point(4, 28);
            this.TabPageConvertedSql.Name = "TabPageConvertedSql";
            this.TabPageConvertedSql.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageConvertedSql.Size = new System.Drawing.Size(726, 195);
            this.TabPageConvertedSql.TabIndex = 0;
            this.TabPageConvertedSql.Text = "转换语句";
            this.TabPageConvertedSql.UseVisualStyleBackColor = true;
            // 
            // RtxConvertedSql
            // 
            this.RtxConvertedSql.AcceptsTab = true;
            this.RtxConvertedSql.BackColor = System.Drawing.SystemColors.Window;
            this.RtxConvertedSql.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtxConvertedSql.ContextMenuStrip = this.ConMenuStripRtxConvertedSql;
            this.RtxConvertedSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxConvertedSql.Font = new System.Drawing.Font("宋体", 10.5F);
            this.RtxConvertedSql.Location = new System.Drawing.Point(3, 3);
            this.RtxConvertedSql.Name = "RtxConvertedSql";
            this.RtxConvertedSql.ReadOnly = true;
            this.RtxConvertedSql.Size = new System.Drawing.Size(720, 189);
            this.RtxConvertedSql.TabIndex = 2;
            this.RtxConvertedSql.TabStop = false;
            this.RtxConvertedSql.Text = "";
            this.RtxConvertedSql.WordWrap = false;
            // 
            // ConMenuStripRtxConvertedSql
            // 
            this.ConMenuStripRtxConvertedSql.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ConMenuStripRtxConvertedSql.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制内容到剪切板CToolStripMenuItem});
            this.ConMenuStripRtxConvertedSql.Name = "ConMenuStripRtxConvertedSql";
            this.ConMenuStripRtxConvertedSql.Size = new System.Drawing.Size(249, 34);
            // 
            // 复制内容到剪切板CToolStripMenuItem
            // 
            this.复制内容到剪切板CToolStripMenuItem.Name = "复制内容到剪切板CToolStripMenuItem";
            this.复制内容到剪切板CToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.复制内容到剪切板CToolStripMenuItem.Text = "复制内容到剪切板(&C)";
            this.复制内容到剪切板CToolStripMenuItem.Click += new System.EventHandler(this.复制内容到剪切板CToolStripMenuItem_Click);
            // 
            // StatusStripRtxConvertedSql
            // 
            this.StatusStripRtxConvertedSql.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStripRtxConvertedSql.Location = new System.Drawing.Point(0, 200);
            this.StatusStripRtxConvertedSql.Name = "StatusStripRtxConvertedSql";
            this.StatusStripRtxConvertedSql.Size = new System.Drawing.Size(734, 28);
            this.StatusStripRtxConvertedSql.SizingGrip = false;
            this.StatusStripRtxConvertedSql.TabIndex = 0;
            this.StatusStripRtxConvertedSql.Text = "statusStrip2";
            this.StatusStripRtxConvertedSql.Visible = false;
            // 
            // SplitContainerOutput
            // 
            this.SplitContainerOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerOutput.Location = new System.Drawing.Point(1, 66);
            this.SplitContainerOutput.Name = "SplitContainerOutput";
            this.SplitContainerOutput.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainerOutput.Panel1
            // 
            this.SplitContainerOutput.Panel1.Controls.Add(this.SplitContainerRtxs);
            // 
            // SplitContainerOutput.Panel2
            // 
            this.SplitContainerOutput.Panel2.Controls.Add(this.TabOutput);
            this.SplitContainerOutput.Size = new System.Drawing.Size(1233, 459);
            this.SplitContainerOutput.SplitterDistance = 227;
            this.SplitContainerOutput.TabIndex = 3;
            // 
            // TabOutput
            // 
            this.TabOutput.Controls.Add(this.TabPageOutput);
            this.TabOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabOutput.Location = new System.Drawing.Point(0, 0);
            this.TabOutput.Name = "TabOutput";
            this.TabOutput.SelectedIndex = 0;
            this.TabOutput.Size = new System.Drawing.Size(1233, 228);
            this.TabOutput.TabIndex = 0;
            // 
            // TabPageOutput
            // 
            this.TabPageOutput.BackColor = System.Drawing.Color.White;
            this.TabPageOutput.Controls.Add(this.RtxOutput);
            this.TabPageOutput.Location = new System.Drawing.Point(4, 28);
            this.TabPageOutput.Name = "TabPageOutput";
            this.TabPageOutput.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageOutput.Size = new System.Drawing.Size(1225, 196);
            this.TabPageOutput.TabIndex = 0;
            this.TabPageOutput.Text = "输出";
            // 
            // RtxOutput
            // 
            this.RtxOutput.BackColor = System.Drawing.SystemColors.Window;
            this.RtxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtxOutput.ContextMenuStrip = this.ConMenuStripRtxOutput;
            this.RtxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxOutput.Font = new System.Drawing.Font("宋体", 10.5F);
            this.RtxOutput.Location = new System.Drawing.Point(3, 3);
            this.RtxOutput.Name = "RtxOutput";
            this.RtxOutput.ReadOnly = true;
            this.RtxOutput.Size = new System.Drawing.Size(1219, 190);
            this.RtxOutput.TabIndex = 0;
            this.RtxOutput.Text = "";
            // 
            // ConMenuStripRtxOutput
            // 
            this.ConMenuStripRtxOutput.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ConMenuStripRtxOutput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空内容CToolStripMenuItem,
            this.隐藏输出窗口HToolStripMenuItem});
            this.ConMenuStripRtxOutput.Name = "ConMenuStripRtxOutput";
            this.ConMenuStripRtxOutput.Size = new System.Drawing.Size(215, 64);
            // 
            // 清空内容CToolStripMenuItem
            // 
            this.清空内容CToolStripMenuItem.Name = "清空内容CToolStripMenuItem";
            this.清空内容CToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.清空内容CToolStripMenuItem.Text = "清空内容(&C)";
            this.清空内容CToolStripMenuItem.Click += new System.EventHandler(this.清空内容CToolStripMenuItem_Click);
            // 
            // 隐藏输出窗口HToolStripMenuItem
            // 
            this.隐藏输出窗口HToolStripMenuItem.Name = "隐藏输出窗口HToolStripMenuItem";
            this.隐藏输出窗口HToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.隐藏输出窗口HToolStripMenuItem.Text = "隐藏输出窗口(&H)";
            this.隐藏输出窗口HToolStripMenuItem.Click += new System.EventHandler(this.隐藏输出窗口HToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1235, 526);
            this.Controls.Add(this.SplitContainerOutput);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Dynverter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.SplitContainerRtxs.Panel1.ResumeLayout(false);
            this.SplitContainerRtxs.Panel1.PerformLayout();
            this.SplitContainerRtxs.Panel2.ResumeLayout(false);
            this.SplitContainerRtxs.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerRtxs)).EndInit();
            this.SplitContainerRtxs.ResumeLayout(false);
            this.TabSourceSql.ResumeLayout(false);
            this.TabPageSourceSql.ResumeLayout(false);
            this.ConMenuStripRtxSourceSql.ResumeLayout(false);
            this.TabConvertedSql.ResumeLayout(false);
            this.TabPageConvertedSql.ResumeLayout(false);
            this.ConMenuStripRtxConvertedSql.ResumeLayout(false);
            this.SplitContainerOutput.Panel1.ResumeLayout(false);
            this.SplitContainerOutput.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerOutput)).EndInit();
            this.SplitContainerOutput.ResumeLayout(false);
            this.TabOutput.ResumeLayout(false);
            this.TabPageOutput.ResumeLayout(false);
            this.ConMenuStripRtxOutput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.SplitContainer SplitContainerRtxs;
        private System.Windows.Forms.RichTextBox RtxSourceSql;
        private System.Windows.Forms.StatusStrip StatusStripRtxSourceSql;
        private System.Windows.Forms.StatusStrip StatusStripRtxConvertedSql;
        private System.Windows.Forms.ToolStripButton BtnConvert;
        private System.Windows.Forms.ToolStripMenuItem 视图VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 转换语句视图CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于DynverterAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 转换CToolStripMenuItem;
        private System.Windows.Forms.SplitContainer SplitContainerOutput;
        private System.Windows.Forms.TabControl TabOutput;
        private System.Windows.Forms.TabPage TabPageOutput;
        private System.Windows.Forms.TabControl TabSourceSql;
        private System.Windows.Forms.TabPage TabPageSourceSql;
        private System.Windows.Forms.TabControl TabConvertedSql;
        private System.Windows.Forms.TabPage TabPageConvertedSql;
        private System.Windows.Forms.ToolStripMenuItem 输出OToolStripMenuItem;
        private System.Windows.Forms.RichTextBox RtxOutput;
        private System.Windows.Forms.RichTextBox RtxConvertedSql;
        private System.Windows.Forms.ContextMenuStrip ConMenuStripRtxSourceSql;
        private System.Windows.Forms.ToolStripMenuItem 清空CToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ConMenuStripRtxConvertedSql;
        private System.Windows.Forms.ToolStripMenuItem 复制内容到剪切板CToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ConMenuStripRtxOutput;
        private System.Windows.Forms.ToolStripMenuItem 清空内容CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏输出窗口HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴并转换PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 逆向转换RToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton BtnRConvert;
        private System.Windows.Forms.ToolStripMenuItem 粘贴并逆向转换RToolStripMenuItem;
    }
}

