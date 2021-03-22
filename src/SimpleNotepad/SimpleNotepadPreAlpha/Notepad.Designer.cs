
namespace SimpleNotepadPreAlpha
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.pnlToolBar = new System.Windows.Forms.Panel();
            this.pnlToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 9);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(113, 29);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "新規作成";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(134, 9);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(113, 29);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "開く";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(256, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "上書き保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(378, 9);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(113, 29);
            this.btnSaveAs.TabIndex = 3;
            this.btnSaveAs.Text = "名前をつけて保存";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            // 
            // txtMain
            // 
            this.txtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMain.Location = new System.Drawing.Point(0, 46);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(800, 404);
            this.txtMain.TabIndex = 4;
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Controls.Add(this.btnNew);
            this.pnlToolBar.Controls.Add(this.btnSaveAs);
            this.pnlToolBar.Controls.Add(this.btnOpen);
            this.pnlToolBar.Controls.Add(this.btnSave);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(800, 46);
            this.pnlToolBar.TabIndex = 5;
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "Notepad";
            this.Text = "簡易メモ帳 - (無題)";
            this.pnlToolBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.Panel pnlToolBar;
    }
}

