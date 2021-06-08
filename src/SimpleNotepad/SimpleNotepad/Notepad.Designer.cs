
namespace SimpleNotepad
{
    partial class Notepad
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMain = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnReplace = new System.Windows.Forms.ToolStripButton();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.mnuMain.SuspendLayout();
            this.tlsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(600, 30);
            this.mnuMain.TabIndex = 0;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.mnuSaveAs});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(82, 26);
            this.mnuFile.Text = "ファイル(&F)";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNew.Size = new System.Drawing.Size(320, 26);
            this.mnuNew.Text = "新規作成(&N)";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpen.Size = new System.Drawing.Size(320, 26);
            this.mnuOpen.Text = "開く(&O)...";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(320, 26);
            this.mnuSave.Text = "上書き保存(&S)";
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mnuSaveAs.Size = new System.Drawing.Size(320, 26);
            this.mnuSaveAs.Text = "名前を付けて保存(&A)...";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReplace});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(71, 26);
            this.mnuEdit.Text = "編集(&E)";
            // 
            // mnuReplace
            // 
            this.mnuReplace.Name = "mnuReplace";
            this.mnuReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mnuReplace.Size = new System.Drawing.Size(203, 26);
            this.mnuReplace.Text = "置換(&R)...";
            // 
            // tlsMain
            // 
            this.tlsMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnReplace});
            this.tlsMain.Location = new System.Drawing.Point(0, 30);
            this.tlsMain.Name = "tlsMain";
            this.tlsMain.Size = new System.Drawing.Size(600, 31);
            this.tlsMain.TabIndex = 1;
            this.tlsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(29, 28);
            this.btnSave.Text = "上書き保存";
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReplace.Image = ((System.Drawing.Image)(resources.GetObject("btnReplace.Image")));
            this.btnReplace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(29, 28);
            this.btnReplace.Text = "置換";
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 61);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(600, 299);
            this.tabMain.TabIndex = 2;
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.tlsMain);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Notepad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "簡易メモ帳";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.tlsMain.ResumeLayout(false);
            this.tlsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuReplace;
        private System.Windows.Forms.ToolStrip tlsMain;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnReplace;
        private System.Windows.Forms.TabControl tabMain;
    }
}

