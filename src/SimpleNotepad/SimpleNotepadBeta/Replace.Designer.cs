
namespace SimpleNotepadBeta
{
    partial class Replace
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
            this.chkCaseSensitive = new System.Windows.Forms.CheckBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblOld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkCaseSensitive
            // 
            this.chkCaseSensitive.AutoSize = true;
            this.chkCaseSensitive.Location = new System.Drawing.Point(12, 67);
            this.chkCaseSensitive.Margin = new System.Windows.Forms.Padding(2);
            this.chkCaseSensitive.Name = "chkCaseSensitive";
            this.chkCaseSensitive.Size = new System.Drawing.Size(156, 16);
            this.chkCaseSensitive.TabIndex = 11;
            this.chkCaseSensitive.Text = "大文字と小文字を区別する";
            this.chkCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(348, 63);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(2);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(66, 23);
            this.btnReplace.TabIndex = 12;
            this.btnReplace.Text = "置換実行";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(271, 63);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(103, 37);
            this.txtNew.Margin = new System.Windows.Forms.Padding(2);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(254, 19);
            this.txtNew.TabIndex = 10;
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(103, 11);
            this.txtOld.Margin = new System.Windows.Forms.Padding(2);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(254, 19);
            this.txtOld.TabIndex = 8;
            this.txtOld.TextChanged += new System.EventHandler(this.txtOld_TextChanged);
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNew.Location = new System.Drawing.Point(10, 39);
            this.lblNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(87, 12);
            this.lblNew.TabIndex = 9;
            this.lblNew.Text = "置換後の文字列";
            // 
            // lblOld
            // 
            this.lblOld.AutoSize = true;
            this.lblOld.Location = new System.Drawing.Point(10, 13);
            this.lblOld.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(84, 12);
            this.lblOld.TabIndex = 7;
            this.lblOld.Text = "検索する文字列";
            // 
            // Replace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 97);
            this.Controls.Add(this.chkCaseSensitive);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lblOld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Replace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "置換";
            this.Load += new System.EventHandler(this.Replace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCaseSensitive;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblOld;
    }
}