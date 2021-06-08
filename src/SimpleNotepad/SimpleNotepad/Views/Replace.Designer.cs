
namespace SimpleNotepad.Views
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
            this.txtReplaced = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.lblReplaced = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkCaseSensitive
            // 
            this.chkCaseSensitive.AutoSize = true;
            this.chkCaseSensitive.Location = new System.Drawing.Point(11, 67);
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
            // 
            // txtReplaced
            // 
            this.txtReplaced.Location = new System.Drawing.Point(103, 37);
            this.txtReplaced.Margin = new System.Windows.Forms.Padding(2);
            this.txtReplaced.Name = "txtReplaced";
            this.txtReplaced.Size = new System.Drawing.Size(310, 19);
            this.txtReplaced.TabIndex = 10;
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(103, 11);
            this.txtTarget.Margin = new System.Windows.Forms.Padding(2);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(310, 19);
            this.txtTarget.TabIndex = 8;
            // 
            // lblReplaced
            // 
            this.lblReplaced.AutoSize = true;
            this.lblReplaced.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblReplaced.Location = new System.Drawing.Point(10, 39);
            this.lblReplaced.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReplaced.Name = "lblReplaced";
            this.lblReplaced.Size = new System.Drawing.Size(87, 12);
            this.lblReplaced.TabIndex = 9;
            this.lblReplaced.Text = "置換後の文字列";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(10, 13);
            this.lblTarget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(84, 12);
            this.lblTarget.TabIndex = 7;
            this.lblTarget.Text = "検索する文字列";
            // 
            // Replace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 97);
            this.Controls.Add(this.chkCaseSensitive);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtReplaced);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.lblReplaced);
            this.Controls.Add(this.lblTarget);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Replace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "置換";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCaseSensitive;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtReplaced;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Label lblReplaced;
        private System.Windows.Forms.Label lblTarget;
    }
}