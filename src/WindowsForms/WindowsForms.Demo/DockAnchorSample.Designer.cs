
namespace WindowsForms.Demo
{
    partial class DockAnchorSample
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
            this.btnDock = new System.Windows.Forms.Button();
            this.btnAnchor = new System.Windows.Forms.Button();
            this.btnAnchor2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDock
            // 
            this.btnDock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDock.Location = new System.Drawing.Point(0, 0);
            this.btnDock.Name = "btnDock";
            this.btnDock.Size = new System.Drawing.Size(666, 151);
            this.btnDock.TabIndex = 0;
            this.btnDock.Text = "Dock";
            this.btnDock.UseVisualStyleBackColor = true;
            // 
            // btnAnchor
            // 
            this.btnAnchor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnchor.Location = new System.Drawing.Point(536, 316);
            this.btnAnchor.Name = "btnAnchor";
            this.btnAnchor.Size = new System.Drawing.Size(98, 36);
            this.btnAnchor.TabIndex = 1;
            this.btnAnchor.Text = "Anchor";
            this.btnAnchor.UseVisualStyleBackColor = true;
            // 
            // btnAnchor2
            // 
            this.btnAnchor2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnchor2.Location = new System.Drawing.Point(188, 176);
            this.btnAnchor2.Name = "btnAnchor2";
            this.btnAnchor2.Size = new System.Drawing.Size(288, 118);
            this.btnAnchor2.TabIndex = 2;
            this.btnAnchor2.Text = "Anchor2";
            this.btnAnchor2.UseVisualStyleBackColor = true;
            // 
            // DockAnchorSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 389);
            this.Controls.Add(this.btnAnchor2);
            this.Controls.Add(this.btnAnchor);
            this.Controls.Add(this.btnDock);
            this.Name = "DockAnchorSample";
            this.Text = "DockAnchorSample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDock;
        private System.Windows.Forms.Button btnAnchor;
        private System.Windows.Forms.Button btnAnchor2;
    }
}