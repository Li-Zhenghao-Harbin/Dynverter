namespace Dynverter
{
    partial class FrmParameters
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
            this.PnParameters = new System.Windows.Forms.Panel();
            this.RtxParameters = new System.Windows.Forms.RichTextBox();
            this.PnBtns.SuspendLayout();
            this.PnParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnBtns
            // 
            this.PnBtns.Controls.Add(this.BtnConfirm);
            this.PnBtns.Controls.Add(this.BtnCancel);
            this.PnBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnBtns.Location = new System.Drawing.Point(0, 267);
            this.PnBtns.Name = "PnBtns";
            this.PnBtns.Padding = new System.Windows.Forms.Padding(10);
            this.PnBtns.Size = new System.Drawing.Size(638, 50);
            this.PnBtns.TabIndex = 1;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnConfirm.Location = new System.Drawing.Point(378, 10);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(150, 30);
            this.BtnConfirm.TabIndex = 1;
            this.BtnConfirm.Text = "确认并匹配";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCancel.Location = new System.Drawing.Point(528, 10);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 30);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PnParameters
            // 
            this.PnParameters.Controls.Add(this.RtxParameters);
            this.PnParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnParameters.Location = new System.Drawing.Point(0, 0);
            this.PnParameters.Name = "PnParameters";
            this.PnParameters.Padding = new System.Windows.Forms.Padding(10);
            this.PnParameters.Size = new System.Drawing.Size(638, 267);
            this.PnParameters.TabIndex = 2;
            // 
            // RtxParameters
            // 
            this.RtxParameters.AcceptsTab = true;
            this.RtxParameters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtxParameters.DetectUrls = false;
            this.RtxParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxParameters.Font = new System.Drawing.Font("宋体", 10.5F);
            this.RtxParameters.Location = new System.Drawing.Point(10, 10);
            this.RtxParameters.Name = "RtxParameters";
            this.RtxParameters.Size = new System.Drawing.Size(618, 247);
            this.RtxParameters.TabIndex = 3;
            this.RtxParameters.TabStop = false;
            this.RtxParameters.Text = "";
            // 
            // FrmParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 317);
            this.Controls.Add(this.PnParameters);
            this.Controls.Add(this.PnBtns);
            this.MinimizeBox = false;
            this.Name = "FrmParameters";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "参数";
            this.Load += new System.EventHandler(this.FrmParameters_Load);
            this.PnBtns.ResumeLayout(false);
            this.PnParameters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnBtns;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel PnParameters;
        private System.Windows.Forms.RichTextBox RtxParameters;
    }
}