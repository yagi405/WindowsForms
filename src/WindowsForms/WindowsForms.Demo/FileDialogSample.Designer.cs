
namespace WindowsForms.Demo
{
    partial class FileDialogSample
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
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(73, 58);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(119, 47);
            this.btnOpenFileDialog.TabIndex = 0;
            this.btnOpenFileDialog.Text = "OpenFileDialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Location = new System.Drawing.Point(271, 58);
            this.SaveFileDialog.Name = "SaveFileDialog";
            this.SaveFileDialog.Size = new System.Drawing.Size(119, 47);
            this.SaveFileDialog.TabIndex = 1;
            this.SaveFileDialog.Text = "SaveFileDialog";
            this.SaveFileDialog.UseVisualStyleBackColor = true;
            this.SaveFileDialog.Click += new System.EventHandler(this.SaveFileDialog_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(73, 130);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(317, 19);
            this.txtValue.TabIndex = 2;
            // 
            // FileDialogSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 219);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.SaveFileDialog);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Name = "FileDialogSample";
            this.Text = "FileDialogSample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.Button SaveFileDialog;
        private System.Windows.Forms.TextBox txtValue;
    }
}