
namespace WindowsForms.Demo
{
    partial class Hello
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
            this.btnHello = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.txtHello = new System.Windows.Forms.TextBox();
            this.chkHello = new System.Windows.Forms.CheckBox();
            this.rdoFoo = new System.Windows.Forms.RadioButton();
            this.rdoBar = new System.Windows.Forms.RadioButton();
            this.cmbHello = new System.Windows.Forms.ComboBox();
            this.dtpHello = new System.Windows.Forms.DateTimePicker();
            this.pnlHello = new System.Windows.Forms.Panel();
            this.rdoQux = new System.Windows.Forms.RadioButton();
            this.rdoBaz = new System.Windows.Forms.RadioButton();
            this.grpHello = new System.Windows.Forms.GroupBox();
            this.pnlHello.SuspendLayout();
            this.grpHello.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(67, 23);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(104, 38);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHello.Location = new System.Drawing.Point(18, 42);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(54, 19);
            this.lblHello.TabIndex = 1;
            this.lblHello.Text = "Hello";
            // 
            // txtHello
            // 
            this.txtHello.Location = new System.Drawing.Point(79, 42);
            this.txtHello.Name = "txtHello";
            this.txtHello.Size = new System.Drawing.Size(100, 19);
            this.txtHello.TabIndex = 3;
            // 
            // chkHello
            // 
            this.chkHello.AutoSize = true;
            this.chkHello.Location = new System.Drawing.Point(92, 86);
            this.chkHello.Name = "chkHello";
            this.chkHello.Size = new System.Drawing.Size(50, 16);
            this.chkHello.TabIndex = 4;
            this.chkHello.Text = "Hello";
            this.chkHello.UseVisualStyleBackColor = true;
            // 
            // rdoFoo
            // 
            this.rdoFoo.AutoSize = true;
            this.rdoFoo.Location = new System.Drawing.Point(300, 74);
            this.rdoFoo.Name = "rdoFoo";
            this.rdoFoo.Size = new System.Drawing.Size(42, 16);
            this.rdoFoo.TabIndex = 5;
            this.rdoFoo.TabStop = true;
            this.rdoFoo.Text = "Foo";
            this.rdoFoo.UseVisualStyleBackColor = true;
            // 
            // rdoBar
            // 
            this.rdoBar.AutoSize = true;
            this.rdoBar.Location = new System.Drawing.Point(300, 96);
            this.rdoBar.Name = "rdoBar";
            this.rdoBar.Size = new System.Drawing.Size(41, 16);
            this.rdoBar.TabIndex = 6;
            this.rdoBar.TabStop = true;
            this.rdoBar.Text = "Bar";
            this.rdoBar.UseVisualStyleBackColor = true;
            // 
            // cmbHello
            // 
            this.cmbHello.FormattingEnabled = true;
            this.cmbHello.Items.AddRange(new object[] {
            "foo",
            "bar",
            "baz"});
            this.cmbHello.Location = new System.Drawing.Point(67, 169);
            this.cmbHello.Name = "cmbHello";
            this.cmbHello.Size = new System.Drawing.Size(121, 20);
            this.cmbHello.TabIndex = 7;
            // 
            // dtpHello
            // 
            this.dtpHello.Location = new System.Drawing.Point(242, 170);
            this.dtpHello.Name = "dtpHello";
            this.dtpHello.Size = new System.Drawing.Size(200, 19);
            this.dtpHello.TabIndex = 8;
            // 
            // pnlHello
            // 
            this.pnlHello.BackColor = System.Drawing.Color.DarkGray;
            this.pnlHello.Controls.Add(this.rdoQux);
            this.pnlHello.Controls.Add(this.rdoBaz);
            this.pnlHello.Location = new System.Drawing.Point(490, 35);
            this.pnlHello.Name = "pnlHello";
            this.pnlHello.Size = new System.Drawing.Size(212, 127);
            this.pnlHello.TabIndex = 9;
            // 
            // rdoQux
            // 
            this.rdoQux.AutoSize = true;
            this.rdoQux.Location = new System.Drawing.Point(48, 62);
            this.rdoQux.Name = "rdoQux";
            this.rdoQux.Size = new System.Drawing.Size(43, 16);
            this.rdoQux.TabIndex = 1;
            this.rdoQux.TabStop = true;
            this.rdoQux.Text = "Qux";
            this.rdoQux.UseVisualStyleBackColor = true;
            // 
            // rdoBaz
            // 
            this.rdoBaz.AutoSize = true;
            this.rdoBaz.Location = new System.Drawing.Point(48, 39);
            this.rdoBaz.Name = "rdoBaz";
            this.rdoBaz.Size = new System.Drawing.Size(42, 16);
            this.rdoBaz.TabIndex = 0;
            this.rdoBaz.TabStop = true;
            this.rdoBaz.Text = "Baz";
            this.rdoBaz.UseVisualStyleBackColor = true;
            // 
            // grpHello
            // 
            this.grpHello.Controls.Add(this.lblHello);
            this.grpHello.Controls.Add(this.txtHello);
            this.grpHello.Location = new System.Drawing.Point(490, 189);
            this.grpHello.Name = "grpHello";
            this.grpHello.Size = new System.Drawing.Size(200, 100);
            this.grpHello.TabIndex = 10;
            this.grpHello.TabStop = false;
            this.grpHello.Text = "Hello";
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 316);
            this.Controls.Add(this.grpHello);
            this.Controls.Add(this.pnlHello);
            this.Controls.Add(this.dtpHello);
            this.Controls.Add(this.cmbHello);
            this.Controls.Add(this.rdoBar);
            this.Controls.Add(this.rdoFoo);
            this.Controls.Add(this.chkHello);
            this.Controls.Add(this.btnHello);
            this.Name = "Hello";
            this.Text = "Hello";
            this.Load += new System.EventHandler(this.Hello_Load);
            this.pnlHello.ResumeLayout(false);
            this.pnlHello.PerformLayout();
            this.grpHello.ResumeLayout(false);
            this.grpHello.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.TextBox txtHello;
        private System.Windows.Forms.CheckBox chkHello;
        private System.Windows.Forms.RadioButton rdoFoo;
        private System.Windows.Forms.RadioButton rdoBar;
        private System.Windows.Forms.ComboBox cmbHello;
        private System.Windows.Forms.DateTimePicker dtpHello;
        private System.Windows.Forms.Panel pnlHello;
        private System.Windows.Forms.RadioButton rdoQux;
        private System.Windows.Forms.RadioButton rdoBaz;
        private System.Windows.Forms.GroupBox grpHello;
    }
}